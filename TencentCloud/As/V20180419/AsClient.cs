/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.As.V20180419
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.As.V20180419.Models;

   public class AsClient : AbstractClient{

       private const string endpoint = "as.tencentcloudapi.com";
       private const string version = "2018-04-19";
       private const string sdkVersion = "SDK_NET_3.0.1103";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（AttachInstances）用于将 CVM 实例添加到伸缩组。
        /// * 仅支持添加处于`RUNNING`（运行中）或`STOPPED`（已关机）状态的 CVM 实例
        /// * 添加的 CVM 实例需要和伸缩组 VPC 网络一致
        /// </summary>
        /// <param name="req"><see cref="AttachInstancesRequest"/></param>
        /// <returns><see cref="AttachInstancesResponse"/></returns>
        public Task<AttachInstancesResponse> AttachInstances(AttachInstancesRequest req)
        {
            return InternalRequestAsync<AttachInstancesResponse>(req, "AttachInstances");
        }

        /// <summary>
        /// 本接口（AttachInstances）用于将 CVM 实例添加到伸缩组。
        /// * 仅支持添加处于`RUNNING`（运行中）或`STOPPED`（已关机）状态的 CVM 实例
        /// * 添加的 CVM 实例需要和伸缩组 VPC 网络一致
        /// </summary>
        /// <param name="req"><see cref="AttachInstancesRequest"/></param>
        /// <returns><see cref="AttachInstancesResponse"/></returns>
        public AttachInstancesResponse AttachInstancesSync(AttachInstancesRequest req)
        {
            return InternalRequestAsync<AttachInstancesResponse>(req, "AttachInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（AttachLoadBalancers）用于将负载均衡器添加到伸缩组。
        /// </summary>
        /// <param name="req"><see cref="AttachLoadBalancersRequest"/></param>
        /// <returns><see cref="AttachLoadBalancersResponse"/></returns>
        public Task<AttachLoadBalancersResponse> AttachLoadBalancers(AttachLoadBalancersRequest req)
        {
            return InternalRequestAsync<AttachLoadBalancersResponse>(req, "AttachLoadBalancers");
        }

        /// <summary>
        /// 此接口（AttachLoadBalancers）用于将负载均衡器添加到伸缩组。
        /// </summary>
        /// <param name="req"><see cref="AttachLoadBalancersRequest"/></param>
        /// <returns><see cref="AttachLoadBalancersResponse"/></returns>
        public AttachLoadBalancersResponse AttachLoadBalancersSync(AttachLoadBalancersRequest req)
        {
            return InternalRequestAsync<AttachLoadBalancersResponse>(req, "AttachLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消伸缩组的实例刷新活动。
        /// * 已刷新/正在刷新的批次不受影响，待刷新批次被取消
        /// * 刷新失败的实例保持备用中状态，需用户手动处理后尝试退出备用中状态或销毁
        /// * 取消后不允许回滚操作，也不支持恢复操作
        /// </summary>
        /// <param name="req"><see cref="CancelInstanceRefreshRequest"/></param>
        /// <returns><see cref="CancelInstanceRefreshResponse"/></returns>
        public Task<CancelInstanceRefreshResponse> CancelInstanceRefresh(CancelInstanceRefreshRequest req)
        {
            return InternalRequestAsync<CancelInstanceRefreshResponse>(req, "CancelInstanceRefresh");
        }

        /// <summary>
        /// 取消伸缩组的实例刷新活动。
        /// * 已刷新/正在刷新的批次不受影响，待刷新批次被取消
        /// * 刷新失败的实例保持备用中状态，需用户手动处理后尝试退出备用中状态或销毁
        /// * 取消后不允许回滚操作，也不支持恢复操作
        /// </summary>
        /// <param name="req"><see cref="CancelInstanceRefreshRequest"/></param>
        /// <returns><see cref="CancelInstanceRefreshResponse"/></returns>
        public CancelInstanceRefreshResponse CancelInstanceRefreshSync(CancelInstanceRefreshRequest req)
        {
            return InternalRequestAsync<CancelInstanceRefreshResponse>(req, "CancelInstanceRefresh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ClearLaunchConfigurationAttributes）用于将启动配置内的特定属性完全清空。
        /// </summary>
        /// <param name="req"><see cref="ClearLaunchConfigurationAttributesRequest"/></param>
        /// <returns><see cref="ClearLaunchConfigurationAttributesResponse"/></returns>
        public Task<ClearLaunchConfigurationAttributesResponse> ClearLaunchConfigurationAttributes(ClearLaunchConfigurationAttributesRequest req)
        {
            return InternalRequestAsync<ClearLaunchConfigurationAttributesResponse>(req, "ClearLaunchConfigurationAttributes");
        }

        /// <summary>
        /// 本接口（ClearLaunchConfigurationAttributes）用于将启动配置内的特定属性完全清空。
        /// </summary>
        /// <param name="req"><see cref="ClearLaunchConfigurationAttributesRequest"/></param>
        /// <returns><see cref="ClearLaunchConfigurationAttributesResponse"/></returns>
        public ClearLaunchConfigurationAttributesResponse ClearLaunchConfigurationAttributesSync(ClearLaunchConfigurationAttributesRequest req)
        {
            return InternalRequestAsync<ClearLaunchConfigurationAttributesResponse>(req, "ClearLaunchConfigurationAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CompleteLifecycleAction）用于完成生命周期动作。
        /// 
        /// * 用户通过调用本接口，指定一个具体的生命周期挂钩的结果（“CONITNUE”或者“ABANDON”）。如果一直不调用本接口，则生命周期挂钩会在超时后按照“DefaultResult”进行处理。
        /// </summary>
        /// <param name="req"><see cref="CompleteLifecycleActionRequest"/></param>
        /// <returns><see cref="CompleteLifecycleActionResponse"/></returns>
        public Task<CompleteLifecycleActionResponse> CompleteLifecycleAction(CompleteLifecycleActionRequest req)
        {
            return InternalRequestAsync<CompleteLifecycleActionResponse>(req, "CompleteLifecycleAction");
        }

        /// <summary>
        /// 本接口（CompleteLifecycleAction）用于完成生命周期动作。
        /// 
        /// * 用户通过调用本接口，指定一个具体的生命周期挂钩的结果（“CONITNUE”或者“ABANDON”）。如果一直不调用本接口，则生命周期挂钩会在超时后按照“DefaultResult”进行处理。
        /// </summary>
        /// <param name="req"><see cref="CompleteLifecycleActionRequest"/></param>
        /// <returns><see cref="CompleteLifecycleActionResponse"/></returns>
        public CompleteLifecycleActionResponse CompleteLifecycleActionSync(CompleteLifecycleActionRequest req)
        {
            return InternalRequestAsync<CompleteLifecycleActionResponse>(req, "CompleteLifecycleAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateAutoScalingGroup）用于创建伸缩组
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalingGroupRequest"/></param>
        /// <returns><see cref="CreateAutoScalingGroupResponse"/></returns>
        public Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroup(CreateAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<CreateAutoScalingGroupResponse>(req, "CreateAutoScalingGroup");
        }

        /// <summary>
        /// 本接口（CreateAutoScalingGroup）用于创建伸缩组
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalingGroupRequest"/></param>
        /// <returns><see cref="CreateAutoScalingGroupResponse"/></returns>
        public CreateAutoScalingGroupResponse CreateAutoScalingGroupSync(CreateAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<CreateAutoScalingGroupResponse>(req, "CreateAutoScalingGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateAutoScalingGroupFromInstance）用于根据实例创建启动配置及伸缩组。
        /// 
        /// 说明：根据按包年包月计费的实例所创建的伸缩组，其扩容的实例为按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalingGroupFromInstanceRequest"/></param>
        /// <returns><see cref="CreateAutoScalingGroupFromInstanceResponse"/></returns>
        public Task<CreateAutoScalingGroupFromInstanceResponse> CreateAutoScalingGroupFromInstance(CreateAutoScalingGroupFromInstanceRequest req)
        {
            return InternalRequestAsync<CreateAutoScalingGroupFromInstanceResponse>(req, "CreateAutoScalingGroupFromInstance");
        }

        /// <summary>
        /// 本接口（CreateAutoScalingGroupFromInstance）用于根据实例创建启动配置及伸缩组。
        /// 
        /// 说明：根据按包年包月计费的实例所创建的伸缩组，其扩容的实例为按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalingGroupFromInstanceRequest"/></param>
        /// <returns><see cref="CreateAutoScalingGroupFromInstanceResponse"/></returns>
        public CreateAutoScalingGroupFromInstanceResponse CreateAutoScalingGroupFromInstanceSync(CreateAutoScalingGroupFromInstanceRequest req)
        {
            return InternalRequestAsync<CreateAutoScalingGroupFromInstanceResponse>(req, "CreateAutoScalingGroupFromInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateLaunchConfiguration）用于创建新的启动配置。
        /// 
        /// * 启动配置，可以通过 `ModifyLaunchConfigurationAttributes` 修改少量字段。如需使用新的启动配置，建议重新创建启动配置。
        /// 
        /// * 每个项目最多只能创建20个启动配置，详见[使用限制](https://cloud.tencent.com/document/product/377/3120)。
        /// </summary>
        /// <param name="req"><see cref="CreateLaunchConfigurationRequest"/></param>
        /// <returns><see cref="CreateLaunchConfigurationResponse"/></returns>
        public Task<CreateLaunchConfigurationResponse> CreateLaunchConfiguration(CreateLaunchConfigurationRequest req)
        {
            return InternalRequestAsync<CreateLaunchConfigurationResponse>(req, "CreateLaunchConfiguration");
        }

        /// <summary>
        /// 本接口（CreateLaunchConfiguration）用于创建新的启动配置。
        /// 
        /// * 启动配置，可以通过 `ModifyLaunchConfigurationAttributes` 修改少量字段。如需使用新的启动配置，建议重新创建启动配置。
        /// 
        /// * 每个项目最多只能创建20个启动配置，详见[使用限制](https://cloud.tencent.com/document/product/377/3120)。
        /// </summary>
        /// <param name="req"><see cref="CreateLaunchConfigurationRequest"/></param>
        /// <returns><see cref="CreateLaunchConfigurationResponse"/></returns>
        public CreateLaunchConfigurationResponse CreateLaunchConfigurationSync(CreateLaunchConfigurationRequest req)
        {
            return InternalRequestAsync<CreateLaunchConfigurationResponse>(req, "CreateLaunchConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateLifecycleHook）用于创建生命周期挂钩。
        /// 
        /// * 您可以为生命周期挂钩配置消息通知或执行自动化助手命令。
        /// 
        /// 如果您配置了通知消息，弹性伸缩会通知您的TDMQ消息队列，通知内容形如：
        /// 
        /// ```
        /// {
        /// 	"Service": "Tencent Cloud Auto Scaling",
        /// 	"Time": "2019-03-14T10:15:11Z",
        /// 	"AppId": "1251783334",
        /// 	"ActivityId": "asa-fznnvrja",
        /// 	"AutoScalingGroupId": "asg-rrrrtttt",
        /// 	"LifecycleHookId": "ash-xxxxyyyy",
        /// 	"LifecycleHookName": "my-hook",
        /// 	"LifecycleActionToken": "3080e1c9-0efe-4dd7-ad3b-90cd6618298f",
        /// 	"InstanceId": "ins-aaaabbbb",
        /// 	"LifecycleTransition": "INSTANCE_LAUNCHING",
        /// 	"NotificationMetadata": ""
        /// }
        /// ```
        /// </summary>
        /// <param name="req"><see cref="CreateLifecycleHookRequest"/></param>
        /// <returns><see cref="CreateLifecycleHookResponse"/></returns>
        public Task<CreateLifecycleHookResponse> CreateLifecycleHook(CreateLifecycleHookRequest req)
        {
            return InternalRequestAsync<CreateLifecycleHookResponse>(req, "CreateLifecycleHook");
        }

        /// <summary>
        /// 本接口（CreateLifecycleHook）用于创建生命周期挂钩。
        /// 
        /// * 您可以为生命周期挂钩配置消息通知或执行自动化助手命令。
        /// 
        /// 如果您配置了通知消息，弹性伸缩会通知您的TDMQ消息队列，通知内容形如：
        /// 
        /// ```
        /// {
        /// 	"Service": "Tencent Cloud Auto Scaling",
        /// 	"Time": "2019-03-14T10:15:11Z",
        /// 	"AppId": "1251783334",
        /// 	"ActivityId": "asa-fznnvrja",
        /// 	"AutoScalingGroupId": "asg-rrrrtttt",
        /// 	"LifecycleHookId": "ash-xxxxyyyy",
        /// 	"LifecycleHookName": "my-hook",
        /// 	"LifecycleActionToken": "3080e1c9-0efe-4dd7-ad3b-90cd6618298f",
        /// 	"InstanceId": "ins-aaaabbbb",
        /// 	"LifecycleTransition": "INSTANCE_LAUNCHING",
        /// 	"NotificationMetadata": ""
        /// }
        /// ```
        /// </summary>
        /// <param name="req"><see cref="CreateLifecycleHookRequest"/></param>
        /// <returns><see cref="CreateLifecycleHookResponse"/></returns>
        public CreateLifecycleHookResponse CreateLifecycleHookSync(CreateLifecycleHookRequest req)
        {
            return InternalRequestAsync<CreateLifecycleHookResponse>(req, "CreateLifecycleHook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateNotificationConfiguration）用于创建通知。
        /// 通知到 CMQ 主题或队列时，消息内容如下：
        /// ```
        /// {
        ///     "Service": "Tencent Cloud Auto Scaling",
        ///     "CreatedTime": "2021-10-11T10:15:11Z", // 活动创建时间
        ///     "AppId": "100000000",
        ///     "ActivityId": "asa-fznnvrja", // 伸缩活动ID
        ///     "AutoScalingGroupId": "asg-pc2oqu2z", // 伸缩组ID
        ///     "ActivityType": "SCALE_OUT",  // 伸缩活动类型
        ///     "StatusCode": "SUCCESSFUL",   // 伸缩活动结果
        ///     "Description": "Activity was launched in response to a difference between desired capacity and actual capacity,
        ///     scale out 1 instance(s).", // 伸缩活动描述
        ///     "StartTime": "2021-10-11T10:15:11Z",  // 活动开始时间
        ///     "EndTime": "2021-10-11T10:15:32Z",    // 活动结束时间
        ///     "DetailedStatusMessageSet": [ // 活动内部错误集合（非空不代表活动失败）
        ///         {
        ///             "Code": "InvalidInstanceType",
        ///             "Zone": "ap-guangzhou-2",
        ///             "InstanceId": "",
        ///             "InstanceChargeType": "POSTPAID_BY_HOUR",
        ///             "SubnetId": "subnet-4t5mgeuu",
        ///             "Message": "The specified instance type `S5.LARGE8` is invalid in `subnet-4t5mgeuu`, `ap-guangzhou-2`.",
        ///             "InstanceType": "S5.LARGE8"
        ///         }
        ///     ]
        /// }
        /// ```
        /// </summary>
        /// <param name="req"><see cref="CreateNotificationConfigurationRequest"/></param>
        /// <returns><see cref="CreateNotificationConfigurationResponse"/></returns>
        public Task<CreateNotificationConfigurationResponse> CreateNotificationConfiguration(CreateNotificationConfigurationRequest req)
        {
            return InternalRequestAsync<CreateNotificationConfigurationResponse>(req, "CreateNotificationConfiguration");
        }

        /// <summary>
        /// 本接口（CreateNotificationConfiguration）用于创建通知。
        /// 通知到 CMQ 主题或队列时，消息内容如下：
        /// ```
        /// {
        ///     "Service": "Tencent Cloud Auto Scaling",
        ///     "CreatedTime": "2021-10-11T10:15:11Z", // 活动创建时间
        ///     "AppId": "100000000",
        ///     "ActivityId": "asa-fznnvrja", // 伸缩活动ID
        ///     "AutoScalingGroupId": "asg-pc2oqu2z", // 伸缩组ID
        ///     "ActivityType": "SCALE_OUT",  // 伸缩活动类型
        ///     "StatusCode": "SUCCESSFUL",   // 伸缩活动结果
        ///     "Description": "Activity was launched in response to a difference between desired capacity and actual capacity,
        ///     scale out 1 instance(s).", // 伸缩活动描述
        ///     "StartTime": "2021-10-11T10:15:11Z",  // 活动开始时间
        ///     "EndTime": "2021-10-11T10:15:32Z",    // 活动结束时间
        ///     "DetailedStatusMessageSet": [ // 活动内部错误集合（非空不代表活动失败）
        ///         {
        ///             "Code": "InvalidInstanceType",
        ///             "Zone": "ap-guangzhou-2",
        ///             "InstanceId": "",
        ///             "InstanceChargeType": "POSTPAID_BY_HOUR",
        ///             "SubnetId": "subnet-4t5mgeuu",
        ///             "Message": "The specified instance type `S5.LARGE8` is invalid in `subnet-4t5mgeuu`, `ap-guangzhou-2`.",
        ///             "InstanceType": "S5.LARGE8"
        ///         }
        ///     ]
        /// }
        /// ```
        /// </summary>
        /// <param name="req"><see cref="CreateNotificationConfigurationRequest"/></param>
        /// <returns><see cref="CreateNotificationConfigurationResponse"/></returns>
        public CreateNotificationConfigurationResponse CreateNotificationConfigurationSync(CreateNotificationConfigurationRequest req)
        {
            return InternalRequestAsync<CreateNotificationConfigurationResponse>(req, "CreateNotificationConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateScalingPolicy）用于创建告警触发策略。
        /// </summary>
        /// <param name="req"><see cref="CreateScalingPolicyRequest"/></param>
        /// <returns><see cref="CreateScalingPolicyResponse"/></returns>
        public Task<CreateScalingPolicyResponse> CreateScalingPolicy(CreateScalingPolicyRequest req)
        {
            return InternalRequestAsync<CreateScalingPolicyResponse>(req, "CreateScalingPolicy");
        }

        /// <summary>
        /// 本接口（CreateScalingPolicy）用于创建告警触发策略。
        /// </summary>
        /// <param name="req"><see cref="CreateScalingPolicyRequest"/></param>
        /// <returns><see cref="CreateScalingPolicyResponse"/></returns>
        public CreateScalingPolicyResponse CreateScalingPolicySync(CreateScalingPolicyRequest req)
        {
            return InternalRequestAsync<CreateScalingPolicyResponse>(req, "CreateScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateScheduledAction）用于创建定时任务。
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledActionRequest"/></param>
        /// <returns><see cref="CreateScheduledActionResponse"/></returns>
        public Task<CreateScheduledActionResponse> CreateScheduledAction(CreateScheduledActionRequest req)
        {
            return InternalRequestAsync<CreateScheduledActionResponse>(req, "CreateScheduledAction");
        }

        /// <summary>
        /// 本接口（CreateScheduledAction）用于创建定时任务。
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledActionRequest"/></param>
        /// <returns><see cref="CreateScheduledActionResponse"/></returns>
        public CreateScheduledActionResponse CreateScheduledActionSync(CreateScheduledActionRequest req)
        {
            return InternalRequestAsync<CreateScheduledActionResponse>(req, "CreateScheduledAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteAutoScalingGroup）用于删除指定伸缩组，删除前提是伸缩组内无运行中（IN_SERVICE）状态的实例且当前未在执行伸缩活动。删除伸缩组后，创建失败（CREATION_FAILED）、中止失败（TERMINATION_FAILED）、解绑失败（DETACH_FAILED）等非运行中状态的实例不会被销毁。
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScalingGroupRequest"/></param>
        /// <returns><see cref="DeleteAutoScalingGroupResponse"/></returns>
        public Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<DeleteAutoScalingGroupResponse>(req, "DeleteAutoScalingGroup");
        }

        /// <summary>
        /// 本接口（DeleteAutoScalingGroup）用于删除指定伸缩组，删除前提是伸缩组内无运行中（IN_SERVICE）状态的实例且当前未在执行伸缩活动。删除伸缩组后，创建失败（CREATION_FAILED）、中止失败（TERMINATION_FAILED）、解绑失败（DETACH_FAILED）等非运行中状态的实例不会被销毁。
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScalingGroupRequest"/></param>
        /// <returns><see cref="DeleteAutoScalingGroupResponse"/></returns>
        public DeleteAutoScalingGroupResponse DeleteAutoScalingGroupSync(DeleteAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<DeleteAutoScalingGroupResponse>(req, "DeleteAutoScalingGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteLaunchConfiguration）用于删除启动配置。
        /// 
        /// * 若启动配置在伸缩组中属于生效状态，则该启动配置不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteLaunchConfigurationRequest"/></param>
        /// <returns><see cref="DeleteLaunchConfigurationResponse"/></returns>
        public Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest req)
        {
            return InternalRequestAsync<DeleteLaunchConfigurationResponse>(req, "DeleteLaunchConfiguration");
        }

        /// <summary>
        /// 本接口（DeleteLaunchConfiguration）用于删除启动配置。
        /// 
        /// * 若启动配置在伸缩组中属于生效状态，则该启动配置不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteLaunchConfigurationRequest"/></param>
        /// <returns><see cref="DeleteLaunchConfigurationResponse"/></returns>
        public DeleteLaunchConfigurationResponse DeleteLaunchConfigurationSync(DeleteLaunchConfigurationRequest req)
        {
            return InternalRequestAsync<DeleteLaunchConfigurationResponse>(req, "DeleteLaunchConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteLifecycleHook）用于删除生命周期挂钩。
        /// </summary>
        /// <param name="req"><see cref="DeleteLifecycleHookRequest"/></param>
        /// <returns><see cref="DeleteLifecycleHookResponse"/></returns>
        public Task<DeleteLifecycleHookResponse> DeleteLifecycleHook(DeleteLifecycleHookRequest req)
        {
            return InternalRequestAsync<DeleteLifecycleHookResponse>(req, "DeleteLifecycleHook");
        }

        /// <summary>
        /// 本接口（DeleteLifecycleHook）用于删除生命周期挂钩。
        /// </summary>
        /// <param name="req"><see cref="DeleteLifecycleHookRequest"/></param>
        /// <returns><see cref="DeleteLifecycleHookResponse"/></returns>
        public DeleteLifecycleHookResponse DeleteLifecycleHookSync(DeleteLifecycleHookRequest req)
        {
            return InternalRequestAsync<DeleteLifecycleHookResponse>(req, "DeleteLifecycleHook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteNotificationConfiguration）用于删除特定的通知。
        /// </summary>
        /// <param name="req"><see cref="DeleteNotificationConfigurationRequest"/></param>
        /// <returns><see cref="DeleteNotificationConfigurationResponse"/></returns>
        public Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest req)
        {
            return InternalRequestAsync<DeleteNotificationConfigurationResponse>(req, "DeleteNotificationConfiguration");
        }

        /// <summary>
        /// 本接口（DeleteNotificationConfiguration）用于删除特定的通知。
        /// </summary>
        /// <param name="req"><see cref="DeleteNotificationConfigurationRequest"/></param>
        /// <returns><see cref="DeleteNotificationConfigurationResponse"/></returns>
        public DeleteNotificationConfigurationResponse DeleteNotificationConfigurationSync(DeleteNotificationConfigurationRequest req)
        {
            return InternalRequestAsync<DeleteNotificationConfigurationResponse>(req, "DeleteNotificationConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteScalingPolicy）用于删除告警触发策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteScalingPolicyResponse"/></returns>
        public Task<DeleteScalingPolicyResponse> DeleteScalingPolicy(DeleteScalingPolicyRequest req)
        {
            return InternalRequestAsync<DeleteScalingPolicyResponse>(req, "DeleteScalingPolicy");
        }

        /// <summary>
        /// 本接口（DeleteScalingPolicy）用于删除告警触发策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteScalingPolicyResponse"/></returns>
        public DeleteScalingPolicyResponse DeleteScalingPolicySync(DeleteScalingPolicyRequest req)
        {
            return InternalRequestAsync<DeleteScalingPolicyResponse>(req, "DeleteScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteScheduledAction）用于删除特定的定时任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledActionRequest"/></param>
        /// <returns><see cref="DeleteScheduledActionResponse"/></returns>
        public Task<DeleteScheduledActionResponse> DeleteScheduledAction(DeleteScheduledActionRequest req)
        {
            return InternalRequestAsync<DeleteScheduledActionResponse>(req, "DeleteScheduledAction");
        }

        /// <summary>
        /// 本接口（DeleteScheduledAction）用于删除特定的定时任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledActionRequest"/></param>
        /// <returns><see cref="DeleteScheduledActionResponse"/></returns>
        public DeleteScheduledActionResponse DeleteScheduledActionSync(DeleteScheduledActionRequest req)
        {
            return InternalRequestAsync<DeleteScheduledActionResponse>(req, "DeleteScheduledAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAccountLimits）用于查询用户账户在弹性伸缩中的资源限制。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountLimitsRequest"/></param>
        /// <returns><see cref="DescribeAccountLimitsResponse"/></returns>
        public Task<DescribeAccountLimitsResponse> DescribeAccountLimits(DescribeAccountLimitsRequest req)
        {
            return InternalRequestAsync<DescribeAccountLimitsResponse>(req, "DescribeAccountLimits");
        }

        /// <summary>
        /// 本接口（DescribeAccountLimits）用于查询用户账户在弹性伸缩中的资源限制。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountLimitsRequest"/></param>
        /// <returns><see cref="DescribeAccountLimitsResponse"/></returns>
        public DescribeAccountLimitsResponse DescribeAccountLimitsSync(DescribeAccountLimitsRequest req)
        {
            return InternalRequestAsync<DescribeAccountLimitsResponse>(req, "DescribeAccountLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAutoScalingActivities）用于查询伸缩组的伸缩活动记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingActivitiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingActivitiesResponse"/></returns>
        public Task<DescribeAutoScalingActivitiesResponse> DescribeAutoScalingActivities(DescribeAutoScalingActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingActivitiesResponse>(req, "DescribeAutoScalingActivities");
        }

        /// <summary>
        /// 本接口（DescribeAutoScalingActivities）用于查询伸缩组的伸缩活动记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingActivitiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingActivitiesResponse"/></returns>
        public DescribeAutoScalingActivitiesResponse DescribeAutoScalingActivitiesSync(DescribeAutoScalingActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingActivitiesResponse>(req, "DescribeAutoScalingActivities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于查询伸缩组配置建议。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingAdvicesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingAdvicesResponse"/></returns>
        public Task<DescribeAutoScalingAdvicesResponse> DescribeAutoScalingAdvices(DescribeAutoScalingAdvicesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingAdvicesResponse>(req, "DescribeAutoScalingAdvices");
        }

        /// <summary>
        /// 此接口用于查询伸缩组配置建议。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingAdvicesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingAdvicesResponse"/></returns>
        public DescribeAutoScalingAdvicesResponse DescribeAutoScalingAdvicesSync(DescribeAutoScalingAdvicesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingAdvicesResponse>(req, "DescribeAutoScalingAdvices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAutoScalingGroupLastActivities）用于查询伸缩组的最新一次伸缩活动记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingGroupLastActivitiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingGroupLastActivitiesResponse"/></returns>
        public Task<DescribeAutoScalingGroupLastActivitiesResponse> DescribeAutoScalingGroupLastActivities(DescribeAutoScalingGroupLastActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingGroupLastActivitiesResponse>(req, "DescribeAutoScalingGroupLastActivities");
        }

        /// <summary>
        /// 本接口（DescribeAutoScalingGroupLastActivities）用于查询伸缩组的最新一次伸缩活动记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingGroupLastActivitiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingGroupLastActivitiesResponse"/></returns>
        public DescribeAutoScalingGroupLastActivitiesResponse DescribeAutoScalingGroupLastActivitiesSync(DescribeAutoScalingGroupLastActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingGroupLastActivitiesResponse>(req, "DescribeAutoScalingGroupLastActivities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAutoScalingGroups）用于查询伸缩组信息。
        /// 
        /// * 可以根据伸缩组ID、伸缩组名称或者启动配置ID等信息来查询伸缩组的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的伸缩组。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingGroupsRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingGroupsResponse"/></returns>
        public Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingGroupsResponse>(req, "DescribeAutoScalingGroups");
        }

        /// <summary>
        /// 本接口（DescribeAutoScalingGroups）用于查询伸缩组信息。
        /// 
        /// * 可以根据伸缩组ID、伸缩组名称或者启动配置ID等信息来查询伸缩组的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的伸缩组。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingGroupsRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingGroupsResponse"/></returns>
        public DescribeAutoScalingGroupsResponse DescribeAutoScalingGroupsSync(DescribeAutoScalingGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingGroupsResponse>(req, "DescribeAutoScalingGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAutoScalingInstances）用于查询弹性伸缩关联实例的信息。
        /// 
        /// * 可以根据实例ID、伸缩组ID等信息来查询实例的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingInstancesResponse"/></returns>
        public Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingInstancesResponse>(req, "DescribeAutoScalingInstances");
        }

        /// <summary>
        /// 本接口（DescribeAutoScalingInstances）用于查询弹性伸缩关联实例的信息。
        /// 
        /// * 可以根据实例ID、伸缩组ID等信息来查询实例的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingInstancesResponse"/></returns>
        public DescribeAutoScalingInstancesResponse DescribeAutoScalingInstancesSync(DescribeAutoScalingInstancesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingInstancesResponse>(req, "DescribeAutoScalingInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeLaunchConfigurations）用于查询启动配置的信息。
        /// 
        /// * 可以根据启动配置ID、启动配置名称等信息来查询启动配置的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的启动配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeLaunchConfigurationsRequest"/></param>
        /// <returns><see cref="DescribeLaunchConfigurationsResponse"/></returns>
        public Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest req)
        {
            return InternalRequestAsync<DescribeLaunchConfigurationsResponse>(req, "DescribeLaunchConfigurations");
        }

        /// <summary>
        /// 本接口（DescribeLaunchConfigurations）用于查询启动配置的信息。
        /// 
        /// * 可以根据启动配置ID、启动配置名称等信息来查询启动配置的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的启动配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeLaunchConfigurationsRequest"/></param>
        /// <returns><see cref="DescribeLaunchConfigurationsResponse"/></returns>
        public DescribeLaunchConfigurationsResponse DescribeLaunchConfigurationsSync(DescribeLaunchConfigurationsRequest req)
        {
            return InternalRequestAsync<DescribeLaunchConfigurationsResponse>(req, "DescribeLaunchConfigurations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeLifecycleHooks）用于查询生命周期挂钩信息。
        /// 
        /// * 可以根据伸缩组ID、生命周期挂钩ID或者生命周期挂钩名称等信息来查询生命周期挂钩的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的生命周期挂钩。
        /// </summary>
        /// <param name="req"><see cref="DescribeLifecycleHooksRequest"/></param>
        /// <returns><see cref="DescribeLifecycleHooksResponse"/></returns>
        public Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooks(DescribeLifecycleHooksRequest req)
        {
            return InternalRequestAsync<DescribeLifecycleHooksResponse>(req, "DescribeLifecycleHooks");
        }

        /// <summary>
        /// 本接口（DescribeLifecycleHooks）用于查询生命周期挂钩信息。
        /// 
        /// * 可以根据伸缩组ID、生命周期挂钩ID或者生命周期挂钩名称等信息来查询生命周期挂钩的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的生命周期挂钩。
        /// </summary>
        /// <param name="req"><see cref="DescribeLifecycleHooksRequest"/></param>
        /// <returns><see cref="DescribeLifecycleHooksResponse"/></returns>
        public DescribeLifecycleHooksResponse DescribeLifecycleHooksSync(DescribeLifecycleHooksRequest req)
        {
            return InternalRequestAsync<DescribeLifecycleHooksResponse>(req, "DescribeLifecycleHooks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeNotificationConfigurations) 用于查询一个或多个通知的详细信息。
        /// 
        /// 可以根据通知ID、伸缩组ID等信息来查询通知的详细信息。过滤信息详细请见过滤器`Filter`。
        /// 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的通知。
        /// </summary>
        /// <param name="req"><see cref="DescribeNotificationConfigurationsRequest"/></param>
        /// <returns><see cref="DescribeNotificationConfigurationsResponse"/></returns>
        public Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest req)
        {
            return InternalRequestAsync<DescribeNotificationConfigurationsResponse>(req, "DescribeNotificationConfigurations");
        }

        /// <summary>
        /// 本接口 (DescribeNotificationConfigurations) 用于查询一个或多个通知的详细信息。
        /// 
        /// 可以根据通知ID、伸缩组ID等信息来查询通知的详细信息。过滤信息详细请见过滤器`Filter`。
        /// 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的通知。
        /// </summary>
        /// <param name="req"><see cref="DescribeNotificationConfigurationsRequest"/></param>
        /// <returns><see cref="DescribeNotificationConfigurationsResponse"/></returns>
        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurationsSync(DescribeNotificationConfigurationsRequest req)
        {
            return InternalRequestAsync<DescribeNotificationConfigurationsResponse>(req, "DescribeNotificationConfigurations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRefreshActivities）用于查询伸缩组的实例刷新活动记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeRefreshActivitiesRequest"/></param>
        /// <returns><see cref="DescribeRefreshActivitiesResponse"/></returns>
        public Task<DescribeRefreshActivitiesResponse> DescribeRefreshActivities(DescribeRefreshActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeRefreshActivitiesResponse>(req, "DescribeRefreshActivities");
        }

        /// <summary>
        /// 本接口（DescribeRefreshActivities）用于查询伸缩组的实例刷新活动记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeRefreshActivitiesRequest"/></param>
        /// <returns><see cref="DescribeRefreshActivitiesResponse"/></returns>
        public DescribeRefreshActivitiesResponse DescribeRefreshActivitiesSync(DescribeRefreshActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeRefreshActivitiesResponse>(req, "DescribeRefreshActivities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeScalingPolicies）用于查询告警触发策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeScalingPoliciesResponse"/></returns>
        public Task<DescribeScalingPoliciesResponse> DescribeScalingPolicies(DescribeScalingPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeScalingPoliciesResponse>(req, "DescribeScalingPolicies");
        }

        /// <summary>
        /// 本接口（DescribeScalingPolicies）用于查询告警触发策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeScalingPoliciesResponse"/></returns>
        public DescribeScalingPoliciesResponse DescribeScalingPoliciesSync(DescribeScalingPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeScalingPoliciesResponse>(req, "DescribeScalingPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeScheduledActions) 用于查询一个或多个定时任务的详细信息。
        /// 
        /// * 可以根据定时任务ID、定时任务名称或者伸缩组ID等信息来查询定时任务的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的定时任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledActionsRequest"/></param>
        /// <returns><see cref="DescribeScheduledActionsResponse"/></returns>
        public Task<DescribeScheduledActionsResponse> DescribeScheduledActions(DescribeScheduledActionsRequest req)
        {
            return InternalRequestAsync<DescribeScheduledActionsResponse>(req, "DescribeScheduledActions");
        }

        /// <summary>
        /// 本接口 (DescribeScheduledActions) 用于查询一个或多个定时任务的详细信息。
        /// 
        /// * 可以根据定时任务ID、定时任务名称或者伸缩组ID等信息来查询定时任务的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的定时任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledActionsRequest"/></param>
        /// <returns><see cref="DescribeScheduledActionsResponse"/></returns>
        public DescribeScheduledActionsResponse DescribeScheduledActionsSync(DescribeScheduledActionsRequest req)
        {
            return InternalRequestAsync<DescribeScheduledActionsResponse>(req, "DescribeScheduledActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DetachInstances）用于从伸缩组移出 CVM 实例，本接口不会销毁实例。
        /// * 如果移出指定实例后，伸缩组内处于`IN_SERVICE`状态的实例数量小于伸缩组最小值，接口将报错
        /// * 如果伸缩组处于`DISABLED`状态，移出操作不校验`IN_SERVICE`实例数量和最小值的关系
        /// * 对于伸缩组配置的 CLB，实例在离开伸缩组时，AS 会进行解挂载动作
        /// </summary>
        /// <param name="req"><see cref="DetachInstancesRequest"/></param>
        /// <returns><see cref="DetachInstancesResponse"/></returns>
        public Task<DetachInstancesResponse> DetachInstances(DetachInstancesRequest req)
        {
            return InternalRequestAsync<DetachInstancesResponse>(req, "DetachInstances");
        }

        /// <summary>
        /// 本接口（DetachInstances）用于从伸缩组移出 CVM 实例，本接口不会销毁实例。
        /// * 如果移出指定实例后，伸缩组内处于`IN_SERVICE`状态的实例数量小于伸缩组最小值，接口将报错
        /// * 如果伸缩组处于`DISABLED`状态，移出操作不校验`IN_SERVICE`实例数量和最小值的关系
        /// * 对于伸缩组配置的 CLB，实例在离开伸缩组时，AS 会进行解挂载动作
        /// </summary>
        /// <param name="req"><see cref="DetachInstancesRequest"/></param>
        /// <returns><see cref="DetachInstancesResponse"/></returns>
        public DetachInstancesResponse DetachInstancesSync(DetachInstancesRequest req)
        {
            return InternalRequestAsync<DetachInstancesResponse>(req, "DetachInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DetachLoadBalancers）用于从伸缩组移出负载均衡器，本接口不会销毁负载均衡器。
        /// </summary>
        /// <param name="req"><see cref="DetachLoadBalancersRequest"/></param>
        /// <returns><see cref="DetachLoadBalancersResponse"/></returns>
        public Task<DetachLoadBalancersResponse> DetachLoadBalancers(DetachLoadBalancersRequest req)
        {
            return InternalRequestAsync<DetachLoadBalancersResponse>(req, "DetachLoadBalancers");
        }

        /// <summary>
        /// 本接口（DetachLoadBalancers）用于从伸缩组移出负载均衡器，本接口不会销毁负载均衡器。
        /// </summary>
        /// <param name="req"><see cref="DetachLoadBalancersRequest"/></param>
        /// <returns><see cref="DetachLoadBalancersResponse"/></returns>
        public DetachLoadBalancersResponse DetachLoadBalancersSync(DetachLoadBalancersRequest req)
        {
            return InternalRequestAsync<DetachLoadBalancersResponse>(req, "DetachLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisableAutoScalingGroup）用于停用指定伸缩组。
        /// * 停用伸缩组后，自动触发的伸缩活动不再进行，包括：
        ///     - 告警策略触发的伸缩活动
        ///     - 匹配期望实例数的伸缩活动
        ///     - 不健康实例替换活动
        ///     - 定时任务
        /// * 停用伸缩组后，手动触发的伸缩活动允许进行，包括：
        ///     - 指定数量扩容实例（ScaleOutInstances）
        ///     - 指定数量缩容实例（ScaleInInstances）
        ///     - 从伸缩组中移出 CVM 实例（DetachInstances）
        ///     - 从伸缩组中删除 CVM 实例（RemoveInstances）
        ///     - 添加 CVM 实例到伸缩组（AttachInstances）
        ///     - 关闭伸缩组内 CVM 实例（StopAutoScalingInstances）
        ///     - 开启伸缩组内 CVM 实例（StartAutoScalingInstances）
        /// </summary>
        /// <param name="req"><see cref="DisableAutoScalingGroupRequest"/></param>
        /// <returns><see cref="DisableAutoScalingGroupResponse"/></returns>
        public Task<DisableAutoScalingGroupResponse> DisableAutoScalingGroup(DisableAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<DisableAutoScalingGroupResponse>(req, "DisableAutoScalingGroup");
        }

        /// <summary>
        /// 本接口（DisableAutoScalingGroup）用于停用指定伸缩组。
        /// * 停用伸缩组后，自动触发的伸缩活动不再进行，包括：
        ///     - 告警策略触发的伸缩活动
        ///     - 匹配期望实例数的伸缩活动
        ///     - 不健康实例替换活动
        ///     - 定时任务
        /// * 停用伸缩组后，手动触发的伸缩活动允许进行，包括：
        ///     - 指定数量扩容实例（ScaleOutInstances）
        ///     - 指定数量缩容实例（ScaleInInstances）
        ///     - 从伸缩组中移出 CVM 实例（DetachInstances）
        ///     - 从伸缩组中删除 CVM 实例（RemoveInstances）
        ///     - 添加 CVM 实例到伸缩组（AttachInstances）
        ///     - 关闭伸缩组内 CVM 实例（StopAutoScalingInstances）
        ///     - 开启伸缩组内 CVM 实例（StartAutoScalingInstances）
        /// </summary>
        /// <param name="req"><see cref="DisableAutoScalingGroupRequest"/></param>
        /// <returns><see cref="DisableAutoScalingGroupResponse"/></returns>
        public DisableAutoScalingGroupResponse DisableAutoScalingGroupSync(DisableAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<DisableAutoScalingGroupResponse>(req, "DisableAutoScalingGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（EnableAutoScalingGroup）用于启用指定伸缩组。
        /// </summary>
        /// <param name="req"><see cref="EnableAutoScalingGroupRequest"/></param>
        /// <returns><see cref="EnableAutoScalingGroupResponse"/></returns>
        public Task<EnableAutoScalingGroupResponse> EnableAutoScalingGroup(EnableAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<EnableAutoScalingGroupResponse>(req, "EnableAutoScalingGroup");
        }

        /// <summary>
        /// 本接口（EnableAutoScalingGroup）用于启用指定伸缩组。
        /// </summary>
        /// <param name="req"><see cref="EnableAutoScalingGroupRequest"/></param>
        /// <returns><see cref="EnableAutoScalingGroupResponse"/></returns>
        public EnableAutoScalingGroupResponse EnableAutoScalingGroupSync(EnableAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<EnableAutoScalingGroupResponse>(req, "EnableAutoScalingGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ExecuteScalingPolicy）用于执行伸缩策略。
        /// 
        /// * 可以根据伸缩策略ID执行伸缩策略。
        /// * 伸缩策略所属伸缩组处于伸缩活动时，会拒绝执行伸缩策略。
        /// * 本接口不支持执行目标追踪策略。
        /// </summary>
        /// <param name="req"><see cref="ExecuteScalingPolicyRequest"/></param>
        /// <returns><see cref="ExecuteScalingPolicyResponse"/></returns>
        public Task<ExecuteScalingPolicyResponse> ExecuteScalingPolicy(ExecuteScalingPolicyRequest req)
        {
            return InternalRequestAsync<ExecuteScalingPolicyResponse>(req, "ExecuteScalingPolicy");
        }

        /// <summary>
        /// 本接口（ExecuteScalingPolicy）用于执行伸缩策略。
        /// 
        /// * 可以根据伸缩策略ID执行伸缩策略。
        /// * 伸缩策略所属伸缩组处于伸缩活动时，会拒绝执行伸缩策略。
        /// * 本接口不支持执行目标追踪策略。
        /// </summary>
        /// <param name="req"><see cref="ExecuteScalingPolicyRequest"/></param>
        /// <returns><see cref="ExecuteScalingPolicyResponse"/></returns>
        public ExecuteScalingPolicyResponse ExecuteScalingPolicySync(ExecuteScalingPolicyRequest req)
        {
            return InternalRequestAsync<ExecuteScalingPolicyResponse>(req, "ExecuteScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 伸缩组内实例退出备用中状态。
        /// * 备用中状态的实例负载均衡器权重值为 0，退出备用中状态后，权重值也会恢复
        /// * 对备用中状态实例进行开关机操作也会使其退出备用中状态
        /// </summary>
        /// <param name="req"><see cref="ExitStandbyRequest"/></param>
        /// <returns><see cref="ExitStandbyResponse"/></returns>
        public Task<ExitStandbyResponse> ExitStandby(ExitStandbyRequest req)
        {
            return InternalRequestAsync<ExitStandbyResponse>(req, "ExitStandby");
        }

        /// <summary>
        /// 伸缩组内实例退出备用中状态。
        /// * 备用中状态的实例负载均衡器权重值为 0，退出备用中状态后，权重值也会恢复
        /// * 对备用中状态实例进行开关机操作也会使其退出备用中状态
        /// </summary>
        /// <param name="req"><see cref="ExitStandbyRequest"/></param>
        /// <returns><see cref="ExitStandbyResponse"/></returns>
        public ExitStandbyResponse ExitStandbySync(ExitStandbyRequest req)
        {
            return InternalRequestAsync<ExitStandbyResponse>(req, "ExitStandby")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAutoScalingGroup）用于修改伸缩组。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScalingGroupRequest"/></param>
        /// <returns><see cref="ModifyAutoScalingGroupResponse"/></returns>
        public Task<ModifyAutoScalingGroupResponse> ModifyAutoScalingGroup(ModifyAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<ModifyAutoScalingGroupResponse>(req, "ModifyAutoScalingGroup");
        }

        /// <summary>
        /// 本接口（ModifyAutoScalingGroup）用于修改伸缩组。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScalingGroupRequest"/></param>
        /// <returns><see cref="ModifyAutoScalingGroupResponse"/></returns>
        public ModifyAutoScalingGroupResponse ModifyAutoScalingGroupSync(ModifyAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<ModifyAutoScalingGroupResponse>(req, "ModifyAutoScalingGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDesiredCapacity）用于修改指定伸缩组的期望实例数
        /// </summary>
        /// <param name="req"><see cref="ModifyDesiredCapacityRequest"/></param>
        /// <returns><see cref="ModifyDesiredCapacityResponse"/></returns>
        public Task<ModifyDesiredCapacityResponse> ModifyDesiredCapacity(ModifyDesiredCapacityRequest req)
        {
            return InternalRequestAsync<ModifyDesiredCapacityResponse>(req, "ModifyDesiredCapacity");
        }

        /// <summary>
        /// 本接口（ModifyDesiredCapacity）用于修改指定伸缩组的期望实例数
        /// </summary>
        /// <param name="req"><see cref="ModifyDesiredCapacityRequest"/></param>
        /// <returns><see cref="ModifyDesiredCapacityResponse"/></returns>
        public ModifyDesiredCapacityResponse ModifyDesiredCapacitySync(ModifyDesiredCapacityRequest req)
        {
            return InternalRequestAsync<ModifyDesiredCapacityResponse>(req, "ModifyDesiredCapacity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyLaunchConfigurationAttributes）用于修改启动配置部分属性。
        /// 
        /// * 修改启动配置后，已经使用该启动配置扩容的存量实例不会发生变更，此后使用该启动配置的新增实例会按照新的配置进行扩容。
        /// * 本接口支持修改部分简单类型。
        /// </summary>
        /// <param name="req"><see cref="ModifyLaunchConfigurationAttributesRequest"/></param>
        /// <returns><see cref="ModifyLaunchConfigurationAttributesResponse"/></returns>
        public Task<ModifyLaunchConfigurationAttributesResponse> ModifyLaunchConfigurationAttributes(ModifyLaunchConfigurationAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLaunchConfigurationAttributesResponse>(req, "ModifyLaunchConfigurationAttributes");
        }

        /// <summary>
        /// 本接口（ModifyLaunchConfigurationAttributes）用于修改启动配置部分属性。
        /// 
        /// * 修改启动配置后，已经使用该启动配置扩容的存量实例不会发生变更，此后使用该启动配置的新增实例会按照新的配置进行扩容。
        /// * 本接口支持修改部分简单类型。
        /// </summary>
        /// <param name="req"><see cref="ModifyLaunchConfigurationAttributesRequest"/></param>
        /// <returns><see cref="ModifyLaunchConfigurationAttributesResponse"/></returns>
        public ModifyLaunchConfigurationAttributesResponse ModifyLaunchConfigurationAttributesSync(ModifyLaunchConfigurationAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLaunchConfigurationAttributesResponse>(req, "ModifyLaunchConfigurationAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于修改生命周期挂钩。
        /// </summary>
        /// <param name="req"><see cref="ModifyLifecycleHookRequest"/></param>
        /// <returns><see cref="ModifyLifecycleHookResponse"/></returns>
        public Task<ModifyLifecycleHookResponse> ModifyLifecycleHook(ModifyLifecycleHookRequest req)
        {
            return InternalRequestAsync<ModifyLifecycleHookResponse>(req, "ModifyLifecycleHook");
        }

        /// <summary>
        /// 此接口用于修改生命周期挂钩。
        /// </summary>
        /// <param name="req"><see cref="ModifyLifecycleHookRequest"/></param>
        /// <returns><see cref="ModifyLifecycleHookResponse"/></returns>
        public ModifyLifecycleHookResponse ModifyLifecycleHookSync(ModifyLifecycleHookRequest req)
        {
            return InternalRequestAsync<ModifyLifecycleHookResponse>(req, "ModifyLifecycleHook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyLoadBalancerTargetAttributes）用于修改伸缩组内负载均衡器的目标规则属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerTargetAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerTargetAttributesResponse"/></returns>
        public Task<ModifyLoadBalancerTargetAttributesResponse> ModifyLoadBalancerTargetAttributes(ModifyLoadBalancerTargetAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerTargetAttributesResponse>(req, "ModifyLoadBalancerTargetAttributes");
        }

        /// <summary>
        /// 本接口（ModifyLoadBalancerTargetAttributes）用于修改伸缩组内负载均衡器的目标规则属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerTargetAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerTargetAttributesResponse"/></returns>
        public ModifyLoadBalancerTargetAttributesResponse ModifyLoadBalancerTargetAttributesSync(ModifyLoadBalancerTargetAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerTargetAttributesResponse>(req, "ModifyLoadBalancerTargetAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyLoadBalancers）用于修改伸缩组的负载均衡器。
        /// 
        /// * 本接口用于为伸缩组指定新的负载均衡器配置，采用`完全覆盖`风格，无论之前配置如何，`统一按照接口参数配置为新的负载均衡器`。
        /// * 如果要为伸缩组清空负载均衡器，则在调用本接口时仅指定伸缩组ID，不指定具体负载均衡器。
        /// * 本接口会立即修改伸缩组的负载均衡器，并生成一个伸缩活动，异步修改存量实例的负载均衡器。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancersRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancersResponse"/></returns>
        public Task<ModifyLoadBalancersResponse> ModifyLoadBalancers(ModifyLoadBalancersRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancersResponse>(req, "ModifyLoadBalancers");
        }

        /// <summary>
        /// 本接口（ModifyLoadBalancers）用于修改伸缩组的负载均衡器。
        /// 
        /// * 本接口用于为伸缩组指定新的负载均衡器配置，采用`完全覆盖`风格，无论之前配置如何，`统一按照接口参数配置为新的负载均衡器`。
        /// * 如果要为伸缩组清空负载均衡器，则在调用本接口时仅指定伸缩组ID，不指定具体负载均衡器。
        /// * 本接口会立即修改伸缩组的负载均衡器，并生成一个伸缩活动，异步修改存量实例的负载均衡器。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancersRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancersResponse"/></returns>
        public ModifyLoadBalancersResponse ModifyLoadBalancersSync(ModifyLoadBalancersRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancersResponse>(req, "ModifyLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyNotificationConfiguration）用于修改通知。
        /// * 通知的接收端类型不支持修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyNotificationConfigurationRequest"/></param>
        /// <returns><see cref="ModifyNotificationConfigurationResponse"/></returns>
        public Task<ModifyNotificationConfigurationResponse> ModifyNotificationConfiguration(ModifyNotificationConfigurationRequest req)
        {
            return InternalRequestAsync<ModifyNotificationConfigurationResponse>(req, "ModifyNotificationConfiguration");
        }

        /// <summary>
        /// 本接口（ModifyNotificationConfiguration）用于修改通知。
        /// * 通知的接收端类型不支持修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyNotificationConfigurationRequest"/></param>
        /// <returns><see cref="ModifyNotificationConfigurationResponse"/></returns>
        public ModifyNotificationConfigurationResponse ModifyNotificationConfigurationSync(ModifyNotificationConfigurationRequest req)
        {
            return InternalRequestAsync<ModifyNotificationConfigurationResponse>(req, "ModifyNotificationConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyScalingPolicy）用于修改告警触发策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyScalingPolicyRequest"/></param>
        /// <returns><see cref="ModifyScalingPolicyResponse"/></returns>
        public Task<ModifyScalingPolicyResponse> ModifyScalingPolicy(ModifyScalingPolicyRequest req)
        {
            return InternalRequestAsync<ModifyScalingPolicyResponse>(req, "ModifyScalingPolicy");
        }

        /// <summary>
        /// 本接口（ModifyScalingPolicy）用于修改告警触发策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyScalingPolicyRequest"/></param>
        /// <returns><see cref="ModifyScalingPolicyResponse"/></returns>
        public ModifyScalingPolicyResponse ModifyScalingPolicySync(ModifyScalingPolicyRequest req)
        {
            return InternalRequestAsync<ModifyScalingPolicyResponse>(req, "ModifyScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyScheduledAction）用于修改定时任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledActionRequest"/></param>
        /// <returns><see cref="ModifyScheduledActionResponse"/></returns>
        public Task<ModifyScheduledActionResponse> ModifyScheduledAction(ModifyScheduledActionRequest req)
        {
            return InternalRequestAsync<ModifyScheduledActionResponse>(req, "ModifyScheduledAction");
        }

        /// <summary>
        /// 本接口（ModifyScheduledAction）用于修改定时任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledActionRequest"/></param>
        /// <returns><see cref="ModifyScheduledActionResponse"/></returns>
        public ModifyScheduledActionResponse ModifyScheduledActionSync(ModifyScheduledActionRequest req)
        {
            return InternalRequestAsync<ModifyScheduledActionResponse>(req, "ModifyScheduledAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RemoveInstances）用于从伸缩组删除 CVM 实例。根据当前的产品逻辑，如果实例由弹性伸缩自动创建，则实例会被销毁；如果实例系创建后加入伸缩组的，则会从伸缩组中移除，保留实例。
        /// * 如果删除指定实例后，伸缩组内处于`IN_SERVICE`状态的实例数量小于伸缩组最小值，接口将报错
        /// * 如果伸缩组处于`DISABLED`状态，删除操作不校验`IN_SERVICE`实例数量和最小值的关系
        /// * 对于伸缩组配置的 CLB，实例在离开伸缩组时，AS 会进行解挂载动作
        /// </summary>
        /// <param name="req"><see cref="RemoveInstancesRequest"/></param>
        /// <returns><see cref="RemoveInstancesResponse"/></returns>
        public Task<RemoveInstancesResponse> RemoveInstances(RemoveInstancesRequest req)
        {
            return InternalRequestAsync<RemoveInstancesResponse>(req, "RemoveInstances");
        }

        /// <summary>
        /// 本接口（RemoveInstances）用于从伸缩组删除 CVM 实例。根据当前的产品逻辑，如果实例由弹性伸缩自动创建，则实例会被销毁；如果实例系创建后加入伸缩组的，则会从伸缩组中移除，保留实例。
        /// * 如果删除指定实例后，伸缩组内处于`IN_SERVICE`状态的实例数量小于伸缩组最小值，接口将报错
        /// * 如果伸缩组处于`DISABLED`状态，删除操作不校验`IN_SERVICE`实例数量和最小值的关系
        /// * 对于伸缩组配置的 CLB，实例在离开伸缩组时，AS 会进行解挂载动作
        /// </summary>
        /// <param name="req"><see cref="RemoveInstancesRequest"/></param>
        /// <returns><see cref="RemoveInstancesResponse"/></returns>
        public RemoveInstancesResponse RemoveInstancesSync(RemoveInstancesRequest req)
        {
            return InternalRequestAsync<RemoveInstancesResponse>(req, "RemoveInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复暂停状态的实例刷新活动，使其重试当前批次刷新失败实例或继续刷新后续批次，非暂停状态下调用该接口无效。
        /// </summary>
        /// <param name="req"><see cref="ResumeInstanceRefreshRequest"/></param>
        /// <returns><see cref="ResumeInstanceRefreshResponse"/></returns>
        public Task<ResumeInstanceRefreshResponse> ResumeInstanceRefresh(ResumeInstanceRefreshRequest req)
        {
            return InternalRequestAsync<ResumeInstanceRefreshResponse>(req, "ResumeInstanceRefresh");
        }

        /// <summary>
        /// 恢复暂停状态的实例刷新活动，使其重试当前批次刷新失败实例或继续刷新后续批次，非暂停状态下调用该接口无效。
        /// </summary>
        /// <param name="req"><see cref="ResumeInstanceRefreshRequest"/></param>
        /// <returns><see cref="ResumeInstanceRefreshResponse"/></returns>
        public ResumeInstanceRefreshResponse ResumeInstanceRefreshSync(ResumeInstanceRefreshRequest req)
        {
            return InternalRequestAsync<ResumeInstanceRefreshResponse>(req, "ResumeInstanceRefresh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回滚操作会生成一个新的实例刷新活动，该活动也支持分批次刷新以及暂停、恢复、取消操作，接口返回回滚活动的 RefreshActivityId。
        /// * 原活动中待刷新实例变更为已取消，忽略不存在实例，其他状态实例进入回滚流程
        /// * 原活动中正在刷新的实例不会立刻终止，刷新结束后再执行回滚活动
        /// * 暂停状态或最近一次成功的刷新活动支持回滚，其他状态不支持回滚
        /// * 原活动刷新方式为重装实例时，对于 ImageId参数，会自动恢复到回滚前镜像 ID；对于 UserData、EnhancedService、LoginSettings、 HostName 参数，依然会从启动配置中读取，需用户在回滚前自行修改启动配置
        /// </summary>
        /// <param name="req"><see cref="RollbackInstanceRefreshRequest"/></param>
        /// <returns><see cref="RollbackInstanceRefreshResponse"/></returns>
        public Task<RollbackInstanceRefreshResponse> RollbackInstanceRefresh(RollbackInstanceRefreshRequest req)
        {
            return InternalRequestAsync<RollbackInstanceRefreshResponse>(req, "RollbackInstanceRefresh");
        }

        /// <summary>
        /// 回滚操作会生成一个新的实例刷新活动，该活动也支持分批次刷新以及暂停、恢复、取消操作，接口返回回滚活动的 RefreshActivityId。
        /// * 原活动中待刷新实例变更为已取消，忽略不存在实例，其他状态实例进入回滚流程
        /// * 原活动中正在刷新的实例不会立刻终止，刷新结束后再执行回滚活动
        /// * 暂停状态或最近一次成功的刷新活动支持回滚，其他状态不支持回滚
        /// * 原活动刷新方式为重装实例时，对于 ImageId参数，会自动恢复到回滚前镜像 ID；对于 UserData、EnhancedService、LoginSettings、 HostName 参数，依然会从启动配置中读取，需用户在回滚前自行修改启动配置
        /// </summary>
        /// <param name="req"><see cref="RollbackInstanceRefreshRequest"/></param>
        /// <returns><see cref="RollbackInstanceRefreshResponse"/></returns>
        public RollbackInstanceRefreshResponse RollbackInstanceRefreshSync(RollbackInstanceRefreshRequest req)
        {
            return InternalRequestAsync<RollbackInstanceRefreshResponse>(req, "RollbackInstanceRefresh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为伸缩组指定数量缩容实例，返回缩容活动的 ActivityId。
        /// * 伸缩组需要未处于活动中
        /// * 伸缩组处于停用状态时，该接口也会生效，可参考[停用伸缩组](https://cloud.tencent.com/document/api/377/20435)文档查看伸缩组停用状态的影响范围
        /// * 根据伸缩组的`TerminationPolicies`策略，选择被缩容的实例，可参考[缩容处理](https://cloud.tencent.com/document/product/377/8563)
        /// * 接口只会选择`IN_SERVICE`实例缩容，如果需要缩容其他状态实例，可以使用 [DetachInstances](https://cloud.tencent.com/document/api/377/20436) 或 [RemoveInstances](https://cloud.tencent.com/document/api/377/20431) 接口
        /// * 接口会减少期望实例数，新的期望实例数需要大于等于最小实例数
        /// * 缩容如果失败或者部分成功，最后期望实例数只会扣减实际缩容成功的实例数量
        /// </summary>
        /// <param name="req"><see cref="ScaleInInstancesRequest"/></param>
        /// <returns><see cref="ScaleInInstancesResponse"/></returns>
        public Task<ScaleInInstancesResponse> ScaleInInstances(ScaleInInstancesRequest req)
        {
            return InternalRequestAsync<ScaleInInstancesResponse>(req, "ScaleInInstances");
        }

        /// <summary>
        /// 为伸缩组指定数量缩容实例，返回缩容活动的 ActivityId。
        /// * 伸缩组需要未处于活动中
        /// * 伸缩组处于停用状态时，该接口也会生效，可参考[停用伸缩组](https://cloud.tencent.com/document/api/377/20435)文档查看伸缩组停用状态的影响范围
        /// * 根据伸缩组的`TerminationPolicies`策略，选择被缩容的实例，可参考[缩容处理](https://cloud.tencent.com/document/product/377/8563)
        /// * 接口只会选择`IN_SERVICE`实例缩容，如果需要缩容其他状态实例，可以使用 [DetachInstances](https://cloud.tencent.com/document/api/377/20436) 或 [RemoveInstances](https://cloud.tencent.com/document/api/377/20431) 接口
        /// * 接口会减少期望实例数，新的期望实例数需要大于等于最小实例数
        /// * 缩容如果失败或者部分成功，最后期望实例数只会扣减实际缩容成功的实例数量
        /// </summary>
        /// <param name="req"><see cref="ScaleInInstancesRequest"/></param>
        /// <returns><see cref="ScaleInInstancesResponse"/></returns>
        public ScaleInInstancesResponse ScaleInInstancesSync(ScaleInInstancesRequest req)
        {
            return InternalRequestAsync<ScaleInInstancesResponse>(req, "ScaleInInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为伸缩组指定数量扩容实例，返回扩容活动的 ActivityId。
        /// * 伸缩组需要未处于活动中
        /// * 伸缩组处于停用状态时，该接口也会生效，可参考[停用伸缩组](https://cloud.tencent.com/document/api/377/20435)文档查看伸缩组停用状态的影响范围
        /// * 接口会增加期望实例数，新的期望实例数需要小于等于最大实例数
        /// * 扩容如果失败或者部分成功，最后期望实例数只会增加实际成功的实例数量
        /// * 竞价混合模式中一次扩容可能触发多个伸缩活动，该接口仅返回第一个伸缩活动的 ActivityId
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstancesRequest"/></param>
        /// <returns><see cref="ScaleOutInstancesResponse"/></returns>
        public Task<ScaleOutInstancesResponse> ScaleOutInstances(ScaleOutInstancesRequest req)
        {
            return InternalRequestAsync<ScaleOutInstancesResponse>(req, "ScaleOutInstances");
        }

        /// <summary>
        /// 为伸缩组指定数量扩容实例，返回扩容活动的 ActivityId。
        /// * 伸缩组需要未处于活动中
        /// * 伸缩组处于停用状态时，该接口也会生效，可参考[停用伸缩组](https://cloud.tencent.com/document/api/377/20435)文档查看伸缩组停用状态的影响范围
        /// * 接口会增加期望实例数，新的期望实例数需要小于等于最大实例数
        /// * 扩容如果失败或者部分成功，最后期望实例数只会增加实际成功的实例数量
        /// * 竞价混合模式中一次扩容可能触发多个伸缩活动，该接口仅返回第一个伸缩活动的 ActivityId
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstancesRequest"/></param>
        /// <returns><see cref="ScaleOutInstancesResponse"/></returns>
        public ScaleOutInstancesResponse ScaleOutInstancesSync(ScaleOutInstancesRequest req)
        {
            return InternalRequestAsync<ScaleOutInstancesResponse>(req, "ScaleOutInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SetInstancesProtection）用于设置实例保护。
        /// 实例设置保护之后，当发生不健康替换、报警策略、期望值变更等触发缩容时，将不对此实例缩容操作。
        /// </summary>
        /// <param name="req"><see cref="SetInstancesProtectionRequest"/></param>
        /// <returns><see cref="SetInstancesProtectionResponse"/></returns>
        public Task<SetInstancesProtectionResponse> SetInstancesProtection(SetInstancesProtectionRequest req)
        {
            return InternalRequestAsync<SetInstancesProtectionResponse>(req, "SetInstancesProtection");
        }

        /// <summary>
        /// 本接口（SetInstancesProtection）用于设置实例保护。
        /// 实例设置保护之后，当发生不健康替换、报警策略、期望值变更等触发缩容时，将不对此实例缩容操作。
        /// </summary>
        /// <param name="req"><see cref="SetInstancesProtectionRequest"/></param>
        /// <returns><see cref="SetInstancesProtectionResponse"/></returns>
        public SetInstancesProtectionResponse SetInstancesProtectionSync(SetInstancesProtectionRequest req)
        {
            return InternalRequestAsync<SetInstancesProtectionResponse>(req, "SetInstancesProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StartAutoScalingInstances）用于开启伸缩组内 CVM 实例。
        /// * 开机成功，实例转为`IN_SERVICE`状态后，会增加期望实例数，期望实例数不可超过设置的最大值
        /// * 本接口支持批量操作，每次请求开机实例的上限为100
        /// </summary>
        /// <param name="req"><see cref="StartAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="StartAutoScalingInstancesResponse"/></returns>
        public Task<StartAutoScalingInstancesResponse> StartAutoScalingInstances(StartAutoScalingInstancesRequest req)
        {
            return InternalRequestAsync<StartAutoScalingInstancesResponse>(req, "StartAutoScalingInstances");
        }

        /// <summary>
        /// 本接口（StartAutoScalingInstances）用于开启伸缩组内 CVM 实例。
        /// * 开机成功，实例转为`IN_SERVICE`状态后，会增加期望实例数，期望实例数不可超过设置的最大值
        /// * 本接口支持批量操作，每次请求开机实例的上限为100
        /// </summary>
        /// <param name="req"><see cref="StartAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="StartAutoScalingInstancesResponse"/></returns>
        public StartAutoScalingInstancesResponse StartAutoScalingInstancesSync(StartAutoScalingInstancesRequest req)
        {
            return InternalRequestAsync<StartAutoScalingInstancesResponse>(req, "StartAutoScalingInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据启动配置中参数，刷新伸缩组内运行中状态 CVM 实例，返回实例刷新活动的 RefreshActivityId。
        /// * 对于重装实例的刷新方式（目前仅支持重装），重装时仅会从启动配置中获取 ImageId、UserData、EnhancedService、 HostName、LoginSettings 参数进行刷新，实例的其他参数不会刷新
        /// * 实例刷新期间（包括暂停状态），伸缩组会被停用。不建议刷新期间修改关联启动配置，否则会影响刷新参数，造成实例配置不一致
        /// * 滚动更新模式会分成多批次进行刷新实例，单批次中若存在刷新失败实例，活动会进入失败暂停状态
        /// * 若待刷新实例被移出或销毁，会被标记为 NOT_FOUND 状态，不阻塞实例刷新活动
        /// * 运行中状态实例与最新启动配置参数一致，实例也会再次刷新
        /// </summary>
        /// <param name="req"><see cref="StartInstanceRefreshRequest"/></param>
        /// <returns><see cref="StartInstanceRefreshResponse"/></returns>
        public Task<StartInstanceRefreshResponse> StartInstanceRefresh(StartInstanceRefreshRequest req)
        {
            return InternalRequestAsync<StartInstanceRefreshResponse>(req, "StartInstanceRefresh");
        }

        /// <summary>
        /// 根据启动配置中参数，刷新伸缩组内运行中状态 CVM 实例，返回实例刷新活动的 RefreshActivityId。
        /// * 对于重装实例的刷新方式（目前仅支持重装），重装时仅会从启动配置中获取 ImageId、UserData、EnhancedService、 HostName、LoginSettings 参数进行刷新，实例的其他参数不会刷新
        /// * 实例刷新期间（包括暂停状态），伸缩组会被停用。不建议刷新期间修改关联启动配置，否则会影响刷新参数，造成实例配置不一致
        /// * 滚动更新模式会分成多批次进行刷新实例，单批次中若存在刷新失败实例，活动会进入失败暂停状态
        /// * 若待刷新实例被移出或销毁，会被标记为 NOT_FOUND 状态，不阻塞实例刷新活动
        /// * 运行中状态实例与最新启动配置参数一致，实例也会再次刷新
        /// </summary>
        /// <param name="req"><see cref="StartInstanceRefreshRequest"/></param>
        /// <returns><see cref="StartInstanceRefreshResponse"/></returns>
        public StartInstanceRefreshResponse StartInstanceRefreshSync(StartInstanceRefreshRequest req)
        {
            return InternalRequestAsync<StartInstanceRefreshResponse>(req, "StartInstanceRefresh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StopAutoScalingInstances）用于关闭伸缩组内 CVM 实例。
        /// * 关机方式采用`SOFT_FIRST`方式，表示在正常关闭失败后进行强制关闭
        /// * 关闭`IN_SERVICE`状态的实例，会减少期望实例数，期望实例数不可低于设置的最小值
        /// * 使用`STOP_CHARGING`选项关机，待关机的实例需要满足[关机不收费条件](https://cloud.tencent.com/document/product/213/19918)
        /// * 本接口支持批量操作，每次请求关机实例的上限为100
        /// </summary>
        /// <param name="req"><see cref="StopAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="StopAutoScalingInstancesResponse"/></returns>
        public Task<StopAutoScalingInstancesResponse> StopAutoScalingInstances(StopAutoScalingInstancesRequest req)
        {
            return InternalRequestAsync<StopAutoScalingInstancesResponse>(req, "StopAutoScalingInstances");
        }

        /// <summary>
        /// 本接口（StopAutoScalingInstances）用于关闭伸缩组内 CVM 实例。
        /// * 关机方式采用`SOFT_FIRST`方式，表示在正常关闭失败后进行强制关闭
        /// * 关闭`IN_SERVICE`状态的实例，会减少期望实例数，期望实例数不可低于设置的最小值
        /// * 使用`STOP_CHARGING`选项关机，待关机的实例需要满足[关机不收费条件](https://cloud.tencent.com/document/product/213/19918)
        /// * 本接口支持批量操作，每次请求关机实例的上限为100
        /// </summary>
        /// <param name="req"><see cref="StopAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="StopAutoScalingInstancesResponse"/></returns>
        public StopAutoScalingInstancesResponse StopAutoScalingInstancesSync(StopAutoScalingInstancesRequest req)
        {
            return InternalRequestAsync<StopAutoScalingInstancesResponse>(req, "StopAutoScalingInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停正在执行的实例刷新活动。
        /// * 暂停状态下，伸缩组也会处于停用中状态
        /// * 当前正在更新的实例不会暂停，待更新的实例会暂停更新
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRefreshRequest"/></param>
        /// <returns><see cref="StopInstanceRefreshResponse"/></returns>
        public Task<StopInstanceRefreshResponse> StopInstanceRefresh(StopInstanceRefreshRequest req)
        {
            return InternalRequestAsync<StopInstanceRefreshResponse>(req, "StopInstanceRefresh");
        }

        /// <summary>
        /// 暂停正在执行的实例刷新活动。
        /// * 暂停状态下，伸缩组也会处于停用中状态
        /// * 当前正在更新的实例不会暂停，待更新的实例会暂停更新
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRefreshRequest"/></param>
        /// <returns><see cref="StopInstanceRefreshResponse"/></returns>
        public StopInstanceRefreshResponse StopInstanceRefreshSync(StopInstanceRefreshRequest req)
        {
            return InternalRequestAsync<StopInstanceRefreshResponse>(req, "StopInstanceRefresh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 已有替代接口ModifyLaunchConfiguration。该接口存在覆盖参数风险，目前官网已隐藏
        /// 
        /// 本接口（UpgradeLaunchConfiguration）用于升级启动配置。
        /// 
        /// * 本接口用于升级启动配置，采用“完全覆盖”风格，无论之前参数如何，统一按照接口参数设置为新的配置。对于非必填字段，不填写则按照默认值赋值。
        /// * 升级修改启动配置后，已经使用该启动配置扩容的存量实例不会发生变更，此后使用该启动配置的新增实例会按照新的配置进行扩容。
        /// </summary>
        /// <param name="req"><see cref="UpgradeLaunchConfigurationRequest"/></param>
        /// <returns><see cref="UpgradeLaunchConfigurationResponse"/></returns>
        public Task<UpgradeLaunchConfigurationResponse> UpgradeLaunchConfiguration(UpgradeLaunchConfigurationRequest req)
        {
            return InternalRequestAsync<UpgradeLaunchConfigurationResponse>(req, "UpgradeLaunchConfiguration");
        }

        /// <summary>
        /// 已有替代接口ModifyLaunchConfiguration。该接口存在覆盖参数风险，目前官网已隐藏
        /// 
        /// 本接口（UpgradeLaunchConfiguration）用于升级启动配置。
        /// 
        /// * 本接口用于升级启动配置，采用“完全覆盖”风格，无论之前参数如何，统一按照接口参数设置为新的配置。对于非必填字段，不填写则按照默认值赋值。
        /// * 升级修改启动配置后，已经使用该启动配置扩容的存量实例不会发生变更，此后使用该启动配置的新增实例会按照新的配置进行扩容。
        /// </summary>
        /// <param name="req"><see cref="UpgradeLaunchConfigurationRequest"/></param>
        /// <returns><see cref="UpgradeLaunchConfigurationResponse"/></returns>
        public UpgradeLaunchConfigurationResponse UpgradeLaunchConfigurationSync(UpgradeLaunchConfigurationRequest req)
        {
            return InternalRequestAsync<UpgradeLaunchConfigurationResponse>(req, "UpgradeLaunchConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpgradeLifecycleHook）用于升级生命周期挂钩。
        /// 
        /// * 本接口用于升级生命周期挂钩，采用“完全覆盖”风格，无论之前参数如何，统一按照接口参数设置为新的配置。对于非必填字段，不填写则按照默认值赋值。
        /// </summary>
        /// <param name="req"><see cref="UpgradeLifecycleHookRequest"/></param>
        /// <returns><see cref="UpgradeLifecycleHookResponse"/></returns>
        public Task<UpgradeLifecycleHookResponse> UpgradeLifecycleHook(UpgradeLifecycleHookRequest req)
        {
            return InternalRequestAsync<UpgradeLifecycleHookResponse>(req, "UpgradeLifecycleHook");
        }

        /// <summary>
        /// 本接口（UpgradeLifecycleHook）用于升级生命周期挂钩。
        /// 
        /// * 本接口用于升级生命周期挂钩，采用“完全覆盖”风格，无论之前参数如何，统一按照接口参数设置为新的配置。对于非必填字段，不填写则按照默认值赋值。
        /// </summary>
        /// <param name="req"><see cref="UpgradeLifecycleHookRequest"/></param>
        /// <returns><see cref="UpgradeLifecycleHookResponse"/></returns>
        public UpgradeLifecycleHookResponse UpgradeLifecycleHookSync(UpgradeLifecycleHookRequest req)
        {
            return InternalRequestAsync<UpgradeLifecycleHookResponse>(req, "UpgradeLifecycleHook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
