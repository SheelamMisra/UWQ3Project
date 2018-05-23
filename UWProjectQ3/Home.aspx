<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" 
	Inherits="_Default" %>

 

<%@ MasterType VirtualPath="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="col-sm-12 col-md-12 col-lg-12">
			<div id="myCarousel" class="carousel slide" data-ride="carousel">
			  <!-- Indicators -->
			  <ol class="carousel-indicators">
				<li data-target="#myCarousel" data-slide-to="0" class="active"></li>
				<li data-target="#myCarousel" data-slide-to="1"></li>
				<li data-target="#myCarousel" data-slide-to="2"></li>
			  </ol>

			  <!-- Wrapper for slides -->
			  <div class="carousel-inner">
				
				  <div class="item active">
				  Almost every action we take is the result of past learning yet, for some people, learning still remains an activity undertaken in, or associated with, an educational context. 
				  As babies we learn to eat, to gain attention, to crawl, to walk, etc. and as we develop into children, and our bodies become more functional, we learn an inordinate range of skills.
				  Traditionally, research and studies around learning focused primarily on early-years learning through childhood and adolescence.  However, it is now recognised that learning is a continuous process that commences at birth and continues until death; it is the process through which we use our experience to deal with new situations and to develop relationships. 
				  See our page: Lifelong Learning for more information.
				  A lot of our learning occurs randomly throughout life, from new experiences, gaining information and from our perceptions, for example: reading a newspaper or watching a news broadcast, talking with a friend or colleague, chance meetings and unexpected experiences. 
				  Many experiences in life provide us with learning opportunities from which we can choose whether or not to learn.  This type of experiential learning is in contrast to more formal approaches to learning such as training, mentoring, coaching and teaching, all of which have some type of structure in that they are planned learning involving a facilitator.
				  Teaching, training and other structured learning opportunities are activities that one person does to another, while learning is something we can only do for ourselves.
				  Learning involves far more than thinking: it involves the whole personality - senses, feelings, intuition, beliefs, values and will.  If we do not have the will to learn, we will not learn and if we have learned, we are actually changed in some way.  If the learning makes no difference it can have very little significance beyond being random ideas that float through our consciousness. 
				  Learning needs to meet some personal need and recognising and identifying such needs enables us to evaluate whether the learning has been worthwhile and successful.
					 <div class="w3-animate-zoom">
						<h4>
						Learning can happen anywhere with us, mobile device, and TV, featuring enhanced navigation and faster streaming for anytime learning.
						Stay Sharp. Get ahead with Learning Paths.
						</h4>
					</div>
				</div>

				<div class="item">
				  <img src="Image/SQL.png" alt="SQL">
				</div>

				<div class="item">
				  <img src="Image/JQuery.jpg" alt="JQuery">
				</div>

				<div class="item">
				  <img src="Image/C.jpg" alt=" C#">
				</div>
			  </div>

			  <!-- Left and right controls -->
			  <a class="left carousel-control" href="#myCarousel" data-slide="prev">
				<span class="glyphicon glyphicon-chevron-left"></span>
				<span class="sr-only">Previous</span>
			  </a>
			  <a class="right carousel-control" href="#myCarousel" data-slide="next">
				<span class="glyphicon glyphicon-chevron-right"></span>
				<span class="sr-only">Next</span>
			  </a>
			</div>
		</div>


</asp:Content>

