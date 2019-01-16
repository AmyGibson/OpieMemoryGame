
/*
** The file ROS.cs is generated from ROS.cs.slt2 using the lua template library
** slt2. Please do not edit ROS.cs, instead edit ROS.cs.slt2
*/

using System;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;




using uint64_t = System.UInt64;
using int64_t = System.Int64;

using uint32_t = System.UInt32;
using int32_t = System.Int32;

using uint16_t = System.UInt16;
using int16_t = System.Int16;

using int8_t = System.SByte;
using uint8_t = System.Byte;





public class ROS
{
	public static string DEFAULT_MASTER_URI = "http://192.168.0.2:11311";

	public static uint32_t CS_ROS_VERSION_MAJOR = 0;
	public static uint32_t CS_ROS_VERSION_MINOR = 1;
	public static string CS_ROS_VERSION_COMPILE = "f6f9b56cc9e124229309122b0a0eb6fb";
	public static string CS_ROS_VERSION_VAR = "main/indigo";

	// cs_ros_bridge.dll API ---------------------------------------------------

	[DllImport ("cs_ros_bridge")]
	private extern static void cs_ros_argument (string key, string value);

	[DllImport ("cs_ros_bridge")]
	private extern static void cs_ros_init (string node_name);

  [DllImport ("cs_ros_bridge")]
  private extern static IntPtr cs_ros_bgi_create (string node_name);

  [DllImport ("cs_ros_bridge")]
  private extern static uint8_t cs_ros_bgi_check (IntPtr background_initialiser);

  [DllImport ("cs_ros_bridge")]
  private extern static IntPtr cs_ros_bgi_get_node_handle (IntPtr background_initialiser);

  [DllImport ("cs_ros_bridge")]
  private extern static void cs_ros_bgi_join (IntPtr background_initialiser);

  [DllImport ("cs_ros_bridge")]
  private extern static void cs_ros_bgi_destroy (IntPtr background_initialiser);

	[DllImport ("cs_ros_bridge")]
	private extern static uint8_t cs_ros_check_master ();

	[DllImport ("cs_ros_bridge")]
	private extern static IntPtr cs_ros_node_handle_create ();

	[DllImport ("cs_ros_bridge")]
	private extern static void cs_ros_node_handle_destroy (IntPtr node_handle);

	[DllImport ("cs_ros_bridge")]
	private extern static int cs_ros_spin_once (IntPtr node_handle);

	public delegate void MessageCallback(IntPtr message);

	public delegate IntPtr SubscriberConstructor(IntPtr node_handle, IntPtr topic,
	                                             MessageCallback callback, IntPtr user_data,
	                                             int queue_size);

  public delegate IntPtr PublisherConstructor(IntPtr node_handle, IntPtr topic, int queue_size);

  [DllImport ("cs_ros_bridge")]
	private extern static IntPtr cs_ros_subscribe (IntPtr node_handle, string topic, int queue_size,
	                                               MessageCallback callback, IntPtr user_data,
	                                               SubscriberConstructor subscriber_constructor);

	[DllImport ("cs_ros_bridge")]
	private extern static void cs_ros_unsubscribe (IntPtr subscriber);

  [DllImport("cs_ros_bridge")]
  private extern static IntPtr cs_ros_advertise(IntPtr node_handle, string topic, int queue_size,
                                             PublisherConstructor publisher_constructor);

  [DllImport("cs_ros_bridge")]
  private extern static void cs_ros_unadvertise(IntPtr publisher);

  [DllImport("cs_ros_bridge")]
  private extern static void cs_ros_publish (IntPtr publisher, IntPtr message);

  [DllImport("cs_ros_bridge")]
	public extern static IntPtr cs_ros_string_get (IntPtr s);

  // converter for string
  public static string cs_ros_string_get_as_string(IntPtr s)
  {
    return Marshal.PtrToStringAnsi(cs_ros_string_get(s));
  }

  [DllImport("cs_ros_bridge")]
  public extern static void  cs_ros_string_set (IntPtr s, string value);

  [DllImport("cs_ros_bridge")]
  public extern static void  cs_ros_string_destroy (IntPtr s);

  [DllImport("cs_ros_bridge")]
  public extern static uint32_t  cs_ros_time_get_sec (IntPtr t);

	[DllImport("cs_ros_bridge")]
  public extern static uint32_t  cs_ros_time_get_nsec (IntPtr t);

	[DllImport("cs_ros_bridge")]
  public extern static void  cs_ros_time_set_sec (IntPtr t, uint32_t value);

	[DllImport("cs_ros_bridge")]
  public extern static void  cs_ros_time_set_nsec (IntPtr t, uint32_t value);

	[DllImport("cs_ros_bridge")]
  public extern static void  cs_ros_time_set_now (IntPtr t);

	[DllImport("cs_ros_bridge")]
  public extern static double  cs_ros_time_to_sec (IntPtr t);

	[DllImport("cs_ros_bridge")]
  public extern static uint64_t  cs_ros_time_to_nsec (IntPtr t);

	[DllImport("cs_ros_bridge")]
  public extern static int32_t  cs_ros_duration_get_sec (IntPtr t);

	[DllImport("cs_ros_bridge")]
  public extern static int32_t  cs_ros_duration_get_nsec (IntPtr t);

	[DllImport("cs_ros_bridge")]
  public extern static void  cs_ros_duration_set_sec (IntPtr t, int32_t value);

	[DllImport("cs_ros_bridge")]
  public extern static void  cs_ros_duration_set_nsec (IntPtr t, int32_t value);

	[DllImport("cs_ros_bridge")]
	public extern static double  cs_ros_duration_to_sec (IntPtr t);

	[DllImport("cs_ros_bridge")]
	public extern static int64_t  cs_ros_duration_to_nsec (IntPtr t);


  // parameter server
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_param_set (string key, string value);

	[DllImport("cs_ros_bridge")]
	public extern static IntPtr cs_ros_param_get (string key);


	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_get_version_major ();

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_get_version_minor ();

	[DllImport("cs_ros_bridge")]
	public extern static IntPtr cs_ros_get_version_compile ();

	[DllImport("cs_ros_bridge")]
	public extern static IntPtr cs_ros_get_version_var ();


  // ----------------------------------------------------------------------


  // eye_movement

  


	

	

	// ----------- begin message Float64MultiArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float64MultiArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Float64MultiArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float64MultiArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float64MultiArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float64MultiArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member Float64MultiArray.layout -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float64MultiArray_get_pointer_layout (IntPtr message);

	

	

	// ----------- end member Float64MultiArray.layout ---------------
	

	

	// ----------- begin member Float64MultiArray.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Float64MultiArray_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Float64MultiArray_set_array_member_data(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float64MultiArray_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Float64MultiArray_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Float64MultiArray_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float64MultiArray_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member Float64MultiArray.data ---------------
	

	// ----------- end of message Float64MultiArray ------------------------------
	

	

	// ----------- begin message MultiDOFJointState -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiDOFJointState_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_get_pointer (IntPtr message);



	

	

	// ----------- begin member MultiDOFJointState.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_get_pointer_header (IntPtr message);

	

	

	// ----------- end member MultiDOFJointState.header ---------------
	

	

	// ----------- begin member MultiDOFJointState.twist -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_get_array_pointer_twist(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_MultiDOFJointState_get_size_twist(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiDOFJointState_resize_twist(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_get_array_member_pointer_twist(IntPtr message_pointer, int index);

	

	

	// ----------- end member MultiDOFJointState.twist ---------------
	

	

	// ----------- begin member MultiDOFJointState.transforms -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_get_array_pointer_transforms(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_MultiDOFJointState_get_size_transforms(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiDOFJointState_resize_transforms(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_get_array_member_pointer_transforms(IntPtr message_pointer, int index);

	

	

	// ----------- end member MultiDOFJointState.transforms ---------------
	

	

	// ----------- begin member MultiDOFJointState.joint_names -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_get_array_pointer_joint_names(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_MultiDOFJointState_get_size_joint_names(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiDOFJointState_resize_joint_names(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_get_array_member_pointer_joint_names(IntPtr message_pointer, int index);

	

	

	// ----------- end member MultiDOFJointState.joint_names ---------------
	

	

	// ----------- begin member MultiDOFJointState.wrench -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_get_array_pointer_wrench(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_MultiDOFJointState_get_size_wrench(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiDOFJointState_resize_wrench(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiDOFJointState_get_array_member_pointer_wrench(IntPtr message_pointer, int index);

	

	

	// ----------- end member MultiDOFJointState.wrench ---------------
	

	// ----------- end of message MultiDOFJointState ------------------------------
	

	

	// ----------- begin message UInt32MultiArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt32MultiArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt32MultiArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt32MultiArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt32MultiArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt32MultiArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member UInt32MultiArray.layout -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt32MultiArray_get_pointer_layout (IntPtr message);

	

	

	// ----------- end member UInt32MultiArray.layout ---------------
	

	

	// ----------- begin member UInt32MultiArray.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_UInt32MultiArray_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt32MultiArray_set_array_member_data(IntPtr message_pointer, int index, uint32_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt32MultiArray_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_UInt32MultiArray_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt32MultiArray_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt32MultiArray_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member UInt32MultiArray.data ---------------
	

	// ----------- end of message UInt32MultiArray ------------------------------
	

	

	// ----------- begin message Pose -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Pose_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose_get_pointer (IntPtr message);



	

	

	// ----------- begin member Pose.orientation -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose_get_pointer_orientation (IntPtr message);

	

	

	// ----------- end member Pose.orientation ---------------
	

	

	// ----------- begin member Pose.position -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose_get_pointer_position (IntPtr message);

	

	

	// ----------- end member Pose.position ---------------
	

	// ----------- end of message Pose ------------------------------
	

	

	// ----------- begin message PointCloud -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud_get_pointer (IntPtr message);



	

	

	// ----------- begin member PointCloud.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud_get_pointer_header (IntPtr message);

	

	

	// ----------- end member PointCloud.header ---------------
	

	

	// ----------- begin member PointCloud.points -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud_get_array_pointer_points(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_PointCloud_get_size_points(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud_resize_points(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud_get_array_member_pointer_points(IntPtr message_pointer, int index);

	

	

	// ----------- end member PointCloud.points ---------------
	

	

	// ----------- begin member PointCloud.channels -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud_get_array_pointer_channels(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_PointCloud_get_size_channels(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud_resize_channels(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud_get_array_member_pointer_channels(IntPtr message_pointer, int index);

	

	

	// ----------- end member PointCloud.channels ---------------
	

	// ----------- end of message PointCloud ------------------------------
	

	

	// ----------- begin message Int16 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int16_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int16_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int16_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int16_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int16_get_pointer (IntPtr message);



	

	

	// ----------- begin member Int16.data -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static int16_t cs_ros_message_Int16_get_data (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Int16_set_data (IntPtr message, int16_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int16_get_pointer_data (IntPtr message);

	

	

	// ----------- end member Int16.data ---------------
	

	// ----------- end of message Int16 ------------------------------
	

	

	// ----------- begin message TTSArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_TTSArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member TTSArray.tts -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSArray_get_array_pointer_tts(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_TTSArray_get_size_tts(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_TTSArray_resize_tts(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSArray_get_array_member_pointer_tts(IntPtr message_pointer, int index);

	

	

	// ----------- end member TTSArray.tts ---------------
	

	

	// ----------- begin member TTSArray.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSArray_get_pointer_header (IntPtr message);

	

	

	// ----------- end member TTSArray.header ---------------
	

	// ----------- end of message TTSArray ------------------------------
	

	

	// ----------- begin message Int32MultiArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int32MultiArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int32MultiArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int32MultiArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int32MultiArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int32MultiArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member Int32MultiArray.layout -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int32MultiArray_get_pointer_layout (IntPtr message);

	

	

	// ----------- end member Int32MultiArray.layout ---------------
	

	

	// ----------- begin member Int32MultiArray.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static int32_t cs_ros_message_Int32MultiArray_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int32MultiArray_set_array_member_data(IntPtr message_pointer, int index, int32_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int32MultiArray_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Int32MultiArray_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int32MultiArray_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int32MultiArray_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member Int32MultiArray.data ---------------
	

	// ----------- end of message Int32MultiArray ------------------------------
	

	

	// ----------- begin message JoyFeedbackArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedbackArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_JoyFeedbackArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedbackArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedbackArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedbackArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member JoyFeedbackArray.array -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedbackArray_get_array_pointer_array(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_JoyFeedbackArray_get_size_array(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_JoyFeedbackArray_resize_array(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedbackArray_get_array_member_pointer_array(IntPtr message_pointer, int index);

	

	

	// ----------- end member JoyFeedbackArray.array ---------------
	

	// ----------- end of message JoyFeedbackArray ------------------------------
	

	

	// ----------- begin message Vector3Stamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3Stamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Vector3Stamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3Stamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3Stamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3Stamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member Vector3Stamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3Stamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member Vector3Stamped.header ---------------
	

	

	// ----------- begin member Vector3Stamped.vector -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3Stamped_get_pointer_vector (IntPtr message);

	

	

	// ----------- end member Vector3Stamped.vector ---------------
	

	// ----------- end of message Vector3Stamped ------------------------------
	

	

	// ----------- begin message InertiaStamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_InertiaStamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_InertiaStamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_InertiaStamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_InertiaStamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_InertiaStamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member InertiaStamped.inertia -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_InertiaStamped_get_pointer_inertia (IntPtr message);

	

	

	// ----------- end member InertiaStamped.inertia ---------------
	

	

	// ----------- begin member InertiaStamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_InertiaStamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member InertiaStamped.header ---------------
	

	// ----------- end of message InertiaStamped ------------------------------
	

	

	// ----------- begin message Char -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Char_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Char_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Char_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Char_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Char_get_pointer (IntPtr message);



	

	

	// ----------- begin member Char.data -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Char_get_pointer_data (IntPtr message);

	

	

	// ----------- end member Char.data ---------------
	

	// ----------- end of message Char ------------------------------
	

	

	// ----------- begin message MotorPosition -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MotorPosition_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MotorPosition_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MotorPosition_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MotorPosition_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MotorPosition_get_pointer (IntPtr message);



	

	

	// ----------- begin member MotorPosition.engage -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_MotorPosition_get_engage (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MotorPosition_set_engage (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MotorPosition_get_pointer_engage (IntPtr message);

	

	

	// ----------- end member MotorPosition.engage ---------------
	

	

	// ----------- begin member MotorPosition.current_limit -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_MotorPosition_get_current_limit (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MotorPosition_set_current_limit (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MotorPosition_get_pointer_current_limit (IntPtr message);

	

	

	// ----------- end member MotorPosition.current_limit ---------------
	

	

	// ----------- begin member MotorPosition.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MotorPosition_get_pointer_header (IntPtr message);

	

	

	// ----------- end member MotorPosition.header ---------------
	

	

	// ----------- begin member MotorPosition.acceleration_limit -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_MotorPosition_get_acceleration_limit (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MotorPosition_set_acceleration_limit (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MotorPosition_get_pointer_acceleration_limit (IntPtr message);

	

	

	// ----------- end member MotorPosition.acceleration_limit ---------------
	

	

	// ----------- begin member MotorPosition.position_deg -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_MotorPosition_get_position_deg (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MotorPosition_set_position_deg (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MotorPosition_get_pointer_position_deg (IntPtr message);

	

	

	// ----------- end member MotorPosition.position_deg ---------------
	

	

	// ----------- begin member MotorPosition.action -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MotorPosition_get_pointer_action (IntPtr message);

	

	

	// ----------- end member MotorPosition.action ---------------
	

	

	// ----------- begin member MotorPosition.velocity_limit -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_MotorPosition_get_velocity_limit (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MotorPosition_set_velocity_limit (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MotorPosition_get_pointer_velocity_limit (IntPtr message);

	

	

	// ----------- end member MotorPosition.velocity_limit ---------------
	

	// ----------- end of message MotorPosition ------------------------------
	

	

	// ----------- begin message QuaternionStamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QuaternionStamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_QuaternionStamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QuaternionStamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QuaternionStamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QuaternionStamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member QuaternionStamped.quaternion -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QuaternionStamped_get_pointer_quaternion (IntPtr message);

	

	

	// ----------- end member QuaternionStamped.quaternion ---------------
	

	

	// ----------- begin member QuaternionStamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QuaternionStamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member QuaternionStamped.header ---------------
	

	// ----------- end of message QuaternionStamped ------------------------------
	

	

	// ----------- begin message Int64MultiArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int64MultiArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int64MultiArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int64MultiArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int64MultiArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int64MultiArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member Int64MultiArray.layout -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int64MultiArray_get_pointer_layout (IntPtr message);

	

	

	// ----------- end member Int64MultiArray.layout ---------------
	

	

	// ----------- begin member Int64MultiArray.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static int64_t cs_ros_message_Int64MultiArray_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int64MultiArray_set_array_member_data(IntPtr message_pointer, int index, int64_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int64MultiArray_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Int64MultiArray_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int64MultiArray_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int64MultiArray_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member Int64MultiArray.data ---------------
	

	// ----------- end of message Int64MultiArray ------------------------------
	

	

	// ----------- begin message ByteMultiArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ByteMultiArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_ByteMultiArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ByteMultiArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ByteMultiArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ByteMultiArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member ByteMultiArray.layout -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ByteMultiArray_get_pointer_layout (IntPtr message);

	

	

	// ----------- end member ByteMultiArray.layout ---------------
	

	

	// ----------- begin member ByteMultiArray.data -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ByteMultiArray_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_ByteMultiArray_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_ByteMultiArray_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ByteMultiArray_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member ByteMultiArray.data ---------------
	

	// ----------- end of message ByteMultiArray ------------------------------
	

	

	// ----------- begin message PoseArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PoseArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member PoseArray.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseArray_get_pointer_header (IntPtr message);

	

	

	// ----------- end member PoseArray.header ---------------
	

	

	// ----------- begin member PoseArray.poses -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseArray_get_array_pointer_poses(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_PoseArray_get_size_poses(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PoseArray_resize_poses(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseArray_get_array_member_pointer_poses(IntPtr message_pointer, int index);

	

	

	// ----------- end member PoseArray.poses ---------------
	

	// ----------- end of message PoseArray ------------------------------
	

	

	// ----------- begin message TTS -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTS_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_TTS_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTS_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTS_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTS_get_pointer (IntPtr message);



	

	

	// ----------- begin member TTS.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTS_get_pointer_header (IntPtr message);

	

	

	// ----------- end member TTS.header ---------------
	

	

	// ----------- begin member TTS.SPEAK -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_TTS_SPEAK;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_TTS_get_SPEAK ();

	
	

	

	// ----------- end member TTS.SPEAK ---------------
	

	

