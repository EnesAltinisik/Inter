/*Ratings*/
!function(t){function a(a,r){t('.raterater-input[data-id="'+a+'"]').data("input").val(r).change()}function r(){g.each(function(){var a=t(this);if(p.mode==u&&("INPUT"==a.prop("tagName")||"SELECT"==a.prop("tagName"))){var r="input-"+y++,e=t('<div class="raterater-input"></div>').attr("data-id",r).attr("data-rating",a.val()).data("input",a);a.attr("data-id",r).attr("data-id",r).attr("data-rating",a.val()).data("input",a).after(e).hide(),l=a=e}l=a;var s=c(a);if(!s)throw"Error: Each raterater element needs a unique data-id attribute.";f[s]={state:"inactive",stars:null},"static"===a.css("position")&&a.css("position","relative"),a.addClass("raterater-wrapper"),a.html(""),t.each(["bg","hover","rating","outline","cover"],function(){a.append(' <div class="raterater-layer raterater-'+this+'-layer"></div>')});for(var n=0;n<p.numStars;n++)a.children(".raterater-bg-layer").first().append('<i class="fa fa-star"></i>'),a.children(".raterater-outline-layer").first().append('<i class="fa fa-star-o"></i>'),a.children(".raterater-hover-layer").first().append('<i class="fa fa-star"></i>'),a.children(".raterater-rating-layer").first().append('<i class="fa fa-star"></i>');p.isStatic||(a.find(".raterater-cover-layer").hover(o,h),a.find(".raterater-cover-layer").mousemove(d),a.find(".raterater-cover-layer").click(i))})}function e(){g.each(function(){var a;a=p.mode==u?t(this).parent().find('.raterater-input[data-id="'+c(this)+'"]'):t(this);var r=(c(a),p.width+"px"),e=Math.floor(p.starWidth/p.starAspect)+"px";a.css("width",r).css("height",e),a.find(".raterater-layer").each(function(){t(this).css("width",r).css("height",e)});for(var i=0;i<p.numStars;i++)t.each(["bg","hover","rating","outline"],function(){a.children(".raterater-"+this+"-layer").first().children("i").eq(i).css("left",i*(p.starWidth+p.spaceWidth)+"px").css("font-size",Math.floor(p.starWidth/p.starAspect)+"px")});var s=parseFloat(a.attr("data-rating")),d=Math.floor(s),o=s-d;n(a.find(".raterater-rating-layer").first(),d,o)})}function i(r){var e=t(r.target).parent(),i=c(e),s=f[i].whole_stars_hover+f[i].partial_star_hover;s=Math.round(100*s)/100,f[i].state="rated",f[i].stars=s,e.find(".raterater-hover-layer").addClass("rated"),"input"!=p.mode&&void 0!==window[p.submitFunction]&&"function"==typeof window[p.submitFunction]?window[p.submitFunction](i,s):a(i,s)}function s(t,a){var r=Math.floor(t/(p.starWidth+p.spaceWidth)),e=t-r*(p.starWidth+p.spaceWidth);if(e>p.starWidth&&(e=p.starWidth),e/=p.starWidth,p.step!==!1){var i=1/p.step;e=Math.round(e*i)/i}f[a].whole_stars_hover=r,f[a].partial_star_hover=e}function n(t,a,r){for(var e=(c(t.parent()),0);a>e;e++)t.find("i").eq(e).css("width",p.starWidth+"px");t.find("i").eq(a).css("width",p.starWidth*r+"px");for(var e=a+1;e<p.numStars;e++)t.find("i").eq(e).css("width","0px")}function d(a){var r=c(t(a.target).parent());if("hover"===f[r].state){var e=a.offsetX;void 0===e&&(e=a.pageX-t(a.target).offset().left),f[r].stars=s(e,r);var i=t(a.target).parent().children(".raterater-hover-layer").first();n(i,f[r].whole_stars_hover,f[r].partial_star_hover)}}function o(a){var r=c(t(a.target).parent());("rated"!==f[r].state||p.allowChange)&&(f[r].state="hover",t(a.target).parent().children(".raterater-rating-layer").first().css("display","none"),t(a.target).parent().children(".raterater-hover-layer").first().css("display","block"))}function h(a){var r=t(a.target).parent(),e=c(r);if(t(a.target).parent().children(".raterater-hover-layer").first().css("display","none"),t(a.target).parent().children(".raterater-rating-layer").first().css("display","block"),"rated"===f[e].state){var i=parseFloat(f[e].stars),s=Math.floor(i),d=i-s;return void n(r.find(".raterater-rating-layer").first(),s,d)}f[e].state="inactive"}function c(a){return t(a).attr("data-id")}var l,f={},p={},u="input",v="callback",g=null,y=0;t.fn.raterater=function(a){if(t.fn.raterater.defaults={submitFunction:"",allowChange:!1,starWidth:20,spaceWidth:5,numStars:5,isStatic:!1,mode:v,step:!1},p=t.extend({},t.fn.raterater.defaults,a),p.width=p.numStars*(p.starWidth+p.spaceWidth),p.starAspect=.9226,p.step!==!1&&(p.step=parseFloat(p.step),p.step<=0||p.step>1))throw"Error: step must be between 0 and 1";return g=this,r(),e(),this}}(jQuery);

