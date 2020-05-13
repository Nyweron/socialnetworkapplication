import React, { useState } from "react";
import { Segment, Form, Button } from "semantic-ui-react";
import { IActivity } from "../../../app/models/activity";

interface IProps {
  setEditMode: (editMode: boolean) => void;
  activity: IActivity;
}

const ActivityForm: React.FC<IProps> = ({
  setEditMode,
  activity: initialFormState,
}) => {
  const initializeForm = () => {
    if (initialFormState) {
      return initialFormState;
    } else {
      return {
        id: "",
        title: "",
        category: "",
        description: "",
        date: "",
        city: "",
        venue: "",
      };
    }
  };

  const [activity, setActivity] = useState<IActivity>(initializeForm);

  return (
    <Segment clearing>
      <Form>
        <Form.Input name="title" placeholder="Title" value={activity.title} />
        <Form.TextArea
          name="description"
          rows={2}
          placeholder="Description"
          value={activity.description}
        />
        <Form.Input
          name="category"
          placeholder="Category"
          value={activity.category}
        />
        <Form.Input
          name="date"
          type="datetime-local"
          placeholder="Date"
          value={activity.date}
        />
        <Form.Input name="city" placeholder="City" value={activity.city} />
        <Form.Input name="venue" placeholder="Venue" value={activity.venue} />
        <Button floated="right" positive type="submit" content="Submit" />
        <Button
          onClick={() => setEditMode(false)}
          floated="right"
          type="button"
          content="Cancel"
        />
      </Form>
    </Segment>
  );
};

export default ActivityForm;