	// ----------- begin member TTS.STOP -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_TTS_STOP;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_TTS_get_STOP ();

	
	

	

	// ----------- end member TTS.STOP ---------------
	

	

	// ----------- begin member TTS.ref -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_TTS_get_ref (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_TTS_set_ref (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTS_get_pointer_ref (IntPtr message);

	

	

	// ----------- end member TTS.ref ---------------
	

	

	// ----------- begin member TTS.action_type -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_TTS_get_action_type (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_TTS_set_action_type (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTS_get_pointer_action_type (IntPtr message);

	

	

	// ----------- end member TTS.action_type ---------------
	

	

	// ----------- begin member TTS.text -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTS_get_pointer_text (IntPtr message);

	

	

	// ----------- end member TTS.text ---------------
	

	

	// ----------- begin member TTS.INTERRUPT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_TTS_INTERRUPT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_TTS_get_INTERRUPT ();

	
	

	

	// ----------- end member TTS.INTERRUPT ---------------
	

	

	// ----------- begin member TTS.action -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTS_get_pointer_action (IntPtr message);

	

	

	// ----------- end member TTS.action ---------------
	

	

	// ----------- begin member TTS.action_time -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTS_get_pointer_action_time (IntPtr message);

	

	

	// ----------- end member TTS.action_time ---------------
	

	// ----------- end of message TTS ------------------------------
	

	

	// ----------- begin message EyeMovement -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeMovement_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_EyeMovement_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeMovement_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeMovement_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeMovement_get_pointer (IntPtr message);



	

	

	// ----------- begin member EyeMovement.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeMovement_get_pointer_header (IntPtr message);

	

	

	// ----------- end member EyeMovement.header ---------------
	

	

	// ----------- begin member EyeMovement.y -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_EyeMovement_get_y (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_EyeMovement_set_y (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeMovement_get_pointer_y (IntPtr message);

	

	

	// ----------- end member EyeMovement.y ---------------
	

	

	// ----------- begin member EyeMovement.x -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_EyeMovement_get_x (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_EyeMovement_set_x (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeMovement_get_pointer_x (IntPtr message);

	

	

	// ----------- end member EyeMovement.x ---------------
	

	

	// ----------- begin member EyeMovement.action_time -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeMovement_get_pointer_action_time (IntPtr message);

	

	

	// ----------- end member EyeMovement.action_time ---------------
	

	// ----------- end of message EyeMovement ------------------------------
	

	

	// ----------- begin message CameraInfo -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_CameraInfo_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_pointer (IntPtr message);



	

	

	// ----------- begin member CameraInfo.height -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_CameraInfo_get_height (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_CameraInfo_set_height (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_pointer_height (IntPtr message);

	

	

	// ----------- end member CameraInfo.height ---------------
	

	

	// ----------- begin member CameraInfo.binning_x -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_CameraInfo_get_binning_x (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_CameraInfo_set_binning_x (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_pointer_binning_x (IntPtr message);

	

	

	// ----------- end member CameraInfo.binning_x ---------------
	

	

	// ----------- begin member CameraInfo.width -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_CameraInfo_get_width (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_CameraInfo_set_width (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_pointer_width (IntPtr message);

	

	

	// ----------- end member CameraInfo.width ---------------
	

	

	// ----------- begin member CameraInfo.distortion_model -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_pointer_distortion_model (IntPtr message);

	

	

	// ----------- end member CameraInfo.distortion_model ---------------
	

	

	// ----------- begin member CameraInfo.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_pointer_header (IntPtr message);

	

	

	// ----------- end member CameraInfo.header ---------------
	

	

	// ----------- begin member CameraInfo.D -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_CameraInfo_get_array_member_D(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_CameraInfo_set_array_member_D(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_array_pointer_D(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_CameraInfo_get_size_D(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_CameraInfo_resize_D(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_array_member_pointer_D(IntPtr message_pointer, int index);

	

	

	// ----------- end member CameraInfo.D ---------------
	

	

	// ----------- begin member CameraInfo.K -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_CameraInfo_get_array_member_K(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_CameraInfo_set_array_member_K(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_array_pointer_K(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_CameraInfo_get_size_K(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_array_member_pointer_K(IntPtr message_pointer, int index);

	

	

	// ----------- end member CameraInfo.K ---------------
	

	

	// ----------- begin member CameraInfo.R -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_CameraInfo_get_array_member_R(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_CameraInfo_set_array_member_R(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_array_pointer_R(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_CameraInfo_get_size_R(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_array_member_pointer_R(IntPtr message_pointer, int index);

	

	

	// ----------- end member CameraInfo.R ---------------
	

	

	// ----------- begin member CameraInfo.roi -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_pointer_roi (IntPtr message);

	

	

	// ----------- end member CameraInfo.roi ---------------
	

	

	// ----------- begin member CameraInfo.P -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_CameraInfo_get_array_member_P(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_CameraInfo_set_array_member_P(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_array_pointer_P(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_CameraInfo_get_size_P(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_array_member_pointer_P(IntPtr message_pointer, int index);

	

	

	// ----------- end member CameraInfo.P ---------------
	

	

	// ----------- begin member CameraInfo.binning_y -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_CameraInfo_get_binning_y (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_CameraInfo_set_binning_y (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CameraInfo_get_pointer_binning_y (IntPtr message);

	

	

	// ----------- end member CameraInfo.binning_y ---------------
	

	// ----------- end of message CameraInfo ------------------------------
	

	

	// ----------- begin message WrenchStamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_WrenchStamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_WrenchStamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_WrenchStamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_WrenchStamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_WrenchStamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member WrenchStamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_WrenchStamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member WrenchStamped.header ---------------
	

	

	// ----------- begin member WrenchStamped.wrench -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_WrenchStamped_get_pointer_wrench (IntPtr message);

	

	

	// ----------- end member WrenchStamped.wrench ---------------
	

	// ----------- end of message WrenchStamped ------------------------------
	

	

	// ----------- begin message MultiArrayLayout -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayLayout_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiArrayLayout_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayLayout_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayLayout_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayLayout_get_pointer (IntPtr message);



	

	

	// ----------- begin member MultiArrayLayout.dim -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayLayout_get_array_pointer_dim(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_MultiArrayLayout_get_size_dim(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiArrayLayout_resize_dim(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayLayout_get_array_member_pointer_dim(IntPtr message_pointer, int index);

	

	

	// ----------- end member MultiArrayLayout.dim ---------------
	

	

	// ----------- begin member MultiArrayLayout.data_offset -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_MultiArrayLayout_get_data_offset (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiArrayLayout_set_data_offset (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayLayout_get_pointer_data_offset (IntPtr message);

	

	

	// ----------- end member MultiArrayLayout.data_offset ---------------
	

	// ----------- end of message MultiArrayLayout ------------------------------
	

	

	// ----------- begin message JointState -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_JointState_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_get_pointer (IntPtr message);



	

	

	// ----------- begin member JointState.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_get_pointer_header (IntPtr message);

	

	

	// ----------- end member JointState.header ---------------
	

	

	// ----------- begin member JointState.effort -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_JointState_get_array_member_effort(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_JointState_set_array_member_effort(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_get_array_pointer_effort(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_JointState_get_size_effort(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_JointState_resize_effort(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_get_array_member_pointer_effort(IntPtr message_pointer, int index);

	

	

	// ----------- end member JointState.effort ---------------
	

	

	// ----------- begin member JointState.name -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_get_array_pointer_name(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_JointState_get_size_name(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_JointState_resize_name(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_get_array_member_pointer_name(IntPtr message_pointer, int index);

	

	

	// ----------- end member JointState.name ---------------
	

	

	// ----------- begin member JointState.velocity -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_JointState_get_array_member_velocity(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_JointState_set_array_member_velocity(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_get_array_pointer_velocity(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_JointState_get_size_velocity(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_JointState_resize_velocity(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_get_array_member_pointer_velocity(IntPtr message_pointer, int index);

	

	

	// ----------- end member JointState.velocity ---------------
	

	

	// ----------- begin member JointState.position -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_JointState_get_array_member_position(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_JointState_set_array_member_position(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_get_array_pointer_position(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_JointState_get_size_position(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_JointState_resize_position(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JointState_get_array_member_pointer_position(IntPtr message_pointer, int index);

	

	

	// ----------- end member JointState.position ---------------
	

	// ----------- end of message JointState ------------------------------
	

	

	// ----------- begin message GameControl -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_GameControl_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_GameControl_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_GameControl_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_GameControl_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_GameControl_get_pointer (IntPtr message);



	

	

	// ----------- begin member GameControl.EXIT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_GameControl_EXIT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_GameControl_get_EXIT ();

	
	

	

	// ----------- end member GameControl.EXIT ---------------
	

	

	// ----------- begin member GameControl.command -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_GameControl_get_command (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_GameControl_set_command (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_GameControl_get_pointer_command (IntPtr message);

	

	

	// ----------- end member GameControl.command ---------------
	

	

	// ----------- begin member GameControl.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_GameControl_get_pointer_header (IntPtr message);

	

	

	// ----------- end member GameControl.header ---------------
	

	

	// ----------- begin member GameControl.RESUME -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_GameControl_RESUME;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_GameControl_get_RESUME ();

	
	

	

	// ----------- end member GameControl.RESUME ---------------
	

	

	// ----------- begin member GameControl.PREVIOUS -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_GameControl_PREVIOUS;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_GameControl_get_PREVIOUS ();

	
	

	

	// ----------- end member GameControl.PREVIOUS ---------------
	

	

	// ----------- begin member GameControl.REPEAT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_GameControl_REPEAT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_GameControl_get_REPEAT ();

	
	

	

	// ----------- end member GameControl.REPEAT ---------------
	

	

	// ----------- begin member GameControl.name -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_GameControl_get_pointer_name (IntPtr message);

	

	

	// ----------- end member GameControl.name ---------------
	

	

	// ----------- begin member GameControl.RESTART -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_GameControl_RESTART;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_GameControl_get_RESTART ();

	
	

	

	// ----------- end member GameControl.RESTART ---------------
	

	

	// ----------- begin member GameControl.NEXT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_GameControl_NEXT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_GameControl_get_NEXT ();

	
	

	

	// ----------- end member GameControl.NEXT ---------------
	

	

	// ----------- begin member GameControl.PAUSE -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_GameControl_PAUSE;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_GameControl_get_PAUSE ();

	
	

	

	// ----------- end member GameControl.PAUSE ---------------
	

	

	// ----------- begin member GameControl.START -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_GameControl_START;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_GameControl_get_START ();

	
	

	

	// ----------- end member GameControl.START ---------------
	

	// ----------- end of message GameControl ------------------------------
	

	

	// ----------- begin message Int8 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int8_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int8_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int8_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int8_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int8_get_pointer (IntPtr message);



	

	

	// ----------- begin member Int8.data -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static int8_t cs_ros_message_Int8_get_data (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Int8_set_data (IntPtr message, int8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int8_get_pointer_data (IntPtr message);

	

	

	// ----------- end member Int8.data ---------------
	

	// ----------- end of message Int8 ------------------------------
	

	

	// ----------- begin message QueueControl -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueControl_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_QueueControl_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueControl_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueControl_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueControl_get_pointer (IntPtr message);



	

	

	// ----------- begin member QueueControl.INSERT_BACK -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_QueueControl_INSERT_BACK;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_QueueControl_get_INSERT_BACK ();

	
	

	

	// ----------- end member QueueControl.INSERT_BACK ---------------
	

	

	// ----------- begin member QueueControl.POP_FRONT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_QueueControl_POP_FRONT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_QueueControl_get_POP_FRONT ();

	
	

	

	// ----------- end member QueueControl.POP_FRONT ---------------
	

	

	// ----------- begin member QueueControl.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueControl_get_pointer_header (IntPtr message);

	

	

	// ----------- end member QueueControl.header ---------------
	

	

	// ----------- begin member QueueControl.queue_command -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_QueueControl_get_queue_command (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_QueueControl_set_queue_command (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueControl_get_pointer_queue_command (IntPtr message);

	

	

	// ----------- end member QueueControl.queue_command ---------------
	

	

	// ----------- begin member QueueControl.REMOVE_FROM_BACK -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_QueueControl_REMOVE_FROM_BACK;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_QueueControl_get_REMOVE_FROM_BACK ();

	
	

	

	// ----------- end member QueueControl.REMOVE_FROM_BACK ---------------
	

	

	// ----------- begin member QueueControl.REMOVE_FROM_FRONT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_QueueControl_REMOVE_FROM_FRONT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_QueueControl_get_REMOVE_FROM_FRONT ();

	
	

	

	// ----------- end member QueueControl.REMOVE_FROM_FRONT ---------------
	

	

	// ----------- begin member QueueControl.queue_object -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_QueueControl_get_queue_object (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_QueueControl_set_queue_object (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueControl_get_pointer_queue_object (IntPtr message);

	

	

	// ----------- end member QueueControl.queue_object ---------------
	

	

	// ----------- begin member QueueControl.POP_BACK -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_QueueControl_POP_BACK;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_QueueControl_get_POP_BACK ();

	
	

	

	// ----------- end member QueueControl.POP_BACK ---------------
	

	

	// ----------- begin member QueueControl.INSERT_FRONT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_QueueControl_INSERT_FRONT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_QueueControl_get_INSERT_FRONT ();

	
	

	

	// ----------- end member QueueControl.INSERT_FRONT ---------------
	

	// ----------- end of message QueueControl ------------------------------
	

	

	// ----------- begin message ServoCmd -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ServoCmd_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_ServoCmd_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ServoCmd_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ServoCmd_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ServoCmd_get_pointer (IntPtr message);



	

	

	// ----------- begin member ServoCmd.rate -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_ServoCmd_get_rate (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_ServoCmd_set_rate (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ServoCmd_get_pointer_rate (IntPtr message);

	

	

	// ----------- end member ServoCmd.rate ---------------
	

	

	// ----------- begin member ServoCmd.angle -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_ServoCmd_get_angle (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_ServoCmd_set_angle (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ServoCmd_get_pointer_angle (IntPtr message);

	

	

	// ----------- end member ServoCmd.angle ---------------
	

	

	// ----------- begin member ServoCmd.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ServoCmd_get_pointer_header (IntPtr message);

	

	

	// ----------- end member ServoCmd.header ---------------
	

	// ----------- end of message ServoCmd ------------------------------
	

	

	// ----------- begin message BehaviourControl -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BehaviourControl_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_BehaviourControl_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BehaviourControl_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BehaviourControl_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BehaviourControl_get_pointer (IntPtr message);



	

	

	// ----------- begin member BehaviourControl.PAUSE -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_BehaviourControl_PAUSE;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_BehaviourControl_get_PAUSE ();

	
	

	

	// ----------- end member BehaviourControl.PAUSE ---------------
	

	

	// ----------- begin member BehaviourControl.STOP -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_BehaviourControl_STOP;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_BehaviourControl_get_STOP ();

	
	

	

	// ----------- end member BehaviourControl.STOP ---------------
	

	

	// ----------- begin member BehaviourControl.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BehaviourControl_get_pointer_header (IntPtr message);

	

	

	// ----------- end member BehaviourControl.header ---------------
	

	

	// ----------- begin member BehaviourControl.START -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_BehaviourControl_START;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_BehaviourControl_get_START ();

	
	

	

	// ----------- end member BehaviourControl.START ---------------
	

	

	// ----------- begin member BehaviourControl.TOGGLE -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_BehaviourControl_TOGGLE;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_BehaviourControl_get_TOGGLE ();

	
	

	

	// ----------- end member BehaviourControl.TOGGLE ---------------
	

	

	// ----------- begin member BehaviourControl.action -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_BehaviourControl_get_action (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_BehaviourControl_set_action (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BehaviourControl_get_pointer_action (IntPtr message);

	

	

	// ----------- end member BehaviourControl.action ---------------
	

	

	// ----------- begin member BehaviourControl.action_time -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BehaviourControl_get_pointer_action_time (IntPtr message);

	

	

	// ----------- end member BehaviourControl.action_time ---------------
	

	// ----------- end of message BehaviourControl ------------------------------
	

	

	// ----------- begin message TimeReference -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TimeReference_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_TimeReference_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TimeReference_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TimeReference_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TimeReference_get_pointer (IntPtr message);



	

	

	// ----------- begin member TimeReference.source -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TimeReference_get_pointer_source (IntPtr message);

	

	

	// ----------- end member TimeReference.source ---------------
	

	

	// ----------- begin member TimeReference.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TimeReference_get_pointer_header (IntPtr message);

	

	

	// ----------- end member TimeReference.header ---------------
	

	

	// ----------- begin member TimeReference.time_ref -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TimeReference_get_pointer_time_ref (IntPtr message);

	

	

	// ----------- end member TimeReference.time_ref ---------------
	

	// ----------- end of message TimeReference ------------------------------
	

	

	// ----------- begin message TwistStamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistStamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_TwistStamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistStamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistStamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistStamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member TwistStamped.twist -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistStamped_get_pointer_twist (IntPtr message);

	

	

	// ----------- end member TwistStamped.twist ---------------
	

	

	// ----------- begin member TwistStamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistStamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member TwistStamped.header ---------------
	

	// ----------- end of message TwistStamped ------------------------------
	

	

	// ----------- begin message OpieMovement -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_OpieMovement_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_OpieMovement_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_OpieMovement_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_OpieMovement_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_OpieMovement_get_pointer (IntPtr message);



	

	

	// ----------- begin member OpieMovement.frame_rate -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_OpieMovement_get_pointer_frame_rate (IntPtr message);

	

	

	// ----------- end member OpieMovement.frame_rate ---------------
	

	

	// ----------- begin member OpieMovement.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_OpieMovement_get_pointer_header (IntPtr message);

	

	

	// ----------- end member OpieMovement.header ---------------
	

	

	// ----------- begin member OpieMovement.action2 -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_OpieMovement_get_pointer_action2 (IntPtr message);

	

	

	// ----------- end member OpieMovement.action2 ---------------
	

	

	// ----------- begin member OpieMovement.action1 -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_OpieMovement_get_pointer_action1 (IntPtr message);

	

	

	// ----------- end member OpieMovement.action1 ---------------
	

	// ----------- end of message OpieMovement ------------------------------
	

	

	// ----------- begin message PoseWithCovariance -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovariance_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PoseWithCovariance_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovariance_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovariance_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovariance_get_pointer (IntPtr message);



	

	

	// ----------- begin member PoseWithCovariance.covariance -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_PoseWithCovariance_get_array_member_covariance(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PoseWithCovariance_set_array_member_covariance(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovariance_get_array_pointer_covariance(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_PoseWithCovariance_get_size_covariance(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovariance_get_array_member_pointer_covariance(IntPtr message_pointer, int index);

	

	

