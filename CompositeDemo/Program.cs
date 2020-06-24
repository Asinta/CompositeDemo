using CompositeDemo.CompositeConcrete;

namespace CompositeDemo
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var winForm = new WinForm("WINDOW窗口");
            winForm.AddComponent(new Picture("LOGO图片"));
            winForm.AddComponent(new Button("登陆"));
            winForm.AddComponent(new Button("注册"));
            
            var frame = new Frame("FRAME1");
            frame.AddComponent(new Label("用户名"));
            frame.AddComponent(new TextBox("文本框"));
            frame.AddComponent(new Label("密码"));
            frame.AddComponent(new PasswordBox("密码框"));
            frame.AddComponent(new CheckBox("复选框"));
            frame.AddComponent(new TextBox("记住用户名"));
            frame.AddComponent(new LinkLabel("忘记密码"));
            
            winForm.AddComponent(frame);
            
            winForm.Draw();
        }
    }
}