$(document).ready(function() {
    $('.ratebox').raterater({ 
    	submitFunction: 'rateAlert',
    	allowChange: false,
    	starWidth: 15,
    	spaceWidth: 2,
    	numStars: 5
    });
    
});

(function(e){var t,o={className:"autosizejs",append:"",callback:!1,resizeDelay:10},i='<textarea tabindex="-1" style="position:absolute; top:-999px; left:0; right:auto; bottom:auto; border:0; padding: 0; -moz-box-sizing:content-box; -webkit-box-sizing:content-box; box-sizing:content-box; word-wrap:break-word; height:0 !important; min-height:0 !important; overflow:hidden; transition:none; -webkit-transition:none; -moz-transition:none;"/>',n=["fontFamily","fontSize","fontWeight","fontStyle","letterSpacing","textTransform","wordSpacing","textIndent"],s=e(i).data("autosize",!0)[0];s.style.lineHeight="99px","99px"===e(s).css("lineHeight")&&n.push("lineHeight"),s.style.lineHeight="",e.fn.autosize=function(i){return this.length?(i=e.extend({},o,i||{}),s.parentNode!==document.body&&e(document.body).append(s),this.each(function(){function o(){var t,o;"getComputedStyle"in window?(t=window.getComputedStyle(u,null),o=u.getBoundingClientRect().width,e.each(["paddingLeft","paddingRight","borderLeftWidth","borderRightWidth"],function(e,i){o-=parseInt(t[i],10)}),s.style.width=o+"px"):s.style.width=Math.max(p.width(),0)+"px"}function a(){var a={};if(t=u,s.className=i.className,d=parseInt(p.css("maxHeight"),10),e.each(n,function(e,t){a[t]=p.css(t)}),e(s).css(a),o(),window.chrome){var r=u.style.width;u.style.width="0px",u.offsetWidth,u.style.width=r}}function r(){var e,n;t!==u?a():o(),s.value=u.value+i.append,s.style.overflowY=u.style.overflowY,n=parseInt(u.style.height,10),s.scrollTop=0,s.scrollTop=9e4,e=s.scrollTop,d&&e>d?(u.style.overflowY="scroll",e=d):(u.style.overflowY="hidden",c>e&&(e=c)),e+=w,n!==e&&(u.style.height=e+"px",f&&i.callback.call(u,u))}function l(){clearTimeout(h),h=setTimeout(function(){var e=p.width();e!==g&&(g=e,r())},parseInt(i.resizeDelay,10))}var d,c,h,u=this,p=e(u),w=0,f=e.isFunction(i.callback),z={height:u.style.height,overflow:u.style.overflow,overflowY:u.style.overflowY,wordWrap:u.style.wordWrap,resize:u.style.resize},g=p.width();p.data("autosize")||(p.data("autosize",!0),("border-box"===p.css("box-sizing")||"border-box"===p.css("-moz-box-sizing")||"border-box"===p.css("-webkit-box-sizing"))&&(w=p.outerHeight()-p.height()),c=Math.max(parseInt(p.css("minHeight"),10)-w||0,p.height()),p.css({overflow:"hidden",overflowY:"hidden",wordWrap:"break-word",resize:"none"===p.css("resize")||"vertical"===p.css("resize")?"none":"horizontal"}),"onpropertychange"in u?"oninput"in u?p.on("input.autosize keyup.autosize",r):p.on("propertychange.autosize",function(){"value"===event.propertyName&&r()}):p.on("input.autosize",r),i.resizeDelay!==!1&&e(window).on("resize.autosize",l),p.on("autosize.resize",r),p.on("autosize.resizeIncludeStyle",function(){t=null,r()}),p.on("autosize.destroy",function(){t=null,clearTimeout(h),e(window).off("resize",l),p.off("autosize").off(".autosize").css(z).removeData("autosize")}),r())})):this}})(window.jQuery||window.$);