	// ----------- end member PoseWithCovariance.covariance ---------------
	

	

	// ----------- begin member PoseWithCovariance.pose -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovariance_get_pointer_pose (IntPtr message);

	

	

	// ----------- end member PoseWithCovariance.pose ---------------
	

	// ----------- end of message PoseWithCovariance ------------------------------
	

	

	// ----------- begin message Point32 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point32_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Point32_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point32_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point32_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point32_get_pointer (IntPtr message);



	

	

	// ----------- begin member Point32.z -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Point32_get_z (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Point32_set_z (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point32_get_pointer_z (IntPtr message);

	

	

	// ----------- end member Point32.z ---------------
	

	

	// ----------- begin member Point32.y -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Point32_get_y (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Point32_set_y (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point32_get_pointer_y (IntPtr message);

	

	

	// ----------- end member Point32.y ---------------
	

	

	// ----------- begin member Point32.x -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Point32_get_x (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Point32_set_x (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point32_get_pointer_x (IntPtr message);

	

	

	// ----------- end member Point32.x ---------------
	

	// ----------- end of message Point32 ------------------------------
	

	

	// ----------- begin message Imu -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Imu_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_get_pointer (IntPtr message);



	

	

	// ----------- begin member Imu.orientation_covariance -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Imu_get_array_member_orientation_covariance(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Imu_set_array_member_orientation_covariance(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_get_array_pointer_orientation_covariance(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Imu_get_size_orientation_covariance(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_get_array_member_pointer_orientation_covariance(IntPtr message_pointer, int index);

	

	

	// ----------- end member Imu.orientation_covariance ---------------
	

	

	// ----------- begin member Imu.angular_velocity -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_get_pointer_angular_velocity (IntPtr message);

	

	

	// ----------- end member Imu.angular_velocity ---------------
	

	

	// ----------- begin member Imu.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_get_pointer_header (IntPtr message);

	

	

	// ----------- end member Imu.header ---------------
	

	

	// ----------- begin member Imu.linear_acceleration_covariance -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Imu_get_array_member_linear_acceleration_covariance(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Imu_set_array_member_linear_acceleration_covariance(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_get_array_pointer_linear_acceleration_covariance(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Imu_get_size_linear_acceleration_covariance(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_get_array_member_pointer_linear_acceleration_covariance(IntPtr message_pointer, int index);

	

	

	// ----------- end member Imu.linear_acceleration_covariance ---------------
	

	

	// ----------- begin member Imu.linear_acceleration -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_get_pointer_linear_acceleration (IntPtr message);

	

	

	// ----------- end member Imu.linear_acceleration ---------------
	

	

	// ----------- begin member Imu.orientation -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_get_pointer_orientation (IntPtr message);

	

	

	// ----------- end member Imu.orientation ---------------
	

	

	// ----------- begin member Imu.angular_velocity_covariance -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Imu_get_array_member_angular_velocity_covariance(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Imu_set_array_member_angular_velocity_covariance(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_get_array_pointer_angular_velocity_covariance(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Imu_get_size_angular_velocity_covariance(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Imu_get_array_member_pointer_angular_velocity_covariance(IntPtr message_pointer, int index);

	

	

	// ----------- end member Imu.angular_velocity_covariance ---------------
	

	// ----------- end of message Imu ------------------------------
	

	

	// ----------- begin message TTSStop -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSStop_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_TTSStop_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSStop_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSStop_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSStop_get_pointer (IntPtr message);



	

	

	// ----------- begin member TTSStop.ref -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSStop_get_pointer_ref (IntPtr message);

	

	

	// ----------- end member TTSStop.ref ---------------
	

	

	// ----------- begin member TTSStop.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSStop_get_pointer_header (IntPtr message);

	

	

	// ----------- end member TTSStop.header ---------------
	

	

	// ----------- begin member TTSStop.text -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSStop_get_pointer_text (IntPtr message);

	

	

	// ----------- end member TTSStop.text ---------------
	

	

	// ----------- begin member TTSStop.tts_ref -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_TTSStop_get_tts_ref (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_TTSStop_set_tts_ref (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSStop_get_pointer_tts_ref (IntPtr message);

	

	

	// ----------- end member TTSStop.tts_ref ---------------
	

	

	// ----------- begin member TTSStop.action_time -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TTSStop_get_pointer_action_time (IntPtr message);

	

	

	// ----------- end member TTSStop.action_time ---------------
	

	// ----------- end of message TTSStop ------------------------------
	

	

	// ----------- begin message ButtonPress -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ButtonPress_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_ButtonPress_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ButtonPress_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ButtonPress_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ButtonPress_get_pointer (IntPtr message);



	

	

	// ----------- begin member ButtonPress.source -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_ButtonPress_get_source (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_ButtonPress_set_source (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ButtonPress_get_pointer_source (IntPtr message);

	

	

	// ----------- end member ButtonPress.source ---------------
	

	

	// ----------- begin member ButtonPress.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ButtonPress_get_pointer_header (IntPtr message);

	

	

	// ----------- end member ButtonPress.header ---------------
	

	

	// ----------- begin member ButtonPress.button -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_ButtonPress_get_button (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_ButtonPress_set_button (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ButtonPress_get_pointer_button (IntPtr message);

	

	

	// ----------- end member ButtonPress.button ---------------
	

	

	// ----------- begin member ButtonPress.target -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_ButtonPress_get_target (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_ButtonPress_set_target (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ButtonPress_get_pointer_target (IntPtr message);

	

	

	// ----------- end member ButtonPress.target ---------------
	

	// ----------- end of message ButtonPress ------------------------------
	

	

	// ----------- begin message Snapshot -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Snapshot_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Snapshot_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Snapshot_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Snapshot_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Snapshot_get_pointer (IntPtr message);



	

	

	// ----------- begin member Snapshot.index -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Snapshot_get_index (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Snapshot_set_index (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Snapshot_get_pointer_index (IntPtr message);

	

	

	// ----------- end member Snapshot.index ---------------
	

	

	// ----------- begin member Snapshot.servoy -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Snapshot_get_servoy (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Snapshot_set_servoy (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Snapshot_get_pointer_servoy (IntPtr message);

	

	

	// ----------- end member Snapshot.servoy ---------------
	

	

	// ----------- begin member Snapshot.speed -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Snapshot_get_pointer_speed (IntPtr message);

	

	

	// ----------- end member Snapshot.speed ---------------
	

	

	// ----------- begin member Snapshot.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Snapshot_get_pointer_header (IntPtr message);

	

	

	// ----------- end member Snapshot.header ---------------
	

	

	// ----------- begin member Snapshot.servoz -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Snapshot_get_servoz (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Snapshot_set_servoz (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Snapshot_get_pointer_servoz (IntPtr message);

	

	

	// ----------- end member Snapshot.servoz ---------------
	

	

	// ----------- begin member Snapshot.servox -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Snapshot_get_servox (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Snapshot_set_servox (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Snapshot_get_pointer_servox (IntPtr message);

	

	

	// ----------- end member Snapshot.servox ---------------
	

	

	// ----------- begin member Snapshot.lastFlag -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_Snapshot_get_lastFlag (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Snapshot_set_lastFlag (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Snapshot_get_pointer_lastFlag (IntPtr message);

	

	

	// ----------- end member Snapshot.lastFlag ---------------
	

	// ----------- end of message Snapshot ------------------------------
	

	

	// ----------- begin message Int8MultiArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int8MultiArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int8MultiArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int8MultiArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int8MultiArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int8MultiArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member Int8MultiArray.layout -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int8MultiArray_get_pointer_layout (IntPtr message);

	

	

	// ----------- end member Int8MultiArray.layout ---------------
	

	

	// ----------- begin member Int8MultiArray.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static int8_t cs_ros_message_Int8MultiArray_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int8MultiArray_set_array_member_data(IntPtr message_pointer, int index, int8_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int8MultiArray_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Int8MultiArray_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int8MultiArray_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int8MultiArray_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member Int8MultiArray.data ---------------
	

	// ----------- end of message Int8MultiArray ------------------------------
	

	

	// ----------- begin message Pose2D -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose2D_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Pose2D_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose2D_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose2D_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose2D_get_pointer (IntPtr message);



	

	

	// ----------- begin member Pose2D.y -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Pose2D_get_y (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Pose2D_set_y (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose2D_get_pointer_y (IntPtr message);

	

	

	// ----------- end member Pose2D.y ---------------
	

	

	// ----------- begin member Pose2D.x -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Pose2D_get_x (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Pose2D_set_x (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose2D_get_pointer_x (IntPtr message);

	

	

	// ----------- end member Pose2D.x ---------------
	

	

	// ----------- begin member Pose2D.theta -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Pose2D_get_theta (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Pose2D_set_theta (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Pose2D_get_pointer_theta (IntPtr message);

	

	

	// ----------- end member Pose2D.theta ---------------
	

	// ----------- end of message Pose2D ------------------------------
	

	

	// ----------- begin message ColorRGBA -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ColorRGBA_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_ColorRGBA_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ColorRGBA_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ColorRGBA_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ColorRGBA_get_pointer (IntPtr message);



	

	

	// ----------- begin member ColorRGBA.r -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_ColorRGBA_get_r (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_ColorRGBA_set_r (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ColorRGBA_get_pointer_r (IntPtr message);

	

	

	// ----------- end member ColorRGBA.r ---------------
	

	

	// ----------- begin member ColorRGBA.a -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_ColorRGBA_get_a (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_ColorRGBA_set_a (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ColorRGBA_get_pointer_a (IntPtr message);

	

	

	// ----------- end member ColorRGBA.a ---------------
	

	

	// ----------- begin member ColorRGBA.b -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_ColorRGBA_get_b (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_ColorRGBA_set_b (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ColorRGBA_get_pointer_b (IntPtr message);

	

	

	// ----------- end member ColorRGBA.b ---------------
	

	

	// ----------- begin member ColorRGBA.g -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_ColorRGBA_get_g (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_ColorRGBA_set_g (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ColorRGBA_get_pointer_g (IntPtr message);

	

	

	// ----------- end member ColorRGBA.g ---------------
	

	// ----------- end of message ColorRGBA ------------------------------
	

	

	// ----------- begin message PointCloud2 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud2_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_get_pointer (IntPtr message);



	

	

	// ----------- begin member PointCloud2.height -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_PointCloud2_get_height (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud2_set_height (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_get_pointer_height (IntPtr message);

	

	

	// ----------- end member PointCloud2.height ---------------
	

	

	// ----------- begin member PointCloud2.width -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_PointCloud2_get_width (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud2_set_width (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_get_pointer_width (IntPtr message);

	

	

	// ----------- end member PointCloud2.width ---------------
	

	

	// ----------- begin member PointCloud2.row_step -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_PointCloud2_get_row_step (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud2_set_row_step (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_get_pointer_row_step (IntPtr message);

	

	

	// ----------- end member PointCloud2.row_step ---------------
	

	

	// ----------- begin member PointCloud2.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_get_pointer_header (IntPtr message);

	

	

	// ----------- end member PointCloud2.header ---------------
	

	

	// ----------- begin member PointCloud2.point_step -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_PointCloud2_get_point_step (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud2_set_point_step (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_get_pointer_point_step (IntPtr message);

	

	

	// ----------- end member PointCloud2.point_step ---------------
	

	

	// ----------- begin member PointCloud2.fields -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_get_array_pointer_fields(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_PointCloud2_get_size_fields(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud2_resize_fields(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_get_array_member_pointer_fields(IntPtr message_pointer, int index);

	

	

	// ----------- end member PointCloud2.fields ---------------
	

	

	// ----------- begin member PointCloud2.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_PointCloud2_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud2_set_array_member_data(IntPtr message_pointer, int index, uint8_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_PointCloud2_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud2_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member PointCloud2.data ---------------
	

	

	// ----------- begin member PointCloud2.is_dense -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_PointCloud2_get_is_dense (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud2_set_is_dense (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_get_pointer_is_dense (IntPtr message);

	

	

	// ----------- end member PointCloud2.is_dense ---------------
	

	

	// ----------- begin member PointCloud2.is_bigendian -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_PointCloud2_get_is_bigendian (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_PointCloud2_set_is_bigendian (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointCloud2_get_pointer_is_bigendian (IntPtr message);

	

	

	// ----------- end member PointCloud2.is_bigendian ---------------
	

	// ----------- end of message PointCloud2 ------------------------------
	

	

	// ----------- begin message Transform -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Transform_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Transform_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Transform_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Transform_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Transform_get_pointer (IntPtr message);



	

	

	// ----------- begin member Transform.translation -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Transform_get_pointer_translation (IntPtr message);

	

	

	// ----------- end member Transform.translation ---------------
	

	

	// ----------- begin member Transform.rotation -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Transform_get_pointer_rotation (IntPtr message);

	

	

	// ----------- end member Transform.rotation ---------------
	

	// ----------- end of message Transform ------------------------------
	

	

	// ----------- begin message UntimedAction -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UntimedAction_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UntimedAction_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UntimedAction_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UntimedAction_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UntimedAction_get_pointer (IntPtr message);



	

	

	// ----------- begin member UntimedAction.start -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UntimedAction_get_pointer_start (IntPtr message);

	

	

	// ----------- end member UntimedAction.start ---------------
	

	

	// ----------- begin member UntimedAction.ref -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UntimedAction_get_pointer_ref (IntPtr message);

	

	

	// ----------- end member UntimedAction.ref ---------------
	

	// ----------- end of message UntimedAction ------------------------------
	

	

	// ----------- begin message BatteryState -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer (IntPtr message);



	

	

	// ----------- begin member BatteryState.location -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_location (IntPtr message);

	

	

	// ----------- end member BatteryState.location ---------------
	

	

	// ----------- begin member BatteryState.POWER_SUPPLY_HEALTH_SAFETY_TIMER_EXPIRE -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_BatteryState_POWER_SUPPLY_HEALTH_SAFETY_TIMER_EXPIRE;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_POWER_SUPPLY_HEALTH_SAFETY_TIMER_EXPIRE ();

	
	

	

	// ----------- end member BatteryState.POWER_SUPPLY_HEALTH_SAFETY_TIMER_EXPIRE ---------------
	

	

	// ----------- begin member BatteryState.power_supply_status -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_power_supply_status (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_set_power_supply_status (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_power_supply_status (IntPtr message);

	

	

	// ----------- end member BatteryState.power_supply_status ---------------
	

	

	// ----------- begin member BatteryState.design_capacity -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_BatteryState_get_design_capacity (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_set_design_capacity (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_design_capacity (IntPtr message);

	

	

	// ----------- end member BatteryState.design_capacity ---------------
	

	

	// ----------- begin member BatteryState.charge -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_BatteryState_get_charge (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_set_charge (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_charge (IntPtr message);

	

	

	// ----------- end member BatteryState.charge ---------------
	

	

	// ----------- begin member BatteryState.POWER_SUPPLY_TECHNOLOGY_LIFE -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_BatteryState_POWER_SUPPLY_TECHNOLOGY_LIFE;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_POWER_SUPPLY_TECHNOLOGY_LIFE ();

	
	

	

	// ----------- end member BatteryState.POWER_SUPPLY_TECHNOLOGY_LIFE ---------------
	

	

	// ----------- begin member BatteryState.power_supply_technology -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_power_supply_technology (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_set_power_supply_technology (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_power_supply_technology (IntPtr message);

	

	

	// ----------- end member BatteryState.power_supply_technology ---------------
	

	

	// ----------- begin member BatteryState.POWER_SUPPLY_TECHNOLOGY_UNKNOWN -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_BatteryState_POWER_SUPPLY_TECHNOLOGY_UNKNOWN;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_POWER_SUPPLY_TECHNOLOGY_UNKNOWN ();

	
	

	

	// ----------- end member BatteryState.POWER_SUPPLY_TECHNOLOGY_UNKNOWN ---------------
	

	

	// ----------- begin member BatteryState.serial_number -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_serial_number (IntPtr message);

	

	

	// ----------- end member BatteryState.serial_number ---------------
	

	

	// ----------- begin member BatteryState.present -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_present (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_set_present (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_present (IntPtr message);

	

	

	// ----------- end member BatteryState.present ---------------
	

	

	// ----------- begin member BatteryState.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_header (IntPtr message);

	

	

	// ----------- end member BatteryState.header ---------------
	

	

	// ----------- begin member BatteryState.power_supply_health -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_power_supply_health (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_set_power_supply_health (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_power_supply_health (IntPtr message);

	

	

	// ----------- end member BatteryState.power_supply_health ---------------
	

	

	// ----------- begin member BatteryState.POWER_SUPPLY_TECHNOLOGY_LION -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_BatteryState_POWER_SUPPLY_TECHNOLOGY_LION;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_POWER_SUPPLY_TECHNOLOGY_LION ();

	
	

	

	// ----------- end member BatteryState.POWER_SUPPLY_TECHNOLOGY_LION ---------------
	

	

	// ----------- begin member BatteryState.POWER_SUPPLY_TECHNOLOGY_LIMN -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_BatteryState_POWER_SUPPLY_TECHNOLOGY_LIMN;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_POWER_SUPPLY_TECHNOLOGY_LIMN ();

	
	

	

	// ----------- end member BatteryState.POWER_SUPPLY_TECHNOLOGY_LIMN ---------------
	

	

	// ----------- begin member BatteryState.POWER_SUPPLY_TECHNOLOGY_LIPO -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_BatteryState_POWER_SUPPLY_TECHNOLOGY_LIPO;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_POWER_SUPPLY_TECHNOLOGY_LIPO ();

	
	

	

	// ----------- end member BatteryState.POWER_SUPPLY_TECHNOLOGY_LIPO ---------------
	

	

	// ----------- begin member BatteryState.POWER_SUPPLY_TECHNOLOGY_NICD -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_BatteryState_POWER_SUPPLY_TECHNOLOGY_NICD;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_POWER_SUPPLY_TECHNOLOGY_NICD ();

	
	

	

	// ----------- end member BatteryState.POWER_SUPPLY_TECHNOLOGY_NICD ---------------
	

	

	// ----------- begin member BatteryState.cell_voltage -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_BatteryState_get_array_member_cell_voltage(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_set_array_member_cell_voltage(IntPtr message_pointer, int index, float value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_array_pointer_cell_voltage(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_BatteryState_get_size_cell_voltage(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_resize_cell_voltage(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_array_member_pointer_cell_voltage(IntPtr message_pointer, int index);

	

	

	// ----------- end member BatteryState.cell_voltage ---------------
	

	

	// ----------- begin member BatteryState.POWER_SUPPLY_TECHNOLOGY_NIMH -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_BatteryState_POWER_SUPPLY_TECHNOLOGY_NIMH;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_POWER_SUPPLY_TECHNOLOGY_NIMH ();

	
	

	

