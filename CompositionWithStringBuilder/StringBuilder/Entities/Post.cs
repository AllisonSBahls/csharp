using System;
using System.Collections.Generic;
using System.Text;
namespace Composition.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        //Nome do atritubo deve ser Comments para respeitar o projeto
        public List<Comment> Comments { get; set; } = new List<Comment>(); //Garantir a inicialização da lista
    
        public Post()
        {
        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        //Utilizando o StringBuilder para facilitar a exibição deles de modo a não degradar a performance
        //StringBuilder é responsavel por fazer a construção de String de acordo como você ordenar
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.Append("Comments: ");

            //Para cada comentario quero que imprima o texto
            foreach (Comment c in Comments)
            {
                sb.Append(c.Text);
            }

            return sb.ToString();
        }
    }
}
