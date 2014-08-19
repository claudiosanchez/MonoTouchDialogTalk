using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iOS
{
public class Influencer
{
    public int position { get; set; }
    public string fromId { get; set; }
    public string fullName { get; set; }
    public int likesCount { get; set; }
    public int postsLikesCount { get; set; }
    public int commentsLikesCount { get; set; }
    public int interactionsCount { get; set; }
    public int messagesCount { get; set; }
    public int postsCount { get; set; }
    public int mentionsCount { get; set; }
    public int mentionsPostsCount { get; set; }
    public int mentionsCommentsCount { get; set; }
    public double ratio { get; set; }
    public string picture { get; set; }
    public string groupId { get; set; }
    public object groupName { get; set; }
}
}