	// ----------- end member BatteryState.POWER_SUPPLY_TECHNOLOGY_NIMH ---------------
	

	

	// ----------- begin member BatteryState.current -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_BatteryState_get_current (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_set_current (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_current (IntPtr message);

	

	

	// ----------- end member BatteryState.current ---------------
	

	

	// ----------- begin member BatteryState.capacity -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_BatteryState_get_capacity (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_set_capacity (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_capacity (IntPtr message);

	

	

	// ----------- end member BatteryState.capacity ---------------
	

	

	// ----------- begin member BatteryState.POWER_SUPPLY_HEALTH_WATCHDOG_TIMER_EXPIRE -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_BatteryState_POWER_SUPPLY_HEALTH_WATCHDOG_TIMER_EXPIRE;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_BatteryState_get_POWER_SUPPLY_HEALTH_WATCHDOG_TIMER_EXPIRE ();

	
	

	

	// ----------- end member BatteryState.POWER_SUPPLY_HEALTH_WATCHDOG_TIMER_EXPIRE ---------------
	

	

	// ----------- begin member BatteryState.percentage -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_BatteryState_get_percentage (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_set_percentage (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_percentage (IntPtr message);

	

	

	// ----------- end member BatteryState.percentage ---------------
	

	

	// ----------- begin member BatteryState.voltage -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_BatteryState_get_voltage (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_BatteryState_set_voltage (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_BatteryState_get_pointer_voltage (IntPtr message);

	

	

	// ----------- end member BatteryState.voltage ---------------
	

	// ----------- end of message BatteryState ------------------------------
	

	

	// ----------- begin message Joy -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Joy_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Joy_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Joy_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Joy_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Joy_get_pointer (IntPtr message);



	

	

	// ----------- begin member Joy.axes -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Joy_get_array_member_axes(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Joy_set_array_member_axes(IntPtr message_pointer, int index, float value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Joy_get_array_pointer_axes(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Joy_get_size_axes(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Joy_resize_axes(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Joy_get_array_member_pointer_axes(IntPtr message_pointer, int index);

	

	

	// ----------- end member Joy.axes ---------------
	

	

	// ----------- begin member Joy.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Joy_get_pointer_header (IntPtr message);

	

	

	// ----------- end member Joy.header ---------------
	

	

	// ----------- begin member Joy.buttons -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static int32_t cs_ros_message_Joy_get_array_member_buttons(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Joy_set_array_member_buttons(IntPtr message_pointer, int index, int32_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Joy_get_array_pointer_buttons(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Joy_get_size_buttons(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Joy_resize_buttons(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Joy_get_array_member_pointer_buttons(IntPtr message_pointer, int index);

	

	

	// ----------- end member Joy.buttons ---------------
	

	// ----------- end of message Joy ------------------------------
	

	

	// ----------- begin message AccelStamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelStamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_AccelStamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelStamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelStamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelStamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member AccelStamped.accel -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelStamped_get_pointer_accel (IntPtr message);

	

	

	// ----------- end member AccelStamped.accel ---------------
	

	

	// ----------- begin member AccelStamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelStamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member AccelStamped.header ---------------
	

	// ----------- end of message AccelStamped ------------------------------
	

	

	// ----------- begin message Inertia -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Inertia_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Inertia_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Inertia_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Inertia_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Inertia_get_pointer (IntPtr message);



	

	

	// ----------- begin member Inertia.izz -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Inertia_get_izz (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Inertia_set_izz (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Inertia_get_pointer_izz (IntPtr message);

	

	

	// ----------- end member Inertia.izz ---------------
	

	

	// ----------- begin member Inertia.m -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Inertia_get_m (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Inertia_set_m (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Inertia_get_pointer_m (IntPtr message);

	

	

	// ----------- end member Inertia.m ---------------
	

	

	// ----------- begin member Inertia.ixx -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Inertia_get_ixx (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Inertia_set_ixx (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Inertia_get_pointer_ixx (IntPtr message);

	

	

	// ----------- end member Inertia.ixx ---------------
	

	

	// ----------- begin member Inertia.iyy -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Inertia_get_iyy (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Inertia_set_iyy (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Inertia_get_pointer_iyy (IntPtr message);

	

	

	// ----------- end member Inertia.iyy ---------------
	

	

	// ----------- begin member Inertia.ixz -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Inertia_get_ixz (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Inertia_set_ixz (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Inertia_get_pointer_ixz (IntPtr message);

	

	

	// ----------- end member Inertia.ixz ---------------
	

	

	// ----------- begin member Inertia.ixy -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Inertia_get_ixy (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Inertia_set_ixy (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Inertia_get_pointer_ixy (IntPtr message);

	

	

	// ----------- end member Inertia.ixy ---------------
	

	

	// ----------- begin member Inertia.com -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Inertia_get_pointer_com (IntPtr message);

	

	

	// ----------- end member Inertia.com ---------------
	

	

	// ----------- begin member Inertia.iyz -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Inertia_get_iyz (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Inertia_set_iyz (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Inertia_get_pointer_iyz (IntPtr message);

	

	

	// ----------- end member Inertia.iyz ---------------
	

	// ----------- end of message Inertia ------------------------------
	

	

	// ----------- begin message Touch -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Touch_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Touch_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Touch_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Touch_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Touch_get_pointer (IntPtr message);



	

	

	// ----------- begin member Touch.x -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Touch_get_x (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Touch_set_x (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Touch_get_pointer_x (IntPtr message);

	

	

	// ----------- end member Touch.x ---------------
	

	

	// ----------- begin member Touch.y -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Touch_get_y (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Touch_set_y (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Touch_get_pointer_y (IntPtr message);

	

	

	// ----------- end member Touch.y ---------------
	

	

	// ----------- begin member Touch.tag -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Touch_get_pointer_tag (IntPtr message);

	

	

	// ----------- end member Touch.tag ---------------
	

	

	// ----------- begin member Touch.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Touch_get_pointer_header (IntPtr message);

	

	

	// ----------- end member Touch.header ---------------
	

	// ----------- end of message Touch ------------------------------
	

	

	// ----------- begin message Twist -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Twist_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Twist_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Twist_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Twist_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Twist_get_pointer (IntPtr message);



	

	

	// ----------- begin member Twist.angular -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Twist_get_pointer_angular (IntPtr message);

	

	

	// ----------- end member Twist.angular ---------------
	

	

	// ----------- begin member Twist.linear -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Twist_get_pointer_linear (IntPtr message);

	

	

	// ----------- end member Twist.linear ---------------
	

	// ----------- end of message Twist ------------------------------
	

	

	// ----------- begin message Byte -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Byte_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Byte_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Byte_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Byte_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Byte_get_pointer (IntPtr message);



	

	

	// ----------- begin member Byte.data -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Byte_get_pointer_data (IntPtr message);

	

	

	// ----------- end member Byte.data ---------------
	

	// ----------- end of message Byte ------------------------------
	

	

	// ----------- begin message FaceData -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_FaceData_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_pointer (IntPtr message);



	

	

	// ----------- begin member FaceData.LANDMARK_LIP_RIGHT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_LIP_RIGHT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_LIP_RIGHT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_LIP_RIGHT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYELID_RIGHT_TOP -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYELID_RIGHT_TOP;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYELID_RIGHT_TOP ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYELID_RIGHT_TOP ---------------
	

	

	// ----------- begin member FaceData.bounding_rectangle -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_pointer_bounding_rectangle(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_size_bounding_rectangle(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_member_pointer_bounding_rectangle(IntPtr message_pointer, int index);

	

	

	// ----------- end member FaceData.bounding_rectangle ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYELID_RIGHT_RIGHT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYELID_RIGHT_RIGHT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYELID_RIGHT_RIGHT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYELID_RIGHT_RIGHT ---------------
	

	

	// ----------- begin member FaceData.head_pose_rotation -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_pointer_head_pose_rotation (IntPtr message);

	

	

	// ----------- end member FaceData.head_pose_rotation ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_NOT_NAMED -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_NOT_NAMED;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_NOT_NAMED ();

	
	

	

	// ----------- end member FaceData.LANDMARK_NOT_NAMED ---------------
	

	

	// ----------- begin member FaceData.landmark_image -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_pointer_landmark_image(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_size_landmark_image(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_FaceData_resize_landmark_image(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_member_pointer_landmark_image(IntPtr message_pointer, int index);

	

	

	// ----------- end member FaceData.landmark_image ---------------
	

	

	// ----------- begin member FaceData.landmark_confidence_world -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static int32_t cs_ros_message_FaceData_get_array_member_landmark_confidence_world(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_FaceData_set_array_member_landmark_confidence_world(IntPtr message_pointer, int index, int32_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_pointer_landmark_confidence_world(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_size_landmark_confidence_world(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_FaceData_resize_landmark_confidence_world(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_member_pointer_landmark_confidence_world(IntPtr message_pointer, int index);

	

	

	// ----------- end member FaceData.landmark_confidence_world ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_FACE_BORDER_TOP_LEFT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_FACE_BORDER_TOP_LEFT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_FACE_BORDER_TOP_LEFT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_FACE_BORDER_TOP_LEFT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYE_LEFT_CENTER -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYE_LEFT_CENTER;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYE_LEFT_CENTER ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYE_LEFT_CENTER ---------------
	

	

	// ----------- begin member FaceData.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_pointer_header (IntPtr message);

	

	

	// ----------- end member FaceData.header ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYELID_RIGHT_BOTTOM -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYELID_RIGHT_BOTTOM;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYELID_RIGHT_BOTTOM ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYELID_RIGHT_BOTTOM ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYELID_LEFT_TOP -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYELID_LEFT_TOP;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYELID_LEFT_TOP ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYELID_LEFT_TOP ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYEBROW_LEFT_CENTER -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYEBROW_LEFT_CENTER;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYEBROW_LEFT_CENTER ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYEBROW_LEFT_CENTER ---------------
	

	

	// ----------- begin member FaceData.landmark_world -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_pointer_landmark_world(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_size_landmark_world(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_FaceData_resize_landmark_world(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_member_pointer_landmark_world(IntPtr message_pointer, int index);

	

	

	// ----------- end member FaceData.landmark_world ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_UPPER_LIP_RIGHT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_UPPER_LIP_RIGHT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_UPPER_LIP_RIGHT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_UPPER_LIP_RIGHT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_UPPER_LIP_LEFT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_UPPER_LIP_LEFT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_UPPER_LIP_LEFT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_UPPER_LIP_LEFT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_NOSE_LEFT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_NOSE_LEFT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_NOSE_LEFT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_NOSE_LEFT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYELID_RIGHT_LEFT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYELID_RIGHT_LEFT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYELID_RIGHT_LEFT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYELID_RIGHT_LEFT ---------------
	

	

	// ----------- begin member FaceData.head_pose_confidence -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static int32_t cs_ros_message_FaceData_get_head_pose_confidence (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_FaceData_set_head_pose_confidence (IntPtr message, int32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_pointer_head_pose_confidence (IntPtr message);

	

	

	// ----------- end member FaceData.head_pose_confidence ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_LIP_LEFT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_LIP_LEFT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_LIP_LEFT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_LIP_LEFT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYEBROW_RIGHT_CENTER -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYEBROW_RIGHT_CENTER;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYEBROW_RIGHT_CENTER ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYEBROW_RIGHT_CENTER ---------------
	

	

	// ----------- begin member FaceData.head_pose_center -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_pointer_head_pose_center (IntPtr message);

	

	

	// ----------- end member FaceData.head_pose_center ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYELID_LEFT_RIGHT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYELID_LEFT_RIGHT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYELID_LEFT_RIGHT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYELID_LEFT_RIGHT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYELID_LEFT_BOTTOM -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYELID_LEFT_BOTTOM;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYELID_LEFT_BOTTOM ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYELID_LEFT_BOTTOM ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_LOWER_LIP_LEFT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_LOWER_LIP_LEFT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_LOWER_LIP_LEFT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_LOWER_LIP_LEFT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_LOWER_LIP_RIGHT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_LOWER_LIP_RIGHT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_LOWER_LIP_RIGHT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_LOWER_LIP_RIGHT ---------------
	

	

	// ----------- begin member FaceData.average_depth -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_FaceData_get_average_depth (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_FaceData_set_average_depth (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_pointer_average_depth (IntPtr message);

	

	

	// ----------- end member FaceData.average_depth ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_NOSE_TOP -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_NOSE_TOP;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_NOSE_TOP ();

	
	

	

	// ----------- end member FaceData.LANDMARK_NOSE_TOP ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYE_RIGHT_CENTER -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYE_RIGHT_CENTER;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYE_RIGHT_CENTER ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYE_RIGHT_CENTER ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYELID_LEFT_LEFT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYELID_LEFT_LEFT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYELID_LEFT_LEFT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYELID_LEFT_LEFT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYEBROW_RIGHT_RIGHT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYEBROW_RIGHT_RIGHT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYEBROW_RIGHT_RIGHT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYEBROW_RIGHT_RIGHT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_NOSE_BOTTOM -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_NOSE_BOTTOM;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_NOSE_BOTTOM ();

	
	

	

	// ----------- end member FaceData.LANDMARK_NOSE_BOTTOM ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_NOSE_TIP -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_NOSE_TIP;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_NOSE_TIP ();

	
	

	

	// ----------- end member FaceData.LANDMARK_NOSE_TIP ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_FACE_BORDER_TOP_RIGHT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_FACE_BORDER_TOP_RIGHT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_FACE_BORDER_TOP_RIGHT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_FACE_BORDER_TOP_RIGHT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_UPPER_LIP_CENTER -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_UPPER_LIP_CENTER;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_UPPER_LIP_CENTER ();

	
	

	

	// ----------- end member FaceData.LANDMARK_UPPER_LIP_CENTER ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_LOWER_LIP_CENTER -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_LOWER_LIP_CENTER;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_LOWER_LIP_CENTER ();

	
	

	

	// ----------- end member FaceData.LANDMARK_LOWER_LIP_CENTER ---------------
	

	

	// ----------- begin member FaceData.intensity -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static int32_t cs_ros_message_FaceData_get_array_member_intensity(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_FaceData_set_array_member_intensity(IntPtr message_pointer, int index, int32_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_pointer_intensity(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_size_intensity(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_member_pointer_intensity(IntPtr message_pointer, int index);

	

	

	// ----------- end member FaceData.intensity ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYEBROW_LEFT_RIGHT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYEBROW_LEFT_RIGHT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYEBROW_LEFT_RIGHT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYEBROW_LEFT_RIGHT ---------------
	

	

	// ----------- begin member FaceData.landmark_confidence_image -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static int32_t cs_ros_message_FaceData_get_array_member_landmark_confidence_image(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_FaceData_set_array_member_landmark_confidence_image(IntPtr message_pointer, int index, int32_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_pointer_landmark_confidence_image(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_size_landmark_confidence_image(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_FaceData_resize_landmark_confidence_image(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_member_pointer_landmark_confidence_image(IntPtr message_pointer, int index);

	

	

	// ----------- end member FaceData.landmark_confidence_image ---------------
	

	

	// ----------- begin member FaceData.landmark_types -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_array_member_landmark_types(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_FaceData_set_array_member_landmark_types(IntPtr message_pointer, int index, uint32_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_pointer_landmark_types(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_size_landmark_types(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_FaceData_resize_landmark_types(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FaceData_get_array_member_pointer_landmark_types(IntPtr message_pointer, int index);

	

	

	// ----------- end member FaceData.landmark_types ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_NOSE_RIGHT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_NOSE_RIGHT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_NOSE_RIGHT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_NOSE_RIGHT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_CHIN -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_CHIN;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_CHIN ();

	
	

	

	// ----------- end member FaceData.LANDMARK_CHIN ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYEBROW_LEFT_LEFT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYEBROW_LEFT_LEFT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYEBROW_LEFT_LEFT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYEBROW_LEFT_LEFT ---------------
	

	

	// ----------- begin member FaceData.LANDMARK_EYEBROW_RIGHT_LEFT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_FaceData_LANDMARK_EYEBROW_RIGHT_LEFT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_FaceData_get_LANDMARK_EYEBROW_RIGHT_LEFT ();

	
	

	

	// ----------- end member FaceData.LANDMARK_EYEBROW_RIGHT_LEFT ---------------
	

	// ----------- end of message FaceData ------------------------------
	

	

	// ----------- begin message TransitionAction -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransitionAction_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_TransitionAction_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransitionAction_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransitionAction_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransitionAction_get_pointer (IntPtr message);



	

	

	// ----------- begin member TransitionAction.ref -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransitionAction_get_pointer_ref (IntPtr message);

	

	

	// ----------- end member TransitionAction.ref ---------------
	

	

	// ----------- begin member TransitionAction.end -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransitionAction_get_pointer_end (IntPtr message);

	

	

	// ----------- end member TransitionAction.end ---------------
	

	

	// ----------- begin member TransitionAction.start -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransitionAction_get_pointer_start (IntPtr message);

	

	

	// ----------- end member TransitionAction.start ---------------
	

	// ----------- end of message TransitionAction ------------------------------
	

	

	// ----------- begin message ActionRef -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionRef_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_ActionRef_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionRef_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionRef_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionRef_get_pointer (IntPtr message);



	

	

	// ----------- begin member ActionRef.sender -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionRef_get_pointer_sender (IntPtr message);

	

	

	// ----------- end member ActionRef.sender ---------------
	

	

	// ----------- begin member ActionRef.seq -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_ActionRef_get_seq (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_ActionRef_set_seq (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionRef_get_pointer_seq (IntPtr message);

	

	

	// ----------- end member ActionRef.seq ---------------
	

	// ----------- end of message ActionRef ------------------------------
	

	

	// ----------- begin message UInt16MultiArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt16MultiArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt16MultiArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt16MultiArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt16MultiArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt16MultiArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member UInt16MultiArray.layout -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt16MultiArray_get_pointer_layout (IntPtr message);

	

	

	// ----------- end member UInt16MultiArray.layout ---------------
	

	

	// ----------- begin member UInt16MultiArray.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static uint16_t cs_ros_message_UInt16MultiArray_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt16MultiArray_set_array_member_data(IntPtr message_pointer, int index, uint16_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt16MultiArray_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_UInt16MultiArray_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt16MultiArray_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt16MultiArray_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member UInt16MultiArray.data ---------------
	

	// ----------- end of message UInt16MultiArray ------------------------------
	

	

	// ----------- begin message ChannelFloat32 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ChannelFloat32_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_ChannelFloat32_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ChannelFloat32_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ChannelFloat32_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ChannelFloat32_get_pointer (IntPtr message);



	

	

	// ----------- begin member ChannelFloat32.name -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ChannelFloat32_get_pointer_name (IntPtr message);

	

	

	// ----------- end member ChannelFloat32.name ---------------
	

	

