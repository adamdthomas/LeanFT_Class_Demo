<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>Application Model</name>
  <className>BankOR</className>
  <objects>
    <object technology="Web" type="Page">
      <name>AbcBankDemo</name>
      <codeName>AbcBankDemoPage</codeName>
      <identification />
      <children>
        <object technology="Web" type="EditField">
          <name>user[username]</name>
          <codeName>UserUsernameEditField</codeName>
          <identification>
            <properties>
              <property name="Name" type="string">user[username]</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="EditField">
          <name>user[password]</name>
          <codeName>UserPasswordEditField</codeName>
          <identification>
            <properties>
              <property name="Id" type="string">user_password</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="Button">
          <name>Login</name>
          <codeName>LoginButton</codeName>
          <identification>
            <properties>
              <property name="Name" type="string">Login</property>
              <property name="TagName" type="string">Input</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="Button">
          <name>Logout</name>
          <codeName>LogoutButton</codeName>
          <identification>
            <properties>
              <property name="Name" type="string">Logout</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
  </objects>
</applicationModel>