var __slice=[].slice;(function(e,t){var n;n=function(){function t(t,n){var r,i,s,o=this;this.options=e.extend({},this.defaults,n);this.$el=t;s=this.defaults;for(r in s){i=s[r];if(this.$el.data(r)!=null){this.options[r]=this.$el.data(r)}}this.createStars();this.syncRating();this.$el.on("mouseover.starrr","span",function(e){return o.syncRating(o.$el.find("span").index(e.currentTarget)+1)});this.$el.on("mouseout.starrr",function(){return o.syncRating()});this.$el.on("click.starrr","span",function(e){return o.setRating(o.$el.find("span").index(e.currentTarget)+1)});this.$el.on("starrr:change",this.options.change)}t.prototype.defaults={rating:void 0,numStars:5,change:function(e,t){}};t.prototype.createStars=function(){var e,t,n;n=[];for(e=1,t=this.options.numStars;1<=t?e<=t:e>=t;1<=t?e++:e--){n.push(this.$el.append("<span class='glyphicon .glyphicon-star-empty'></span>"))}return n};t.prototype.setRating=function(e){if(this.options.rating===e){e=void 0}this.options.rating=e;this.syncRating();return this.$el.trigger("starrr:change",e)};t.prototype.syncRating=function(e){var t,n,r,i;e||(e=this.options.rating);if(e){for(t=n=0,i=e-1;0<=i?n<=i:n>=i;t=0<=i?++n:--n){this.$el.find("span").eq(t).removeClass("glyphicon-star-empty").addClass("glyphicon-star")}}if(e&&e<5){for(t=r=e;e<=4?r<=4:r>=4;t=e<=4?++r:--r){this.$el.find("span").eq(t).removeClass("glyphicon-star").addClass("glyphicon-star-empty")}}if(!e){return this.$el.find("span").removeClass("glyphicon-star").addClass("glyphicon-star-empty")}};return t}();return e.fn.extend({starrr:function(){var t,r;r=arguments[0],t=2<=arguments.length?__slice.call(arguments,1):[];return this.each(function(){var i;i=e(this).data("star-rating");if(!i){e(this).data("star-rating",i=new n(e(this),r))}if(typeof r==="string"){return i[r].apply(i,t)}})}})})(window.jQuery,window);$(function(){return $(".starrr").starrr()})

$(function(){

  $('#new-review').autosize({append: "\n"});

  var reviewBox = $('#post-review-box');
  var newReview = $('#new-review');
  var openReviewBtn = $('#open-review-box');
  var closeReviewBtn = $('#close-review-box');
  var ratingsField = $('#ratings-hidden');

  openReviewBtn.click(function(e)
  {
    reviewBox.slideDown(400, function()
      {
        $('#new-review').trigger('autosize.resize');
        newReview.focus();
      });
    openReviewBtn.fadeOut(100);
    closeReviewBtn.show();
  });

  closeReviewBtn.click(function(e)
  {
    e.preventDefault();
    reviewBox.slideUp(300, function()
      {
        newReview.focus();
        openReviewBtn.fadeIn(200);
      });
    closeReviewBtn.hide();
    
  });

  $('.starrr').on('starrr:change', function(e, value){
    ratingsField.val(value);
  });
});