	// ----------- begin member ChannelFloat32.values -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_ChannelFloat32_get_array_member_values(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_ChannelFloat32_set_array_member_values(IntPtr message_pointer, int index, float value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ChannelFloat32_get_array_pointer_values(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_ChannelFloat32_get_size_values(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_ChannelFloat32_resize_values(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ChannelFloat32_get_array_member_pointer_values(IntPtr message_pointer, int index);

	

	

	// ----------- end member ChannelFloat32.values ---------------
	

	// ----------- end of message ChannelFloat32 ------------------------------
	

	

	// ----------- begin message PolygonStamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PolygonStamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PolygonStamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PolygonStamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PolygonStamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PolygonStamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member PolygonStamped.polygon -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PolygonStamped_get_pointer_polygon (IntPtr message);

	

	

	// ----------- end member PolygonStamped.polygon ---------------
	

	

	// ----------- begin member PolygonStamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PolygonStamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member PolygonStamped.header ---------------
	

	// ----------- end of message PolygonStamped ------------------------------
	

	

	// ----------- begin message PoseStamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseStamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PoseStamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseStamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseStamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseStamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member PoseStamped.pose -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseStamped_get_pointer_pose (IntPtr message);

	

	

	// ----------- end member PoseStamped.pose ---------------
	

	

	// ----------- begin member PoseStamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseStamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member PoseStamped.header ---------------
	

	// ----------- end of message PoseStamped ------------------------------
	

	

	// ----------- begin message String -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_String_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_String_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_String_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_String_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_String_get_pointer (IntPtr message);



	

	

	// ----------- begin member String.data -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_String_get_pointer_data (IntPtr message);

	

	

	// ----------- end member String.data ---------------
	

	// ----------- end of message String ------------------------------
	

	

	// ----------- begin message LedCmd -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_LedCmd_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_get_pointer (IntPtr message);



	

	

	// ----------- begin member LedCmd.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_get_pointer_header (IntPtr message);

	

	

	// ----------- end member LedCmd.header ---------------
	

	

	// ----------- begin member LedCmd.bright -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LedCmd_get_bright (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LedCmd_set_bright (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_get_pointer_bright (IntPtr message);

	

	

	// ----------- end member LedCmd.bright ---------------
	

	

	// ----------- begin member LedCmd.rgb_range -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint16_t cs_ros_message_LedCmd_get_rgb_range (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LedCmd_set_rgb_range (IntPtr message, uint16_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_get_pointer_rgb_range (IntPtr message);

	

	

	// ----------- end member LedCmd.rgb_range ---------------
	

	

	// ----------- begin member LedCmd.phase_range -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LedCmd_get_phase_range (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LedCmd_set_phase_range (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_get_pointer_phase_range (IntPtr message);

	

	

	// ----------- end member LedCmd.phase_range ---------------
	

	

	// ----------- begin member LedCmd.rgb -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static uint16_t cs_ros_message_LedCmd_get_array_member_rgb(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_LedCmd_set_array_member_rgb(IntPtr message_pointer, int index, uint16_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_get_array_pointer_rgb(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_LedCmd_get_size_rgb(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_get_array_member_pointer_rgb(IntPtr message_pointer, int index);

	

	

	// ----------- end member LedCmd.rgb ---------------
	

	

	// ----------- begin member LedCmd.other -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LedCmd_get_other (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LedCmd_set_other (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_get_pointer_other (IntPtr message);

	

	

	// ----------- end member LedCmd.other ---------------
	

	

	// ----------- begin member LedCmd.freq -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LedCmd_get_freq (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LedCmd_set_freq (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_get_pointer_freq (IntPtr message);

	

	

	// ----------- end member LedCmd.freq ---------------
	

	

	// ----------- begin member LedCmd.t_transition -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LedCmd_get_t_transition (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LedCmd_set_t_transition (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_get_pointer_t_transition (IntPtr message);

	

	

	// ----------- end member LedCmd.t_transition ---------------
	

	

	// ----------- begin member LedCmd.bright_range -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LedCmd_get_bright_range (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LedCmd_set_bright_range (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LedCmd_get_pointer_bright_range (IntPtr message);

	

	

	// ----------- end member LedCmd.bright_range ---------------
	

	// ----------- end of message LedCmd ------------------------------
	

	

	// ----------- begin message ImuData -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ImuData_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_ImuData_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ImuData_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ImuData_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ImuData_get_pointer (IntPtr message);



	

	

	// ----------- begin member ImuData.linear_acceleration -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ImuData_get_pointer_linear_acceleration (IntPtr message);

	

	

	// ----------- end member ImuData.linear_acceleration ---------------
	

	

	// ----------- begin member ImuData.angular_velocity -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ImuData_get_pointer_angular_velocity (IntPtr message);

	

	

	// ----------- end member ImuData.angular_velocity ---------------
	

	

	// ----------- begin member ImuData.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ImuData_get_pointer_header (IntPtr message);

	

	

	// ----------- end member ImuData.header ---------------
	

	// ----------- end of message ImuData ------------------------------
	

	

	// ----------- begin message Image -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Image_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Image_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Image_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Image_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Image_get_pointer (IntPtr message);



	

	

	// ----------- begin member Image.is_bigendian -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_Image_get_is_bigendian (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Image_set_is_bigendian (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Image_get_pointer_is_bigendian (IntPtr message);

	

	

	// ----------- end member Image.is_bigendian ---------------
	

	

	// ----------- begin member Image.encoding -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Image_get_pointer_encoding (IntPtr message);

	

	

	// ----------- end member Image.encoding ---------------
	

	

	// ----------- begin member Image.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Image_get_pointer_header (IntPtr message);

	

	

	// ----------- end member Image.header ---------------
	

	

	// ----------- begin member Image.height -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Image_get_height (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Image_set_height (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Image_get_pointer_height (IntPtr message);

	

	

	// ----------- end member Image.height ---------------
	

	

	// ----------- begin member Image.step -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Image_get_step (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Image_set_step (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Image_get_pointer_step (IntPtr message);

	

	

	// ----------- end member Image.step ---------------
	

	

	// ----------- begin member Image.width -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Image_get_width (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Image_set_width (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Image_get_pointer_width (IntPtr message);

	

	

	// ----------- end member Image.width ---------------
	

	

	// ----------- begin member Image.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_Image_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Image_set_array_member_data(IntPtr message_pointer, int index, uint8_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Image_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Image_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Image_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Image_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member Image.data ---------------
	

	// ----------- end of message Image ------------------------------
	

	

	// ----------- begin message Float32 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float32_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Float32_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float32_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float32_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float32_get_pointer (IntPtr message);



	

	

	// ----------- begin member Float32.data -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Float32_get_data (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Float32_set_data (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float32_get_pointer_data (IntPtr message);

	

	

	// ----------- end member Float32.data ---------------
	

	// ----------- end of message Float32 ------------------------------
	

	

	// ----------- begin message Polygon -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Polygon_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Polygon_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Polygon_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Polygon_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Polygon_get_pointer (IntPtr message);



	

	

	// ----------- begin member Polygon.points -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Polygon_get_array_pointer_points(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Polygon_get_size_points(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Polygon_resize_points(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Polygon_get_array_member_pointer_points(IntPtr message_pointer, int index);

	

	

	// ----------- end member Polygon.points ---------------
	

	// ----------- end of message Polygon ------------------------------
	

	

	// ----------- begin message JoyFeedback -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedback_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_JoyFeedback_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedback_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedback_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedback_get_pointer (IntPtr message);



	

	

	// ----------- begin member JoyFeedback.intensity -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_JoyFeedback_get_intensity (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_JoyFeedback_set_intensity (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedback_get_pointer_intensity (IntPtr message);

	

	

	// ----------- end member JoyFeedback.intensity ---------------
	

	

	// ----------- begin member JoyFeedback.type -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_JoyFeedback_get_type (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_JoyFeedback_set_type (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedback_get_pointer_type (IntPtr message);

	

	

	// ----------- end member JoyFeedback.type ---------------
	

	

	// ----------- begin member JoyFeedback.TYPE_LED -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_JoyFeedback_TYPE_LED;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_JoyFeedback_get_TYPE_LED ();

	
	

	

	// ----------- end member JoyFeedback.TYPE_LED ---------------
	

	

	// ----------- begin member JoyFeedback.TYPE_BUZZER -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_JoyFeedback_TYPE_BUZZER;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_JoyFeedback_get_TYPE_BUZZER ();

	
	

	

	// ----------- end member JoyFeedback.TYPE_BUZZER ---------------
	

	

	// ----------- begin member JoyFeedback.id -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_JoyFeedback_get_id (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_JoyFeedback_set_id (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_JoyFeedback_get_pointer_id (IntPtr message);

	

	

	// ----------- end member JoyFeedback.id ---------------
	

	

	// ----------- begin member JoyFeedback.TYPE_RUMBLE -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_JoyFeedback_TYPE_RUMBLE;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_JoyFeedback_get_TYPE_RUMBLE ();

	
	

	

	// ----------- end member JoyFeedback.TYPE_RUMBLE ---------------
	

	// ----------- end of message JoyFeedback ------------------------------
	

	

	// ----------- begin message ActionUpdate -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionUpdate_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_ActionUpdate_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionUpdate_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionUpdate_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionUpdate_get_pointer (IntPtr message);



	

	

	// ----------- begin member ActionUpdate.status -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_ActionUpdate_get_status (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_ActionUpdate_set_status (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionUpdate_get_pointer_status (IntPtr message);

	

	

	// ----------- end member ActionUpdate.status ---------------
	

	

	// ----------- begin member ActionUpdate.COMPLETED_SUCCESSFULLY -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_ActionUpdate_COMPLETED_SUCCESSFULLY;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_ActionUpdate_get_COMPLETED_SUCCESSFULLY ();

	
	

	

	// ----------- end member ActionUpdate.COMPLETED_SUCCESSFULLY ---------------
	

	

	// ----------- begin member ActionUpdate.progress -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_ActionUpdate_get_progress (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_ActionUpdate_set_progress (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionUpdate_get_pointer_progress (IntPtr message);

	

	

	// ----------- end member ActionUpdate.progress ---------------
	

	

	// ----------- begin member ActionUpdate.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionUpdate_get_pointer_header (IntPtr message);

	

	

	// ----------- end member ActionUpdate.header ---------------
	

	

	// ----------- begin member ActionUpdate.IN_PROGRESS -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_ActionUpdate_IN_PROGRESS;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_ActionUpdate_get_IN_PROGRESS ();

	
	

	

	// ----------- end member ActionUpdate.IN_PROGRESS ---------------
	

	

	// ----------- begin member ActionUpdate.COMPLETED_FAILURE -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_ActionUpdate_COMPLETED_FAILURE;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_ActionUpdate_get_COMPLETED_FAILURE ();

	
	

	

	// ----------- end member ActionUpdate.COMPLETED_FAILURE ---------------
	

	

	// ----------- begin member ActionUpdate.INTERRUPTED -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_ActionUpdate_INTERRUPTED;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_ActionUpdate_get_INTERRUPTED ();

	
	

	

	// ----------- end member ActionUpdate.INTERRUPTED ---------------
	

	

	// ----------- begin member ActionUpdate.ref -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_ActionUpdate_get_pointer_ref (IntPtr message);

	

	

	// ----------- end member ActionUpdate.ref ---------------
	

	// ----------- end of message ActionUpdate ------------------------------
	

	

	// ----------- begin message Participant -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Participant_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Participant_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Participant_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Participant_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Participant_get_pointer (IntPtr message);



	

	

	// ----------- begin member Participant.quiz_correct -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Participant_get_array_member_quiz_correct(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Participant_set_array_member_quiz_correct(IntPtr message_pointer, int index, uint32_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Participant_get_array_pointer_quiz_correct(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Participant_get_size_quiz_correct(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Participant_resize_quiz_correct(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Participant_get_array_member_pointer_quiz_correct(IntPtr message_pointer, int index);

	

	

	// ----------- end member Participant.quiz_correct ---------------
	

	

	// ----------- begin member Participant.description -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Participant_get_pointer_description (IntPtr message);

	

	

	// ----------- end member Participant.description ---------------
	

	

	// ----------- begin member Participant.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Participant_get_pointer_header (IntPtr message);

	

	

	// ----------- end member Participant.header ---------------
	

	

	// ----------- begin member Participant.START_QUIZ -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_Participant_START_QUIZ;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Participant_get_START_QUIZ ();

	
	

	

	// ----------- end member Participant.START_QUIZ ---------------
	

	

	// ----------- begin member Participant.START_GAME -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_Participant_START_GAME;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Participant_get_START_GAME ();

	
	

	

	// ----------- end member Participant.START_GAME ---------------
	

	

	// ----------- begin member Participant.QUIZ_ANSWER -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_Participant_QUIZ_ANSWER;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Participant_get_QUIZ_ANSWER ();

	
	

	

	// ----------- end member Participant.QUIZ_ANSWER ---------------
	

	

	// ----------- begin member Participant.participant_id -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Participant_get_participant_id (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Participant_set_participant_id (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Participant_get_pointer_participant_id (IntPtr message);

	

	

	// ----------- end member Participant.participant_id ---------------
	

	

	// ----------- begin member Participant.NEW -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_Participant_NEW;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Participant_get_NEW ();

	
	

	

	// ----------- end member Participant.NEW ---------------
	

	

	// ----------- begin member Participant.PRE_GAME -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_Participant_PRE_GAME;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Participant_get_PRE_GAME ();

	
	

	

	// ----------- end member Participant.PRE_GAME ---------------
	

	

	// ----------- begin member Participant.quiz_selection -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Participant_get_quiz_selection (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Participant_set_quiz_selection (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Participant_get_pointer_quiz_selection (IntPtr message);

	

	

	// ----------- end member Participant.quiz_selection ---------------
	

	

	// ----------- begin member Participant.FINISHED -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_Participant_FINISHED;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Participant_get_FINISHED ();

	
	

	

	// ----------- end member Participant.FINISHED ---------------
	

	

	// ----------- begin member Participant.participant_action -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Participant_get_participant_action (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Participant_set_participant_action (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Participant_get_pointer_participant_action (IntPtr message);

	

	

	// ----------- end member Participant.participant_action ---------------
	

	

	// ----------- begin member Participant.SCRATCH -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_Participant_SCRATCH;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Participant_get_SCRATCH ();

	
	

	

	// ----------- end member Participant.SCRATCH ---------------
	

	// ----------- end of message Participant ------------------------------
	

	

	// ----------- begin message Int32 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int32_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int32_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int32_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int32_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int32_get_pointer (IntPtr message);



	

	

	// ----------- begin member Int32.data -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static int32_t cs_ros_message_Int32_get_data (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Int32_set_data (IntPtr message, int32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int32_get_pointer_data (IntPtr message);

	

	

	// ----------- end member Int32.data ---------------
	

	// ----------- end of message Int32 ------------------------------
	

	

	// ----------- begin message VideoControl -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_VideoControl_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_VideoControl_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_VideoControl_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_VideoControl_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_VideoControl_get_pointer (IntPtr message);



	

	

	// ----------- begin member VideoControl.PAUSE -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_VideoControl_PAUSE;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_VideoControl_get_PAUSE ();

	
	

	

	// ----------- end member VideoControl.PAUSE ---------------
	

	

	// ----------- begin member VideoControl.PLAY -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_VideoControl_PLAY;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_VideoControl_get_PLAY ();

	
	

	

	// ----------- end member VideoControl.PLAY ---------------
	

	

	// ----------- begin member VideoControl.video_command -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_VideoControl_get_video_command (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_VideoControl_set_video_command (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_VideoControl_get_pointer_video_command (IntPtr message);

	

	

	// ----------- end member VideoControl.video_command ---------------
	

	

	// ----------- begin member VideoControl.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_VideoControl_get_pointer_header (IntPtr message);

	

	

	// ----------- end member VideoControl.header ---------------
	

	

	// ----------- begin member VideoControl.NEXT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_VideoControl_NEXT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_VideoControl_get_NEXT ();

	
	

	

	// ----------- end member VideoControl.NEXT ---------------
	

	

	// ----------- begin member VideoControl.PREV -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_VideoControl_PREV;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_VideoControl_get_PREV ();

	
	

	

	// ----------- end member VideoControl.PREV ---------------
	

	

	// ----------- begin member VideoControl.STOP -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_VideoControl_STOP;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_VideoControl_get_STOP ();

	
	

	

	// ----------- end member VideoControl.STOP ---------------
	

	// ----------- end of message VideoControl ------------------------------
	

	

	// ----------- begin message EyeOpenAction -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeOpenAction_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_EyeOpenAction_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeOpenAction_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeOpenAction_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeOpenAction_get_pointer (IntPtr message);



	

	

	// ----------- begin member EyeOpenAction.CLOSE -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_EyeOpenAction_CLOSE;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_EyeOpenAction_get_CLOSE ();

	
	

	

	// ----------- end member EyeOpenAction.CLOSE ---------------
	

	

	// ----------- begin member EyeOpenAction.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeOpenAction_get_pointer_header (IntPtr message);

	

	

	// ----------- end member EyeOpenAction.header ---------------
	

	

	// ----------- begin member EyeOpenAction.OPEN -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_EyeOpenAction_OPEN;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_EyeOpenAction_get_OPEN ();

	
	

	

	// ----------- end member EyeOpenAction.OPEN ---------------
	

	

	// ----------- begin member EyeOpenAction.TOGGLE -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_EyeOpenAction_TOGGLE;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_EyeOpenAction_get_TOGGLE ();

	
	

	

	// ----------- end member EyeOpenAction.TOGGLE ---------------
	

	

	// ----------- begin member EyeOpenAction.eye_open_action -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_EyeOpenAction_get_eye_open_action (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_EyeOpenAction_set_eye_open_action (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeOpenAction_get_pointer_eye_open_action (IntPtr message);

	

	

	// ----------- end member EyeOpenAction.eye_open_action ---------------
	

	

	// ----------- begin member EyeOpenAction.action_time -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EyeOpenAction_get_pointer_action_time (IntPtr message);

	

	

	// ----------- end member EyeOpenAction.action_time ---------------
	

	// ----------- end of message EyeOpenAction ------------------------------
	

	

	// ----------- begin message PointStamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointStamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PointStamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointStamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointStamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointStamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member PointStamped.point -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointStamped_get_pointer_point (IntPtr message);

	

	

	// ----------- end member PointStamped.point ---------------
	

	

	// ----------- begin member PointStamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointStamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member PointStamped.header ---------------
	

	// ----------- end of message PointStamped ------------------------------
	

	

	// ----------- begin message NavSatStatus -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatStatus_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_NavSatStatus_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatStatus_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatStatus_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatStatus_get_pointer (IntPtr message);



	

	

