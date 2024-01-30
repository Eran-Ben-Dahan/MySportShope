import AddComments from "../../components/comments/AddComments";
import EditComments from "../../components/comments/EditComments.jsx";
import "../../components/comments/Comments.css";
export default function Comments() {
  return (
    <div className="CommentsMaim">
      <EditComments />
      <AddComments />
    </div>
  );
}
