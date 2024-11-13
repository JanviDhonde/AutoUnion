<%@ Page Language="C#" MasterPageFile="~/HOME/MasterPage.master" AutoEventWireup="true" CodeFile="examforllr.aspx.cs" Inherits="HOME_examforllr" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <p>
        <br />
     <span style="color: #ff0066;">
        &nbsp;&nbsp;&nbsp;&nbsp; Exam For LLR&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     </span>
                        </p>
                        <p>
                            <span><span style="color: #ff0066">
                            <span>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; No of Questions 10&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Exam No</span>
                            </span>
                            </span>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><span style="color: #ff0066;">
                            </span>
                        </p>
                        <p>
                            <span style="color: #ff0066;">
                            &nbsp; &nbsp;<span>&nbsp;&nbsp;&nbsp;&nbsp; Passmark&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 4&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; Name</span>&nbsp;&nbsp;&nbsp;&nbsp;                             
                            </span>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><span style="color: #ff0066;">
                            </span>
                        </p>
                        <p style="color: #ffffff">
                            <span style="color: #ff0066;">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Challana No&nbsp;                        </span>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><span style="color: #ff0066;">
                            &nbsp;&nbsp; Date&nbsp;&nbsp; </span>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><span style="color: #ff0066;">
                            </span>
                        </p>
                        <p style="color: #ffffff">
                            <span style="color: #ff0066;">&nbsp; &nbsp; &nbsp;&nbsp; Questions&nbsp;</span></p>
                        <p style="color: #ffffff">
                            <span style="color: #ff0066;">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1.What signal color is used to stop vehicle?</span></p>
    <p>
        <span style="color: #ff0066;">&nbsp;&nbsp; </span>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            style="position:absolute; top: 493px; left: 362px;" 
            RepeatDirection="Horizontal"  ForeColor="White">
            <asp:ListItem>Red</asp:ListItem>
            <asp:ListItem>Green</asp:ListItem>
            <asp:ListItem>Yellow</asp:ListItem>
            <asp:ListItem>Orange</asp:ListItem>
        </asp:RadioButtonList>
        <span style="color: #ff0066">
        <span>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </span>
        </span>
    </p>
    <p style="color: #ffffff">
        <span style="color: #ff0066;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2.Mobiles can be used while driving?&nbsp;&nbsp;&nbsp;</span></p>
                        <p>
                            <asp:RadioButtonList ID="RadioButtonList11" runat="server" Height="20px" 
                                 
                                RepeatDirection="Horizontal" Width="427px" ForeColor="White">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Some times</asp:ListItem>
                                <asp:ListItem>By Stoping aside</asp:ListItem>
                                <asp:ListItem>Yes</asp:ListItem>
                            </asp:RadioButtonList><span style="color: #ff0066;"> </span>
                        </p>
    <p style="color: #ffffff">
        <span style="color: #ff0066;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3.&nbsp;What signal is used to drive?</span></p>
                        <p>
                            <asp:RadioButtonList ID="RadioButtonList3" runat="server" 
                                
                                RepeatDirection="Horizontal" AppendDataBoundItems="True" ForeColor="White">
                                <asp:ListItem>Green</asp:ListItem>
                                <asp:ListItem>Orange</asp:ListItem>
                                <asp:ListItem>Yellow</asp:ListItem>
                                <asp:ListItem>Red</asp:ListItem>
                            </asp:RadioButtonList><span style="color: #ff0066;"> </span>
                        </p>
                        <p style="color: #ffffff">
                            <span style="color: #ff0066;">
                            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 4.On a divided highway, vehicles travelling in the same direction as 
                            a stopped schoolbus must:&nbsp;</span></p>
                    <p>
                            <asp:RadioButtonList ID="RadioButtonList4" runat="server" 
                                ForeColor="White">
                                <asp:ListItem>Slow down and pass on the </asp:ListItem>
                                <asp:ListItem>Stop Unil the stop signal on the bus is withdraw</asp:ListItem>
                                <asp:ListItem>Travel at the posted speed limt</asp:ListItem>
                                <asp:ListItem>Stop then proceed with caution</asp:ListItem>
                            </asp:RadioButtonList><span style="color: #ff0066;"> </span>
                    </p>
                        <p style="color: #ffffff">
                            <span style="color: #ff0066;">
                            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 5.&nbsp;If you approach a red light at an intersection and a traffic 
                            officer directs you to proceed through the intersection, you should:</span></p>
                        <p>
                            <asp:RadioButtonList ID="RadioButtonList5" runat="server" 
                                 ForeColor="White">
                                <asp:ListItem>Stop and proceed carefully</asp:ListItem>
                                <asp:ListItem>stop until the lights turn greed</asp:ListItem>
                                <asp:ListItem>Proceed through the intersection</asp:ListItem>
                                <asp:ListItem>make u turn</asp:ListItem>
                            </asp:RadioButtonList><span style="color: #ff0066;"> </span>
                        </p>
                        <p style="color: #ffffff">
                            <span style="color: #ff0066;">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 6.&nbsp;When driving in the rain, fog or smoke in the daytime, and&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                            your visibility is reduced to 1,000 feet or less, you must</span></p>
                        <p>
                            <asp:RadioButtonList ID="RadioButtonList6" runat="server" 
                                AppendDataBoundItems="True" ForeColor="White">
                                <asp:ListItem>Turn on your lower beam(dim) headlights</asp:ListItem>
                                <asp:ListItem>Turn on your high beam headlights</asp:ListItem>
                                <asp:ListItem>do not use lights</asp:ListItem>
                                <asp:ListItem>turn on your parking lights</asp:ListItem>
                            </asp:RadioButtonList><span style="color: #ff0066;"> </span>
                        </p>
                        <p style="color: #ffffff">
                            <span style="color: #ff0066;">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 7.If you are being tailgated, the best thing to do is:&nbsp;</span></p>
                        <p>
                            <asp:RadioButtonList ID="RadioButtonList7" runat="server" 
                                 ForeColor="White">
                                <asp:ListItem>Break check the person following you</asp:ListItem>
                                <asp:ListItem>Speed Up</asp:ListItem>
                                <asp:ListItem>Move to the right lane and let the vehicle pass</asp:ListItem>
                                <asp:ListItem>Throw the coke out the window at them</asp:ListItem>
                            </asp:RadioButtonList><span style="color: #ff0066;"> </span>
                        </p>
                        <p style="color: #ffffff">
                            <span style="color: #ff0066;">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;8.&nbsp;What signal is used to ready for driving?</span></p>
                        <asp:RadioButtonList ID="RadioButtonList8" runat="server" 
                            
                            RepeatDirection="Horizontal" Height="16px" Width="467px" ForeColor="White">
                            <asp:ListItem>Red</asp:ListItem>
                            <asp:ListItem>Green</asp:ListItem>
                            <asp:ListItem>Black</asp:ListItem>
                            <asp:ListItem>Orange</asp:ListItem>
                        </asp:RadioButtonList><span style="color: #ff0066;"> </span>
                        <p style="color: #ffffff">
                            <span style="color: #ff0066;">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; 9.&nbsp;More than 3 people can go on byke</span></p>
                        <asp:RadioButtonList ID="RadioButtonList9" runat="server" 
                         
                        RepeatDirection="Horizontal" Width="465px" ForeColor="White">
                            <asp:ListItem>Yes</asp:ListItem>
                            <asp:ListItem>Sometimes</asp:ListItem>
                            <asp:ListItem>No</asp:ListItem>
                            <asp:ListItem>Our wish</asp:ListItem>
                    </asp:RadioButtonList><span style="color: #ff0066;"> </span>
                        <p style="color: #ffffff">
                            <span style="color: #ff0066;">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 10&nbsp;.While driving we can&nbsp; go on our own speed?</span></p>
                        <asp:RadioButtonList ID="RadioButtonList10" runat="server" 
                           
                            RepeatDirection="Horizontal" ForeColor="White">
                            <asp:ListItem>No</asp:ListItem>
                            <asp:ListItem>Yes</asp:ListItem>
                            <asp:ListItem>Ourwish</asp:ListItem>
                            <asp:ListItem>according to signals</asp:ListItem>
                        </asp:RadioButtonList><span style="color: #ff0066;"> </span>
                        <p>
    </p>
    <p>
        <span style="color: #ff0066;">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; </span>
        <asp:Button ID="Button1" runat="server" Text="SUBMIT" onclick="Button1_Click" 
            Width="109px" /><span style="color: #ff0066;"> </span>
        </p>
<p>
    </p>
</asp:Content>