	// ----------- begin member NavSatStatus.status -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static int8_t cs_ros_message_NavSatStatus_get_status (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_NavSatStatus_set_status (IntPtr message, int8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatStatus_get_pointer_status (IntPtr message);

	

	

	// ----------- end member NavSatStatus.status ---------------
	

	

	// ----------- begin member NavSatStatus.SERVICE_GPS -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint16_t CS_ROS_MESSAGE_NavSatStatus_SERVICE_GPS;

	[DllImport("cs_ros_bridge")]
	public extern static uint16_t cs_ros_message_NavSatStatus_get_SERVICE_GPS ();

	
	

	

	// ----------- end member NavSatStatus.SERVICE_GPS ---------------
	

	

	// ----------- begin member NavSatStatus.STATUS_NO_FIX -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static int8_t CS_ROS_MESSAGE_NavSatStatus_STATUS_NO_FIX;

	[DllImport("cs_ros_bridge")]
	public extern static int8_t cs_ros_message_NavSatStatus_get_STATUS_NO_FIX ();

	
	

	

	// ----------- end member NavSatStatus.STATUS_NO_FIX ---------------
	

	

	// ----------- begin member NavSatStatus.SERVICE_GLONASS -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint16_t CS_ROS_MESSAGE_NavSatStatus_SERVICE_GLONASS;

	[DllImport("cs_ros_bridge")]
	public extern static uint16_t cs_ros_message_NavSatStatus_get_SERVICE_GLONASS ();

	
	

	

	// ----------- end member NavSatStatus.SERVICE_GLONASS ---------------
	

	

	// ----------- begin member NavSatStatus.STATUS_FIX -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static int8_t CS_ROS_MESSAGE_NavSatStatus_STATUS_FIX;

	[DllImport("cs_ros_bridge")]
	public extern static int8_t cs_ros_message_NavSatStatus_get_STATUS_FIX ();

	
	

	

	// ----------- end member NavSatStatus.STATUS_FIX ---------------
	

	

	// ----------- begin member NavSatStatus.SERVICE_GALILEO -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint16_t CS_ROS_MESSAGE_NavSatStatus_SERVICE_GALILEO;

	[DllImport("cs_ros_bridge")]
	public extern static uint16_t cs_ros_message_NavSatStatus_get_SERVICE_GALILEO ();

	
	

	

	// ----------- end member NavSatStatus.SERVICE_GALILEO ---------------
	

	

	// ----------- begin member NavSatStatus.service -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint16_t cs_ros_message_NavSatStatus_get_service (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_NavSatStatus_set_service (IntPtr message, uint16_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatStatus_get_pointer_service (IntPtr message);

	

	

	// ----------- end member NavSatStatus.service ---------------
	

	

	// ----------- begin member NavSatStatus.SERVICE_COMPASS -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint16_t CS_ROS_MESSAGE_NavSatStatus_SERVICE_COMPASS;

	[DllImport("cs_ros_bridge")]
	public extern static uint16_t cs_ros_message_NavSatStatus_get_SERVICE_COMPASS ();

	
	

	

	// ----------- end member NavSatStatus.SERVICE_COMPASS ---------------
	

	// ----------- end of message NavSatStatus ------------------------------
	

	

	// ----------- begin message LaserScan -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserScan_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_pointer (IntPtr message);



	

	

	// ----------- begin member LaserScan.scan_time -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LaserScan_get_scan_time (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserScan_set_scan_time (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_pointer_scan_time (IntPtr message);

	

	

	// ----------- end member LaserScan.scan_time ---------------
	

	

	// ----------- begin member LaserScan.intensities -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LaserScan_get_array_member_intensities(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserScan_set_array_member_intensities(IntPtr message_pointer, int index, float value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_array_pointer_intensities(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_LaserScan_get_size_intensities(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserScan_resize_intensities(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_array_member_pointer_intensities(IntPtr message_pointer, int index);

	

	

	// ----------- end member LaserScan.intensities ---------------
	

	

	// ----------- begin member LaserScan.angle_min -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LaserScan_get_angle_min (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserScan_set_angle_min (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_pointer_angle_min (IntPtr message);

	

	

	// ----------- end member LaserScan.angle_min ---------------
	

	

	// ----------- begin member LaserScan.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_pointer_header (IntPtr message);

	

	

	// ----------- end member LaserScan.header ---------------
	

	

	// ----------- begin member LaserScan.angle_increment -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LaserScan_get_angle_increment (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserScan_set_angle_increment (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_pointer_angle_increment (IntPtr message);

	

	

	// ----------- end member LaserScan.angle_increment ---------------
	

	

	// ----------- begin member LaserScan.time_increment -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LaserScan_get_time_increment (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserScan_set_time_increment (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_pointer_time_increment (IntPtr message);

	

	

	// ----------- end member LaserScan.time_increment ---------------
	

	

	// ----------- begin member LaserScan.ranges -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LaserScan_get_array_member_ranges(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserScan_set_array_member_ranges(IntPtr message_pointer, int index, float value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_array_pointer_ranges(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_LaserScan_get_size_ranges(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserScan_resize_ranges(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_array_member_pointer_ranges(IntPtr message_pointer, int index);

	

	

	// ----------- end member LaserScan.ranges ---------------
	

	

	// ----------- begin member LaserScan.range_min -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LaserScan_get_range_min (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserScan_set_range_min (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_pointer_range_min (IntPtr message);

	

	

	// ----------- end member LaserScan.range_min ---------------
	

	

	// ----------- begin member LaserScan.range_max -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LaserScan_get_range_max (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserScan_set_range_max (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_pointer_range_max (IntPtr message);

	

	

	// ----------- end member LaserScan.range_max ---------------
	

	

	// ----------- begin member LaserScan.angle_max -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LaserScan_get_angle_max (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserScan_set_angle_max (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserScan_get_pointer_angle_max (IntPtr message);

	

	

	// ----------- end member LaserScan.angle_max ---------------
	

	// ----------- end of message LaserScan ------------------------------
	

	

	// ----------- begin message Temperature -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Temperature_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Temperature_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Temperature_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Temperature_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Temperature_get_pointer (IntPtr message);



	

	

	// ----------- begin member Temperature.temperature -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Temperature_get_temperature (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Temperature_set_temperature (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Temperature_get_pointer_temperature (IntPtr message);

	

	

	// ----------- end member Temperature.temperature ---------------
	

	

	// ----------- begin member Temperature.variance -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Temperature_get_variance (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Temperature_set_variance (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Temperature_get_pointer_variance (IntPtr message);

	

	

	// ----------- end member Temperature.variance ---------------
	

	

	// ----------- begin member Temperature.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Temperature_get_pointer_header (IntPtr message);

	

	

	// ----------- end member Temperature.header ---------------
	

	// ----------- end of message Temperature ------------------------------
	

	

	// ----------- begin message AccelWithCovarianceStamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovarianceStamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_AccelWithCovarianceStamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovarianceStamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovarianceStamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovarianceStamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member AccelWithCovarianceStamped.accel -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovarianceStamped_get_pointer_accel (IntPtr message);

	

	

	// ----------- end member AccelWithCovarianceStamped.accel ---------------
	

	

	// ----------- begin member AccelWithCovarianceStamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovarianceStamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member AccelWithCovarianceStamped.header ---------------
	

	// ----------- end of message AccelWithCovarianceStamped ------------------------------
	

	

	// ----------- begin message MultiEchoLaserScan -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiEchoLaserScan_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_pointer (IntPtr message);



	

	

	// ----------- begin member MultiEchoLaserScan.scan_time -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_MultiEchoLaserScan_get_scan_time (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiEchoLaserScan_set_scan_time (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_pointer_scan_time (IntPtr message);

	

	

	// ----------- end member MultiEchoLaserScan.scan_time ---------------
	

	

	// ----------- begin member MultiEchoLaserScan.intensities -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_array_pointer_intensities(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_MultiEchoLaserScan_get_size_intensities(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiEchoLaserScan_resize_intensities(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_array_member_pointer_intensities(IntPtr message_pointer, int index);

	

	

	// ----------- end member MultiEchoLaserScan.intensities ---------------
	

	

	// ----------- begin member MultiEchoLaserScan.angle_min -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_MultiEchoLaserScan_get_angle_min (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiEchoLaserScan_set_angle_min (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_pointer_angle_min (IntPtr message);

	

	

	// ----------- end member MultiEchoLaserScan.angle_min ---------------
	

	

	// ----------- begin member MultiEchoLaserScan.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_pointer_header (IntPtr message);

	

	

	// ----------- end member MultiEchoLaserScan.header ---------------
	

	

	// ----------- begin member MultiEchoLaserScan.angle_increment -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_MultiEchoLaserScan_get_angle_increment (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiEchoLaserScan_set_angle_increment (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_pointer_angle_increment (IntPtr message);

	

	

	// ----------- end member MultiEchoLaserScan.angle_increment ---------------
	

	

	// ----------- begin member MultiEchoLaserScan.time_increment -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_MultiEchoLaserScan_get_time_increment (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiEchoLaserScan_set_time_increment (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_pointer_time_increment (IntPtr message);

	

	

	// ----------- end member MultiEchoLaserScan.time_increment ---------------
	

	

