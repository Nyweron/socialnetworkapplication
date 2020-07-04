import React from "react";
import { Grid } from "semantic-ui-react";
import ProfileHeader from "./ProfileHeader";

const ProfilePage = () => {
  return (
    <Grid.Column width={16}>
      <ProfileHeader />
    </Grid.Column>
  );
};

export default ProfilePage;