	// ----------- begin member MultiEchoLaserScan.ranges -------------

	

	

	

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_array_pointer_ranges(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_MultiEchoLaserScan_get_size_ranges(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiEchoLaserScan_resize_ranges(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_array_member_pointer_ranges(IntPtr message_pointer, int index);

	

	

	// ----------- end member MultiEchoLaserScan.ranges ---------------
	

	

	// ----------- begin member MultiEchoLaserScan.range_min -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_MultiEchoLaserScan_get_range_min (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiEchoLaserScan_set_range_min (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_pointer_range_min (IntPtr message);

	

	

	// ----------- end member MultiEchoLaserScan.range_min ---------------
	

	

	// ----------- begin member MultiEchoLaserScan.range_max -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_MultiEchoLaserScan_get_range_max (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiEchoLaserScan_set_range_max (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_pointer_range_max (IntPtr message);

	

	

	// ----------- end member MultiEchoLaserScan.range_max ---------------
	

	

	// ----------- begin member MultiEchoLaserScan.angle_max -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_MultiEchoLaserScan_get_angle_max (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiEchoLaserScan_set_angle_max (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiEchoLaserScan_get_pointer_angle_max (IntPtr message);

	

	

	// ----------- end member MultiEchoLaserScan.angle_max ---------------
	

	// ----------- end of message MultiEchoLaserScan ------------------------------
	

	

	// ----------- begin message QueueUpdate -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueUpdate_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_QueueUpdate_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueUpdate_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueUpdate_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueUpdate_get_pointer (IntPtr message);



	

	

	// ----------- begin member QueueUpdate.queue -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_QueueUpdate_get_array_member_queue(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_QueueUpdate_set_array_member_queue(IntPtr message_pointer, int index, uint32_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueUpdate_get_array_pointer_queue(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_QueueUpdate_get_size_queue(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_QueueUpdate_resize_queue(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueUpdate_get_array_member_pointer_queue(IntPtr message_pointer, int index);

	

	

	// ----------- end member QueueUpdate.queue ---------------
	

	

	// ----------- begin member QueueUpdate.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_QueueUpdate_get_pointer_header (IntPtr message);

	

	

	// ----------- end member QueueUpdate.header ---------------
	

	// ----------- end of message QueueUpdate ------------------------------
	

	

	// ----------- begin message Point -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Point_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point_get_pointer (IntPtr message);



	

	

	// ----------- begin member Point.z -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Point_get_z (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Point_set_z (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point_get_pointer_z (IntPtr message);

	

	

	// ----------- end member Point.z ---------------
	

	

	// ----------- begin member Point.y -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Point_get_y (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Point_set_y (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point_get_pointer_y (IntPtr message);

	

	

	// ----------- end member Point.y ---------------
	

	

	// ----------- begin member Point.x -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Point_get_x (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Point_set_x (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Point_get_pointer_x (IntPtr message);

	

	

	// ----------- end member Point.x ---------------
	

	// ----------- end of message Point ------------------------------
	

	

	// ----------- begin message AccelWithCovariance -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovariance_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_AccelWithCovariance_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovariance_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovariance_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovariance_get_pointer (IntPtr message);



	

	

	// ----------- begin member AccelWithCovariance.accel -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovariance_get_pointer_accel (IntPtr message);

	

	

	// ----------- end member AccelWithCovariance.accel ---------------
	

	

	// ----------- begin member AccelWithCovariance.covariance -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_AccelWithCovariance_get_array_member_covariance(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_AccelWithCovariance_set_array_member_covariance(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovariance_get_array_pointer_covariance(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_AccelWithCovariance_get_size_covariance(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_AccelWithCovariance_get_array_member_pointer_covariance(IntPtr message_pointer, int index);

	

	

	// ----------- end member AccelWithCovariance.covariance ---------------
	

	// ----------- end of message AccelWithCovariance ------------------------------
	

	

	// ----------- begin message LaserEcho -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserEcho_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserEcho_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserEcho_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserEcho_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserEcho_get_pointer (IntPtr message);



	

	

	// ----------- begin member LaserEcho.echoes -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_LaserEcho_get_array_member_echoes(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserEcho_set_array_member_echoes(IntPtr message_pointer, int index, float value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserEcho_get_array_pointer_echoes(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_LaserEcho_get_size_echoes(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_LaserEcho_resize_echoes(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LaserEcho_get_array_member_pointer_echoes(IntPtr message_pointer, int index);

	

	

	// ----------- end member LaserEcho.echoes ---------------
	

	// ----------- end of message LaserEcho ------------------------------
	

	

	// ----------- begin message PointField -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointField_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PointField_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointField_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointField_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointField_get_pointer (IntPtr message);



	

	

	// ----------- begin member PointField.count -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_PointField_get_count (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_PointField_set_count (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointField_get_pointer_count (IntPtr message);

	

	

	// ----------- end member PointField.count ---------------
	

	

	// ----------- begin member PointField.FLOAT64 -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_PointField_FLOAT64;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_PointField_get_FLOAT64 ();

	
	

	

	// ----------- end member PointField.FLOAT64 ---------------
	

	

	// ----------- begin member PointField.datatype -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_PointField_get_datatype (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_PointField_set_datatype (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointField_get_pointer_datatype (IntPtr message);

	

	

	// ----------- end member PointField.datatype ---------------
	

	

	// ----------- begin member PointField.UINT8 -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_PointField_UINT8;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_PointField_get_UINT8 ();

	
	

	

	// ----------- end member PointField.UINT8 ---------------
	

	

	// ----------- begin member PointField.INT32 -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_PointField_INT32;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_PointField_get_INT32 ();

	
	

	

	// ----------- end member PointField.INT32 ---------------
	

	

	// ----------- begin member PointField.name -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointField_get_pointer_name (IntPtr message);

	

	

	// ----------- end member PointField.name ---------------
	

	

	// ----------- begin member PointField.INT8 -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_PointField_INT8;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_PointField_get_INT8 ();

	
	

	

	// ----------- end member PointField.INT8 ---------------
	

	

	// ----------- begin member PointField.FLOAT32 -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_PointField_FLOAT32;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_PointField_get_FLOAT32 ();

	
	

	

	// ----------- end member PointField.FLOAT32 ---------------
	

	

	// ----------- begin member PointField.UINT16 -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_PointField_UINT16;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_PointField_get_UINT16 ();

	
	

	

	// ----------- end member PointField.UINT16 ---------------
	

	

	// ----------- begin member PointField.UINT32 -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_PointField_UINT32;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_PointField_get_UINT32 ();

	
	

	

	// ----------- end member PointField.UINT32 ---------------
	

	

	// ----------- begin member PointField.offset -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_PointField_get_offset (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_PointField_set_offset (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PointField_get_pointer_offset (IntPtr message);

	

	

	// ----------- end member PointField.offset ---------------
	

	

	// ----------- begin member PointField.INT16 -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_PointField_INT16;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_PointField_get_INT16 ();

	
	

	

	// ----------- end member PointField.INT16 ---------------
	

	// ----------- end of message PointField ------------------------------
	

	

	// ----------- begin message SyncPoint -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_SyncPoint_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_SyncPoint_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_SyncPoint_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_SyncPoint_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_SyncPoint_get_pointer (IntPtr message);



	

	

	// ----------- begin member SyncPoint.marker_id -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_SyncPoint_get_marker_id (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_SyncPoint_set_marker_id (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_SyncPoint_get_pointer_marker_id (IntPtr message);

	

	

	// ----------- end member SyncPoint.marker_id ---------------
	

	

	// ----------- begin member SyncPoint.sync_id -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_SyncPoint_get_pointer_sync_id (IntPtr message);

	

	

	// ----------- end member SyncPoint.sync_id ---------------
	

	

	// ----------- begin member SyncPoint.description -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_SyncPoint_get_pointer_description (IntPtr message);

	

	

	// ----------- end member SyncPoint.description ---------------
	

	

	// ----------- begin member SyncPoint.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_SyncPoint_get_pointer_header (IntPtr message);

	

	

	// ----------- end member SyncPoint.header ---------------
	

	// ----------- end of message SyncPoint ------------------------------
	

	

	// ----------- begin message TwistWithCovariance -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovariance_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_TwistWithCovariance_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovariance_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovariance_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovariance_get_pointer (IntPtr message);



	

	

	// ----------- begin member TwistWithCovariance.twist -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovariance_get_pointer_twist (IntPtr message);

	

	

	// ----------- end member TwistWithCovariance.twist ---------------
	

	

	// ----------- begin member TwistWithCovariance.covariance -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_TwistWithCovariance_get_array_member_covariance(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_TwistWithCovariance_set_array_member_covariance(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovariance_get_array_pointer_covariance(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_TwistWithCovariance_get_size_covariance(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovariance_get_array_member_pointer_covariance(IntPtr message_pointer, int index);

	

	

	// ----------- end member TwistWithCovariance.covariance ---------------
	

	// ----------- end of message TwistWithCovariance ------------------------------
	

	

	// ----------- begin message Range -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Range_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Range_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Range_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Range_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Range_get_pointer (IntPtr message);



	

	

	// ----------- begin member Range.max_range -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Range_get_max_range (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Range_set_max_range (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Range_get_pointer_max_range (IntPtr message);

	

	

	// ----------- end member Range.max_range ---------------
	

	

	// ----------- begin member Range.radiation_type -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_Range_get_radiation_type (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Range_set_radiation_type (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Range_get_pointer_radiation_type (IntPtr message);

	

	

	// ----------- end member Range.radiation_type ---------------
	

	

	// ----------- begin member Range.field_of_view -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Range_get_field_of_view (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Range_set_field_of_view (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Range_get_pointer_field_of_view (IntPtr message);

	

	

	// ----------- end member Range.field_of_view ---------------
	

	

	// ----------- begin member Range.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Range_get_pointer_header (IntPtr message);

	

	

	// ----------- end member Range.header ---------------
	

	

	// ----------- begin member Range.ULTRASOUND -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_Range_ULTRASOUND;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_Range_get_ULTRASOUND ();

	
	

	

	// ----------- end member Range.ULTRASOUND ---------------
	

	

	// ----------- begin member Range.range -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Range_get_range (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Range_set_range (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Range_get_pointer_range (IntPtr message);

	

	

	// ----------- end member Range.range ---------------
	

	

	// ----------- begin member Range.min_range -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Range_get_min_range (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Range_set_min_range (IntPtr message, float value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Range_get_pointer_min_range (IntPtr message);

	

	

	// ----------- end member Range.min_range ---------------
	

	

	// ----------- begin member Range.INFRARED -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_Range_INFRARED;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_Range_get_INFRARED ();

	
	

	

	// ----------- end member Range.INFRARED ---------------
	

	// ----------- end of message Range ------------------------------
	

	

	// ----------- begin message PoseWithCovarianceStamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovarianceStamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_PoseWithCovarianceStamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovarianceStamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovarianceStamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovarianceStamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member PoseWithCovarianceStamped.pose -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovarianceStamped_get_pointer_pose (IntPtr message);

	

	

	// ----------- end member PoseWithCovarianceStamped.pose ---------------
	

	

	// ----------- begin member PoseWithCovarianceStamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_PoseWithCovarianceStamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member PoseWithCovarianceStamped.header ---------------
	

	// ----------- end of message PoseWithCovarianceStamped ------------------------------
	

	

	// ----------- begin message Duration -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Duration_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Duration_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Duration_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Duration_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Duration_get_pointer (IntPtr message);



	

	

	// ----------- begin member Duration.data -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Duration_get_pointer_data (IntPtr message);

	

	

	// ----------- end member Duration.data ---------------
	

	// ----------- end of message Duration ------------------------------
	

	

	// ----------- begin message UInt32 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt32_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt32_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt32_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt32_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt32_get_pointer (IntPtr message);



	

	

	// ----------- begin member UInt32.data -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_UInt32_get_data (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt32_set_data (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt32_get_pointer_data (IntPtr message);

	

	

	// ----------- end member UInt32.data ---------------
	

	// ----------- end of message UInt32 ------------------------------
	

	

	// ----------- begin message TwistWithCovarianceStamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovarianceStamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_TwistWithCovarianceStamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovarianceStamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovarianceStamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovarianceStamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member TwistWithCovarianceStamped.twist -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovarianceStamped_get_pointer_twist (IntPtr message);

	

	

	// ----------- end member TwistWithCovarianceStamped.twist ---------------
	

	

	// ----------- begin member TwistWithCovarianceStamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TwistWithCovarianceStamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member TwistWithCovarianceStamped.header ---------------
	

	// ----------- end of message TwistWithCovarianceStamped ------------------------------
	

	

	// ----------- begin message RegionOfInterest -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RegionOfInterest_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_RegionOfInterest_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RegionOfInterest_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RegionOfInterest_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RegionOfInterest_get_pointer (IntPtr message);



	

	

	// ----------- begin member RegionOfInterest.do_rectify -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_RegionOfInterest_get_do_rectify (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_RegionOfInterest_set_do_rectify (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RegionOfInterest_get_pointer_do_rectify (IntPtr message);

	

	

	// ----------- end member RegionOfInterest.do_rectify ---------------
	

	

	// ----------- begin member RegionOfInterest.y_offset -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_RegionOfInterest_get_y_offset (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_RegionOfInterest_set_y_offset (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RegionOfInterest_get_pointer_y_offset (IntPtr message);

	

	

	// ----------- end member RegionOfInterest.y_offset ---------------
	

	

	// ----------- begin member RegionOfInterest.x_offset -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_RegionOfInterest_get_x_offset (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_RegionOfInterest_set_x_offset (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RegionOfInterest_get_pointer_x_offset (IntPtr message);

	

	

	// ----------- end member RegionOfInterest.x_offset ---------------
	

	

	// ----------- begin member RegionOfInterest.height -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_RegionOfInterest_get_height (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_RegionOfInterest_set_height (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RegionOfInterest_get_pointer_height (IntPtr message);

	

	

	// ----------- end member RegionOfInterest.height ---------------
	

	

	// ----------- begin member RegionOfInterest.width -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_RegionOfInterest_get_width (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_RegionOfInterest_set_width (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RegionOfInterest_get_pointer_width (IntPtr message);

	

	

	// ----------- end member RegionOfInterest.width ---------------
	

	// ----------- end of message RegionOfInterest ------------------------------
	

	

	// ----------- begin message UInt8 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt8_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt8_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt8_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt8_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt8_get_pointer (IntPtr message);



	

	

	// ----------- begin member UInt8.data -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_UInt8_get_data (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt8_set_data (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt8_get_pointer_data (IntPtr message);

	

	

	// ----------- end member UInt8.data ---------------
	

	// ----------- end of message UInt8 ------------------------------
	

	

	// ----------- begin message STT -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_STT_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_STT_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_STT_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_STT_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_STT_get_pointer (IntPtr message);



	

	

	// ----------- begin member STT.intermediate -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_STT_get_intermediate (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_STT_set_intermediate (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_STT_get_pointer_intermediate (IntPtr message);

	

	

	// ----------- end member STT.intermediate ---------------
	

	

	// ----------- begin member STT.stability -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_STT_get_stability (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_STT_set_stability (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_STT_get_pointer_stability (IntPtr message);

	

	

	// ----------- end member STT.stability ---------------
	

	

	// ----------- begin member STT.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_STT_get_pointer_header (IntPtr message);

	

	

	// ----------- end member STT.header ---------------
	

	

	// ----------- begin member STT.text -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_STT_get_pointer_text (IntPtr message);

	

	

	// ----------- end member STT.text ---------------
	

	

	// ----------- begin member STT.confidence -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_STT_get_confidence (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_STT_set_confidence (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_STT_get_pointer_confidence (IntPtr message);

	

	

	// ----------- end member STT.confidence ---------------
	

	// ----------- end of message STT ------------------------------
	

	

	// ----------- begin message NavSatFix -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatFix_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_NavSatFix_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatFix_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatFix_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatFix_get_pointer (IntPtr message);



	

	

	// ----------- begin member NavSatFix.status -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatFix_get_pointer_status (IntPtr message);

	

	

	// ----------- end member NavSatFix.status ---------------
	

	

	// ----------- begin member NavSatFix.position_covariance -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_NavSatFix_get_array_member_position_covariance(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_NavSatFix_set_array_member_position_covariance(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatFix_get_array_pointer_position_covariance(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_NavSatFix_get_size_position_covariance(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatFix_get_array_member_pointer_position_covariance(IntPtr message_pointer, int index);

	

	

	// ----------- end member NavSatFix.position_covariance ---------------
	

	

	// ----------- begin member NavSatFix.COVARIANCE_TYPE_UNKNOWN -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_NavSatFix_COVARIANCE_TYPE_UNKNOWN;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_NavSatFix_get_COVARIANCE_TYPE_UNKNOWN ();

	
	

	

	// ----------- end member NavSatFix.COVARIANCE_TYPE_UNKNOWN ---------------
	

	

	// ----------- begin member NavSatFix.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatFix_get_pointer_header (IntPtr message);

	

	

	// ----------- end member NavSatFix.header ---------------
	

	

	// ----------- begin member NavSatFix.latitude -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_NavSatFix_get_latitude (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_NavSatFix_set_latitude (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatFix_get_pointer_latitude (IntPtr message);

	

	

	// ----------- end member NavSatFix.latitude ---------------
	

	

	// ----------- begin member NavSatFix.COVARIANCE_TYPE_APPROXIMATED -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_NavSatFix_COVARIANCE_TYPE_APPROXIMATED;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_NavSatFix_get_COVARIANCE_TYPE_APPROXIMATED ();

	
	

	

	// ----------- end member NavSatFix.COVARIANCE_TYPE_APPROXIMATED ---------------
	

	

	// ----------- begin member NavSatFix.position_covariance_type -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_NavSatFix_get_position_covariance_type (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_NavSatFix_set_position_covariance_type (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatFix_get_pointer_position_covariance_type (IntPtr message);

	

	

	// ----------- end member NavSatFix.position_covariance_type ---------------
	

	

	// ----------- begin member NavSatFix.COVARIANCE_TYPE_DIAGONAL_KNOWN -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_NavSatFix_COVARIANCE_TYPE_DIAGONAL_KNOWN;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_NavSatFix_get_COVARIANCE_TYPE_DIAGONAL_KNOWN ();

	
	

	

	// ----------- end member NavSatFix.COVARIANCE_TYPE_DIAGONAL_KNOWN ---------------
	

	

	// ----------- begin member NavSatFix.longitude -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_NavSatFix_get_longitude (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_NavSatFix_set_longitude (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatFix_get_pointer_longitude (IntPtr message);

	

	

	// ----------- end member NavSatFix.longitude ---------------
	

	

	// ----------- begin member NavSatFix.COVARIANCE_TYPE_KNOWN -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_NavSatFix_COVARIANCE_TYPE_KNOWN;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_NavSatFix_get_COVARIANCE_TYPE_KNOWN ();

	
	

	

	// ----------- end member NavSatFix.COVARIANCE_TYPE_KNOWN ---------------
	

	

	// ----------- begin member NavSatFix.altitude -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_NavSatFix_get_altitude (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_NavSatFix_set_altitude (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_NavSatFix_get_pointer_altitude (IntPtr message);

	

	

	// ----------- end member NavSatFix.altitude ---------------
	

	// ----------- end of message NavSatFix ------------------------------
	

	

	// ----------- begin message UInt16 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt16_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt16_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt16_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt16_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt16_get_pointer (IntPtr message);



	

	

	// ----------- begin member UInt16.data -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint16_t cs_ros_message_UInt16_get_data (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt16_set_data (IntPtr message, uint16_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt16_get_pointer_data (IntPtr message);

	

	

	// ----------- end member UInt16.data ---------------
	

	// ----------- end of message UInt16 ------------------------------
	

	

	// ----------- begin message Colour -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Colour_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Colour_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Colour_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Colour_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Colour_get_pointer (IntPtr message);



	

	

	// ----------- begin member Colour.left -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_Colour_get_left (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Colour_set_left (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Colour_get_pointer_left (IntPtr message);

	

	

	// ----------- end member Colour.left ---------------
	

	

	// ----------- begin member Colour.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Colour_get_pointer_header (IntPtr message);

	

	

	// ----------- end member Colour.header ---------------
	

	

	// ----------- begin member Colour.green -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Colour_get_green (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Colour_set_green (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Colour_get_pointer_green (IntPtr message);

	

	

	// ----------- end member Colour.green ---------------
	

	

	// ----------- begin member Colour.blue -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Colour_get_blue (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Colour_set_blue (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Colour_get_pointer_blue (IntPtr message);

	

	

	// ----------- end member Colour.blue ---------------
	

	

	// ----------- begin member Colour.red -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Colour_get_red (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Colour_set_red (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Colour_get_pointer_red (IntPtr message);

	

	

	// ----------- end member Colour.red ---------------
	

	// ----------- end of message Colour ------------------------------
	

	

	// ----------- begin message Bool -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Bool_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Bool_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Bool_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Bool_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Bool_get_pointer (IntPtr message);



	

	

	// ----------- begin member Bool.data -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_Bool_get_data (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Bool_set_data (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Bool_get_pointer_data (IntPtr message);

	

	

	// ----------- end member Bool.data ---------------
	

	// ----------- end of message Bool ------------------------------
	

	

	// ----------- begin message MultiArrayDimension -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayDimension_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiArrayDimension_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayDimension_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayDimension_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayDimension_get_pointer (IntPtr message);



	

	

	// ----------- begin member MultiArrayDimension.stride -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_MultiArrayDimension_get_stride (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiArrayDimension_set_stride (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayDimension_get_pointer_stride (IntPtr message);

	

	

	// ----------- end member MultiArrayDimension.stride ---------------
	

	

	// ----------- begin member MultiArrayDimension.size -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_MultiArrayDimension_get_size (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_MultiArrayDimension_set_size (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayDimension_get_pointer_size (IntPtr message);

	

	

	// ----------- end member MultiArrayDimension.size ---------------
	

	

	// ----------- begin member MultiArrayDimension.label -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MultiArrayDimension_get_pointer_label (IntPtr message);

	

	

	// ----------- end member MultiArrayDimension.label ---------------
	

	// ----------- end of message MultiArrayDimension ------------------------------
	

	

	// ----------- begin message Vector3 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Vector3_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3_get_pointer (IntPtr message);



	

	

	// ----------- begin member Vector3.z -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Vector3_get_z (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Vector3_set_z (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3_get_pointer_z (IntPtr message);

	

	

	// ----------- end member Vector3.z ---------------
	

	

	// ----------- begin member Vector3.y -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Vector3_get_y (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Vector3_set_y (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3_get_pointer_y (IntPtr message);

	

	

	// ----------- end member Vector3.y ---------------
	

	

	// ----------- begin member Vector3.x -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Vector3_get_x (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Vector3_set_x (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Vector3_get_pointer_x (IntPtr message);

	

	

	// ----------- end member Vector3.x ---------------
	

	// ----------- end of message Vector3 ------------------------------
	

	

	// ----------- begin message Int16MultiArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int16MultiArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int16MultiArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int16MultiArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int16MultiArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int16MultiArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member Int16MultiArray.layout -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int16MultiArray_get_pointer_layout (IntPtr message);

	

	

	// ----------- end member Int16MultiArray.layout ---------------
	

	

	// ----------- begin member Int16MultiArray.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static int16_t cs_ros_message_Int16MultiArray_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int16MultiArray_set_array_member_data(IntPtr message_pointer, int index, int16_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int16MultiArray_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Int16MultiArray_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int16MultiArray_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int16MultiArray_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member Int16MultiArray.data ---------------
	

	// ----------- end of message Int16MultiArray ------------------------------
	

	

	// ----------- begin message Quaternion -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Quaternion_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Quaternion_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Quaternion_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Quaternion_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Quaternion_get_pointer (IntPtr message);



	

	

	// ----------- begin member Quaternion.z -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Quaternion_get_z (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Quaternion_set_z (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Quaternion_get_pointer_z (IntPtr message);

	

	

	// ----------- end member Quaternion.z ---------------
	

	

	// ----------- begin member Quaternion.y -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Quaternion_get_y (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Quaternion_set_y (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Quaternion_get_pointer_y (IntPtr message);

	

	

	// ----------- end member Quaternion.y ---------------
	

	

	// ----------- begin member Quaternion.x -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Quaternion_get_x (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Quaternion_set_x (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Quaternion_get_pointer_x (IntPtr message);

	

	

	// ----------- end member Quaternion.x ---------------
	

	

	// ----------- begin member Quaternion.w -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Quaternion_get_w (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Quaternion_set_w (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Quaternion_get_pointer_w (IntPtr message);

	

	

	// ----------- end member Quaternion.w ---------------
	

	// ----------- end of message Quaternion ------------------------------
	

	

	// ----------- begin message UInt64 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt64_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt64_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt64_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt64_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt64_get_pointer (IntPtr message);



	

	

	// ----------- begin member UInt64.data -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint64_t cs_ros_message_UInt64_get_data (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt64_set_data (IntPtr message, uint64_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt64_get_pointer_data (IntPtr message);

	

	

	// ----------- end member UInt64.data ---------------
	

	// ----------- end of message UInt64 ------------------------------
	

	

	// ----------- begin message UInt64MultiArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt64MultiArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt64MultiArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt64MultiArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt64MultiArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt64MultiArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member UInt64MultiArray.layout -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt64MultiArray_get_pointer_layout (IntPtr message);

	

	

	// ----------- end member UInt64MultiArray.layout ---------------
	

	

	// ----------- begin member UInt64MultiArray.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static uint64_t cs_ros_message_UInt64MultiArray_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt64MultiArray_set_array_member_data(IntPtr message_pointer, int index, uint64_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt64MultiArray_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_UInt64MultiArray_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt64MultiArray_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt64MultiArray_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member UInt64MultiArray.data ---------------
	

	// ----------- end of message UInt64MultiArray ------------------------------
	

	

	// ----------- begin message LogEvent -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LogEvent_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_LogEvent_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LogEvent_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LogEvent_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LogEvent_get_pointer (IntPtr message);



	

	

	// ----------- begin member LogEvent.description -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LogEvent_get_pointer_description (IntPtr message);

	

	

	// ----------- end member LogEvent.description ---------------
	

	

	// ----------- begin member LogEvent.event_type -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_LogEvent_get_event_type (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_LogEvent_set_event_type (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LogEvent_get_pointer_event_type (IntPtr message);

	

	

	// ----------- end member LogEvent.event_type ---------------
	

	

	// ----------- begin member LogEvent.INSTANT -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_LogEvent_INSTANT;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_LogEvent_get_INSTANT ();

	
	

	

	// ----------- end member LogEvent.INSTANT ---------------
	

	

	// ----------- begin member LogEvent.END -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_LogEvent_END;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_LogEvent_get_END ();

	
	

	

	// ----------- end member LogEvent.END ---------------
	

	

	// ----------- begin member LogEvent.BEGIN -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint32_t CS_ROS_MESSAGE_LogEvent_BEGIN;

	[DllImport("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_LogEvent_get_BEGIN ();

	
	

	

	// ----------- end member LogEvent.BEGIN ---------------
	

	

	// ----------- begin member LogEvent.name -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LogEvent_get_pointer_name (IntPtr message);

	

	

	// ----------- end member LogEvent.name ---------------
	

	

	// ----------- begin member LogEvent.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_LogEvent_get_pointer_header (IntPtr message);

	

	

	// ----------- end member LogEvent.header ---------------
	

	// ----------- end of message LogEvent ------------------------------
	

	

	// ----------- begin message Float32MultiArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float32MultiArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Float32MultiArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float32MultiArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float32MultiArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float32MultiArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member Float32MultiArray.layout -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float32MultiArray_get_pointer_layout (IntPtr message);

	

	

	// ----------- end member Float32MultiArray.layout ---------------
	

	

	// ----------- begin member Float32MultiArray.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static float cs_ros_message_Float32MultiArray_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Float32MultiArray_set_array_member_data(IntPtr message_pointer, int index, float value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float32MultiArray_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Float32MultiArray_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Float32MultiArray_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float32MultiArray_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member Float32MultiArray.data ---------------
	

	// ----------- end of message Float32MultiArray ------------------------------
	

	

	// ----------- begin message EmotionAction -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EmotionAction_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_EmotionAction_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EmotionAction_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EmotionAction_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EmotionAction_get_pointer (IntPtr message);



	

	

	// ----------- begin member EmotionAction.emotion_action -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_EmotionAction_get_emotion_action (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_EmotionAction_set_emotion_action (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EmotionAction_get_pointer_emotion_action (IntPtr message);

	

	

	// ----------- end member EmotionAction.emotion_action ---------------
	

	

	// ----------- begin member EmotionAction.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EmotionAction_get_pointer_header (IntPtr message);

	

	

	// ----------- end member EmotionAction.header ---------------
	

	

	// ----------- begin member EmotionAction.action_time -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_EmotionAction_get_pointer_action_time (IntPtr message);

	

	

	// ----------- end member EmotionAction.action_time ---------------
	

	// ----------- end of message EmotionAction ------------------------------
	

	

	// ----------- begin message UInt8MultiArray -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt8MultiArray_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt8MultiArray_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt8MultiArray_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt8MultiArray_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt8MultiArray_get_pointer (IntPtr message);



	

	

	// ----------- begin member UInt8MultiArray.layout -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt8MultiArray_get_pointer_layout (IntPtr message);

	

	

	// ----------- end member UInt8MultiArray.layout ---------------
	

	

	// ----------- begin member UInt8MultiArray.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_UInt8MultiArray_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt8MultiArray_set_array_member_data(IntPtr message_pointer, int index, uint8_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt8MultiArray_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_UInt8MultiArray_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_UInt8MultiArray_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_UInt8MultiArray_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member UInt8MultiArray.data ---------------
	

	// ----------- end of message UInt8MultiArray ------------------------------
	

	

	// ----------- begin message FluidPressure -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FluidPressure_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_FluidPressure_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FluidPressure_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FluidPressure_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FluidPressure_get_pointer (IntPtr message);



	

	

	// ----------- begin member FluidPressure.fluid_pressure -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_FluidPressure_get_fluid_pressure (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_FluidPressure_set_fluid_pressure (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FluidPressure_get_pointer_fluid_pressure (IntPtr message);

	

	

	// ----------- end member FluidPressure.fluid_pressure ---------------
	

	

	// ----------- begin member FluidPressure.variance -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_FluidPressure_get_variance (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_FluidPressure_set_variance (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FluidPressure_get_pointer_variance (IntPtr message);

	

	

	// ----------- end member FluidPressure.variance ---------------
	

	

	// ----------- begin member FluidPressure.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_FluidPressure_get_pointer_header (IntPtr message);

	

	

	// ----------- end member FluidPressure.header ---------------
	

	// ----------- end of message FluidPressure ------------------------------
	

	

	// ----------- begin message TommyGameStart -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TommyGameStart_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_TommyGameStart_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TommyGameStart_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TommyGameStart_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TommyGameStart_get_pointer (IntPtr message);



	

	

	// ----------- begin member TommyGameStart.TOMMY -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_TommyGameStart_TOMMY;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_TommyGameStart_get_TOMMY ();

	
	

	

	// ----------- end member TommyGameStart.TOMMY ---------------
	

	

	// ----------- begin member TommyGameStart.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TommyGameStart_get_pointer_header (IntPtr message);

	

	

	// ----------- end member TommyGameStart.header ---------------
	

	

	// ----------- begin member TommyGameStart.SQUIGGLES -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_TommyGameStart_SQUIGGLES;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_TommyGameStart_get_SQUIGGLES ();

	
	

	

	// ----------- end member TommyGameStart.SQUIGGLES ---------------
	

	

	// ----------- begin member TommyGameStart.SNAPPY -------------

	

	

	//[DllImport("cs_ros_bridge")]
	//public extern static uint8_t CS_ROS_MESSAGE_TommyGameStart_SNAPPY;

	[DllImport("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_TommyGameStart_get_SNAPPY ();

	
	

	

	// ----------- end member TommyGameStart.SNAPPY ---------------
	

	

	// ----------- begin member TommyGameStart.game_type -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_TommyGameStart_get_game_type (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_TommyGameStart_set_game_type (IntPtr message, uint8_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TommyGameStart_get_pointer_game_type (IntPtr message);

	

	

	// ----------- end member TommyGameStart.game_type ---------------
	

	// ----------- end of message TommyGameStart ------------------------------
	

	

	// ----------- begin message Header -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Header_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Header_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Header_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Header_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Header_get_pointer (IntPtr message);



	

	

	// ----------- begin member Header.stamp -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Header_get_pointer_stamp (IntPtr message);

	

	

	// ----------- end member Header.stamp ---------------
	

	

	// ----------- begin member Header.frame_id -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Header_get_pointer_frame_id (IntPtr message);

	

	

	// ----------- end member Header.frame_id ---------------
	

	

	// ----------- begin member Header.seq -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_Header_get_seq (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Header_set_seq (IntPtr message, uint32_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Header_get_pointer_seq (IntPtr message);

	

	

	// ----------- end member Header.seq ---------------
	

	// ----------- end of message Header ------------------------------
	

	

	// ----------- begin message InstantAction -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_InstantAction_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_InstantAction_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_InstantAction_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_InstantAction_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_InstantAction_get_pointer (IntPtr message);



	

	

	// ----------- begin member InstantAction.start -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_InstantAction_get_pointer_start (IntPtr message);

	

	

	// ----------- end member InstantAction.start ---------------
	

	

	// ----------- begin member InstantAction.ref -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_InstantAction_get_pointer_ref (IntPtr message);

	

	

	// ----------- end member InstantAction.ref ---------------
	

	// ----------- end of message InstantAction ------------------------------
	

	

	// ----------- begin message TransformStamped -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransformStamped_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_TransformStamped_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransformStamped_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransformStamped_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransformStamped_get_pointer (IntPtr message);



	

	

	// ----------- begin member TransformStamped.child_frame_id -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransformStamped_get_pointer_child_frame_id (IntPtr message);

	

	

	// ----------- end member TransformStamped.child_frame_id ---------------
	

	

	// ----------- begin member TransformStamped.transform -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransformStamped_get_pointer_transform (IntPtr message);

	

	

	// ----------- end member TransformStamped.transform ---------------
	

	

	// ----------- begin member TransformStamped.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_TransformStamped_get_pointer_header (IntPtr message);

	

	

	// ----------- end member TransformStamped.header ---------------
	

	// ----------- end of message TransformStamped ------------------------------
	

	

	// ----------- begin message Int64 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int64_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Int64_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int64_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int64_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int64_get_pointer (IntPtr message);



	

	

	// ----------- begin member Int64.data -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static int64_t cs_ros_message_Int64_get_data (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Int64_set_data (IntPtr message, int64_t value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Int64_get_pointer_data (IntPtr message);

	

	

	// ----------- end member Int64.data ---------------
	

	// ----------- end of message Int64 ------------------------------
	

	

	// ----------- begin message RelativeHumidity -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RelativeHumidity_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_RelativeHumidity_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RelativeHumidity_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RelativeHumidity_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RelativeHumidity_get_pointer (IntPtr message);



	

	

	// ----------- begin member RelativeHumidity.variance -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_RelativeHumidity_get_variance (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_RelativeHumidity_set_variance (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RelativeHumidity_get_pointer_variance (IntPtr message);

	

	

	// ----------- end member RelativeHumidity.variance ---------------
	

	

	// ----------- begin member RelativeHumidity.relative_humidity -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_RelativeHumidity_get_relative_humidity (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_RelativeHumidity_set_relative_humidity (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RelativeHumidity_get_pointer_relative_humidity (IntPtr message);

	

	

	// ----------- end member RelativeHumidity.relative_humidity ---------------
	

	

	// ----------- begin member RelativeHumidity.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_RelativeHumidity_get_pointer_header (IntPtr message);

	

	

	// ----------- end member RelativeHumidity.header ---------------
	

	// ----------- end of message RelativeHumidity ------------------------------
	

	

	// ----------- begin message Illuminance -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Illuminance_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Illuminance_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Illuminance_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Illuminance_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Illuminance_get_pointer (IntPtr message);



	

	

	// ----------- begin member Illuminance.variance -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Illuminance_get_variance (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Illuminance_set_variance (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Illuminance_get_pointer_variance (IntPtr message);

	

	

	// ----------- end member Illuminance.variance ---------------
	

	

	// ----------- begin member Illuminance.illuminance -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Illuminance_get_illuminance (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Illuminance_set_illuminance (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Illuminance_get_pointer_illuminance (IntPtr message);

	

	

	// ----------- end member Illuminance.illuminance ---------------
	

	

	// ----------- begin member Illuminance.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Illuminance_get_pointer_header (IntPtr message);

	

	

	// ----------- end member Illuminance.header ---------------
	

	// ----------- end of message Illuminance ------------------------------
	

	

	// ----------- begin message Time -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Time_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Time_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Time_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Time_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Time_get_pointer (IntPtr message);



	

	

	// ----------- begin member Time.data -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Time_get_pointer_data (IntPtr message);

	

	

	// ----------- end member Time.data ---------------
	

	// ----------- end of message Time ------------------------------
	

	

	// ----------- begin message Empty -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Empty_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Empty_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Empty_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Empty_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Empty_get_pointer (IntPtr message);



	

	// ----------- end of message Empty ------------------------------
	

	

	// ----------- begin message Wrench -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Wrench_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Wrench_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Wrench_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Wrench_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Wrench_get_pointer (IntPtr message);



	

	

	// ----------- begin member Wrench.torque -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Wrench_get_pointer_torque (IntPtr message);

	

	

	// ----------- end member Wrench.torque ---------------
	

	

	// ----------- begin member Wrench.force -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Wrench_get_pointer_force (IntPtr message);

	

	

	// ----------- end member Wrench.force ---------------
	

	// ----------- end of message Wrench ------------------------------
	

	

	// ----------- begin message Accel -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Accel_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Accel_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Accel_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Accel_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Accel_get_pointer (IntPtr message);



	

	

	// ----------- begin member Accel.angular -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Accel_get_pointer_angular (IntPtr message);

	

	

	// ----------- end member Accel.angular ---------------
	

	

	// ----------- begin member Accel.linear -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Accel_get_pointer_linear (IntPtr message);

	

	

	// ----------- end member Accel.linear ---------------
	

	// ----------- end of message Accel ------------------------------
	

	

	// ----------- begin message MagneticField -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MagneticField_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MagneticField_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MagneticField_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MagneticField_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MagneticField_get_pointer (IntPtr message);



	

	

	// ----------- begin member MagneticField.magnetic_field -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MagneticField_get_pointer_magnetic_field (IntPtr message);

	

	

	// ----------- end member MagneticField.magnetic_field ---------------
	

	

	// ----------- begin member MagneticField.magnetic_field_covariance -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_MagneticField_get_array_member_magnetic_field_covariance(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_MagneticField_set_array_member_magnetic_field_covariance(IntPtr message_pointer, int index, double value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MagneticField_get_array_pointer_magnetic_field_covariance(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_MagneticField_get_size_magnetic_field_covariance(IntPtr message_pointer);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MagneticField_get_array_member_pointer_magnetic_field_covariance(IntPtr message_pointer, int index);

	

	

	// ----------- end member MagneticField.magnetic_field_covariance ---------------
	

	

	// ----------- begin member MagneticField.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_MagneticField_get_pointer_header (IntPtr message);

	

	

	// ----------- end member MagneticField.header ---------------
	

	// ----------- end of message MagneticField ------------------------------
	

	

	// ----------- begin message Float64 -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float64_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_Float64_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float64_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float64_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float64_get_pointer (IntPtr message);



	

	

	// ----------- begin member Float64.data -------------

	

	

	// getter
	[DllImport ("cs_ros_bridge")]
	public extern static double cs_ros_message_Float64_get_data (IntPtr message);

	// setter
	[DllImport("cs_ros_bridge")]
	public extern static void cs_ros_message_Float64_set_data (IntPtr message, double value);

	
	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_Float64_get_pointer_data (IntPtr message);

	

	

	// ----------- end member Float64.data ---------------
	

	// ----------- end of message Float64 ------------------------------
	

	

	// ----------- begin message CompressedImage -------------------------------
	// constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CompressedImage_create ();

	// destructor
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_CompressedImage_destroy (IntPtr message);

	// publisher constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CompressedImage_publisher_ctor(IntPtr node_handle,
	                                                                       IntPtr topic,
	                                                                       int queue_size);
	// subscriber constructor
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CompressedImage_subscriber_ctor(IntPtr node_handle, IntPtr topic,
	                                                                       MessageCallback callback, IntPtr user_data,
	                                                                       int queue_size);
	// get the message payload
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CompressedImage_get_pointer (IntPtr message);



	

	

	// ----------- begin member CompressedImage.data -------------

	

	

	

	

	[DllImport ("cs_ros_bridge")]
	public extern static uint8_t cs_ros_message_CompressedImage_get_array_member_data(IntPtr message_pointer, int index);

	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_CompressedImage_set_array_member_data(IntPtr message_pointer, int index, uint8_t value);

	

	// get pointer (for array)
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CompressedImage_get_array_pointer_data(IntPtr message_pointer);

	// get size of array
	[DllImport ("cs_ros_bridge")]
	public extern static uint32_t cs_ros_message_CompressedImage_get_size_data(IntPtr message_pointer);

	

	// set size of array
	[DllImport ("cs_ros_bridge")]
	public extern static void cs_ros_message_CompressedImage_resize_data(IntPtr message_pointer, uint32_t size);

	

	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CompressedImage_get_array_member_pointer_data(IntPtr message_pointer, int index);

	

	

	// ----------- end member CompressedImage.data ---------------
	

	

	// ----------- begin member CompressedImage.header -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CompressedImage_get_pointer_header (IntPtr message);

	

	

	// ----------- end member CompressedImage.header ---------------
	

	

	// ----------- begin member CompressedImage.format -------------

	

	

	

	// get pointer
	[DllImport ("cs_ros_bridge")]
	public extern static IntPtr cs_ros_message_CompressedImage_get_pointer_format (IntPtr message);

	

	

	// ----------- end member CompressedImage.format ---------------
	

	// ----------- end of message CompressedImage ------------------------------
	

	public static IntPtr node_handle = IntPtr.Zero;
	public static bool is_inited { get; protected set; }
	public static bool is_connected { get; protected set; }
  public static IntPtr background_initialiser = IntPtr.Zero;

  public static bool check_version()
  {
    bool major_match = cs_ros_get_version_major () == CS_ROS_VERSION_MAJOR;
    bool minor_match = cs_ros_get_version_minor () == CS_ROS_VERSION_MINOR;
    bool compile_match = Marshal.PtrToStringAnsi(cs_ros_get_version_compile()) == CS_ROS_VERSION_COMPILE;
    bool version_match = Marshal.PtrToStringAnsi(cs_ros_get_version_var()) == CS_ROS_VERSION_VAR;


    return major_match && minor_match && compile_match && version_match;
  }

  public static string print_version()
  {
    return "ROS.cs {" + CS_ROS_VERSION_MAJOR + ", " + CS_ROS_VERSION_MINOR + ", " +
        CS_ROS_VERSION_COMPILE + ", " + CS_ROS_VERSION_VAR + "}\n" +
      "libcs_ros_bridge.cs {" + cs_ros_get_version_major () + ", " + cs_ros_get_version_minor() + ", " +
      Marshal.PtrToStringAnsi(cs_ros_get_version_compile()) + ", " + Marshal.PtrToStringAnsi(cs_ros_get_version_var()) + "}";
  }

	public static void init(string master_uri, string ip, string node_name)
	{
    //Environment.SetEnvironmentVariable("ROS_MASTER_URI", master_uri);
    //Environment.SetEnvironmentVariable("ROS_IP", ip);

		cs_ros_argument ("__master", master_uri);
		cs_ros_argument ("__ip", ip);
		cs_ros_init (node_name);
		is_inited = true;
	}

  public static void init_bg(string master_uri, string ip, string node_name)
  {
    //Environment.SetEnvironmentVariable("ROS_MASTER_URI", master_uri);
    //Environment.SetEnvironmentVariable("ROS_IP", ip);

    cs_ros_argument ("__master", master_uri);
    cs_ros_argument ("__ip", ip);
    background_initialiser = cs_ros_bgi_create (node_name);
    is_inited = true;
  }

  public static bool init_bg_update()
  {
    if (cs_ros_bgi_check(background_initialiser) == 1)
    {
      ROS.node_handle = cs_ros_bgi_get_node_handle(background_initialiser);
      ROS.is_connected = true;

      cs_ros_bgi_join(background_initialiser);
      cs_ros_bgi_destroy(background_initialiser);

      return true;
    }

    return false;
  }

	public class NodeHandle
	{
		public NodeHandle()
		{
			if (ROS.node_handle.Equals(IntPtr.Zero))
			{
				ROS.node_handle = cs_ros_node_handle_create();
				ROS.is_connected = true;
			}
		}

		~NodeHandle()
		{
			// cs_ros_shutdown (node_handle);
		}

		public static bool check_master()
		{
			return (cs_ros_check_master() == 1);
		}

		public bool spin_once()
		{
			return (cs_ros_spin_once (node_handle) == 1);
		}

		public Subscriber subscribe(string topic, int queue_size,
	                            	MessageCallback message_callback,
		                            SubscriberConstructor subscriber_constructor)
		{
			return new Subscriber(node_handle, topic, queue_size, message_callback, subscriber_constructor);
		}

    public Publisher advertise(string topic, int queue_size,
            PublisherConstructor publisher_constructor)
    {
        return new Publisher(node_handle, topic, queue_size, publisher_constructor);
    }

	}

	public class Subscriber
	{
		public IntPtr subscriber;

		public Subscriber(IntPtr node_handle, string topic, int queue_size,
		                  MessageCallback message_callback,
		                  SubscriberConstructor subscriber_constructor)
		{
			subscriber = cs_ros_subscribe(node_handle, topic, queue_size, message_callback, IntPtr.Zero, subscriber_constructor);
		}

		~Subscriber()
		{
			cs_ros_unsubscribe (subscriber);
		}

	}

  public class Publisher
  {
      public IntPtr publisher;

      public Publisher(IntPtr node_handle, string topic, int queue_size,
                        PublisherConstructor publisher_constructor)
      {
          publisher = cs_ros_advertise(node_handle, topic, queue_size, publisher_constructor);
      }

      ~Publisher()
      {
          cs_ros_unadvertise(publisher);
      }

      public void publish(IntPtr message)
      {
          cs_ros_publish(publisher, message);
      }

  }

	public static IPAddress GetLocalIPAddress ()
	{
		IPHostEntry host;

		host = Dns.GetHostEntry (Dns.GetHostName ());
		foreach (IPAddress ip in host.AddressList) {
			if (ip.AddressFamily == AddressFamily.InterNetwork && ip.ToString().StartsWith("192.168.0")) { // must be on Opie's subnet
				return ip;
			}
		}

		return null;
	}
}
