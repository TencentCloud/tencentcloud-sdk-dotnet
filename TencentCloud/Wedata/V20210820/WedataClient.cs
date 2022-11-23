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

namespace TencentCloud.Wedata.V20210820
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Wedata.V20210820.Models;

   public class WedataClient : AbstractClient{

       private const string endpoint = "wedata.tencentcloudapi.com";
       private const string version = "2021-08-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WedataClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WedataClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 批量创建任务告警规则
        /// </summary>
        /// <param name="req"><see cref="BatchCreateIntegrationTaskAlarmsRequest"/></param>
        /// <returns><see cref="BatchCreateIntegrationTaskAlarmsResponse"/></returns>
        public async Task<BatchCreateIntegrationTaskAlarmsResponse> BatchCreateIntegrationTaskAlarms(BatchCreateIntegrationTaskAlarmsRequest req)
        {
             JsonResponseModel<BatchCreateIntegrationTaskAlarmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchCreateIntegrationTaskAlarms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchCreateIntegrationTaskAlarmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量创建任务告警规则
        /// </summary>
        /// <param name="req"><see cref="BatchCreateIntegrationTaskAlarmsRequest"/></param>
        /// <returns><see cref="BatchCreateIntegrationTaskAlarmsResponse"/></returns>
        public BatchCreateIntegrationTaskAlarmsResponse BatchCreateIntegrationTaskAlarmsSync(BatchCreateIntegrationTaskAlarmsRequest req)
        {
             JsonResponseModel<BatchCreateIntegrationTaskAlarmsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchCreateIntegrationTaskAlarms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchCreateIntegrationTaskAlarmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchDeleteIntegrationTasksResponse"/></returns>
        public async Task<BatchDeleteIntegrationTasksResponse> BatchDeleteIntegrationTasks(BatchDeleteIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchDeleteIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeleteIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchDeleteIntegrationTasksResponse"/></returns>
        public BatchDeleteIntegrationTasksResponse BatchDeleteIntegrationTasksSync(BatchDeleteIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchDeleteIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeleteIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量删除任务，仅对任务状态为”已停止“有效；
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteTasksNewRequest"/></param>
        /// <returns><see cref="BatchDeleteTasksNewResponse"/></returns>
        public async Task<BatchDeleteTasksNewResponse> BatchDeleteTasksNew(BatchDeleteTasksNewRequest req)
        {
             JsonResponseModel<BatchDeleteTasksNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeleteTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量删除任务，仅对任务状态为”已停止“有效；
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteTasksNewRequest"/></param>
        /// <returns><see cref="BatchDeleteTasksNewResponse"/></returns>
        public BatchDeleteTasksNewResponse BatchDeleteTasksNewSync(BatchDeleteTasksNewRequest req)
        {
             JsonResponseModel<BatchDeleteTasksNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeleteTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量置成功集成任务实例
        /// </summary>
        /// <param name="req"><see cref="BatchForceSuccessIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchForceSuccessIntegrationTaskInstancesResponse"/></returns>
        public async Task<BatchForceSuccessIntegrationTaskInstancesResponse> BatchForceSuccessIntegrationTaskInstances(BatchForceSuccessIntegrationTaskInstancesRequest req)
        {
             JsonResponseModel<BatchForceSuccessIntegrationTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchForceSuccessIntegrationTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchForceSuccessIntegrationTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量置成功集成任务实例
        /// </summary>
        /// <param name="req"><see cref="BatchForceSuccessIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchForceSuccessIntegrationTaskInstancesResponse"/></returns>
        public BatchForceSuccessIntegrationTaskInstancesResponse BatchForceSuccessIntegrationTaskInstancesSync(BatchForceSuccessIntegrationTaskInstancesRequest req)
        {
             JsonResponseModel<BatchForceSuccessIntegrationTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchForceSuccessIntegrationTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchForceSuccessIntegrationTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量终止集成任务实例
        /// </summary>
        /// <param name="req"><see cref="BatchKillIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchKillIntegrationTaskInstancesResponse"/></returns>
        public async Task<BatchKillIntegrationTaskInstancesResponse> BatchKillIntegrationTaskInstances(BatchKillIntegrationTaskInstancesRequest req)
        {
             JsonResponseModel<BatchKillIntegrationTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchKillIntegrationTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchKillIntegrationTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量终止集成任务实例
        /// </summary>
        /// <param name="req"><see cref="BatchKillIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchKillIntegrationTaskInstancesResponse"/></returns>
        public BatchKillIntegrationTaskInstancesResponse BatchKillIntegrationTaskInstancesSync(BatchKillIntegrationTaskInstancesRequest req)
        {
             JsonResponseModel<BatchKillIntegrationTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchKillIntegrationTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchKillIntegrationTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对集成离线任务执行批量补数据操作
        /// </summary>
        /// <param name="req"><see cref="BatchMakeUpIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchMakeUpIntegrationTasksResponse"/></returns>
        public async Task<BatchMakeUpIntegrationTasksResponse> BatchMakeUpIntegrationTasks(BatchMakeUpIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchMakeUpIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchMakeUpIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchMakeUpIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对集成离线任务执行批量补数据操作
        /// </summary>
        /// <param name="req"><see cref="BatchMakeUpIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchMakeUpIntegrationTasksResponse"/></returns>
        public BatchMakeUpIntegrationTasksResponse BatchMakeUpIntegrationTasksSync(BatchMakeUpIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchMakeUpIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchMakeUpIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchMakeUpIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量修改任务责任人
        /// </summary>
        /// <param name="req"><see cref="BatchModifyOwnersNewRequest"/></param>
        /// <returns><see cref="BatchModifyOwnersNewResponse"/></returns>
        public async Task<BatchModifyOwnersNewResponse> BatchModifyOwnersNew(BatchModifyOwnersNewRequest req)
        {
             JsonResponseModel<BatchModifyOwnersNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyOwnersNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyOwnersNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量修改任务责任人
        /// </summary>
        /// <param name="req"><see cref="BatchModifyOwnersNewRequest"/></param>
        /// <returns><see cref="BatchModifyOwnersNewResponse"/></returns>
        public BatchModifyOwnersNewResponse BatchModifyOwnersNewSync(BatchModifyOwnersNewRequest req)
        {
             JsonResponseModel<BatchModifyOwnersNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyOwnersNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyOwnersNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量重跑集成任务实例
        /// </summary>
        /// <param name="req"><see cref="BatchRerunIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchRerunIntegrationTaskInstancesResponse"/></returns>
        public async Task<BatchRerunIntegrationTaskInstancesResponse> BatchRerunIntegrationTaskInstances(BatchRerunIntegrationTaskInstancesRequest req)
        {
             JsonResponseModel<BatchRerunIntegrationTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchRerunIntegrationTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchRerunIntegrationTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量重跑集成任务实例
        /// </summary>
        /// <param name="req"><see cref="BatchRerunIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchRerunIntegrationTaskInstancesResponse"/></returns>
        public BatchRerunIntegrationTaskInstancesResponse BatchRerunIntegrationTaskInstancesSync(BatchRerunIntegrationTaskInstancesRequest req)
        {
             JsonResponseModel<BatchRerunIntegrationTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchRerunIntegrationTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchRerunIntegrationTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量继续执行集成实时任务
        /// </summary>
        /// <param name="req"><see cref="BatchResumeIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchResumeIntegrationTasksResponse"/></returns>
        public async Task<BatchResumeIntegrationTasksResponse> BatchResumeIntegrationTasks(BatchResumeIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchResumeIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchResumeIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchResumeIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量继续执行集成实时任务
        /// </summary>
        /// <param name="req"><see cref="BatchResumeIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchResumeIntegrationTasksResponse"/></returns>
        public BatchResumeIntegrationTasksResponse BatchResumeIntegrationTasksSync(BatchResumeIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchResumeIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchResumeIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchResumeIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量运行集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchStartIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchStartIntegrationTasksResponse"/></returns>
        public async Task<BatchStartIntegrationTasksResponse> BatchStartIntegrationTasks(BatchStartIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchStartIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchStartIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchStartIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量运行集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchStartIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchStartIntegrationTasksResponse"/></returns>
        public BatchStartIntegrationTasksResponse BatchStartIntegrationTasksSync(BatchStartIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchStartIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchStartIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchStartIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量停止集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchStopIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchStopIntegrationTasksResponse"/></returns>
        public async Task<BatchStopIntegrationTasksResponse> BatchStopIntegrationTasks(BatchStopIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchStopIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchStopIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchStopIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量停止集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchStopIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchStopIntegrationTasksResponse"/></returns>
        public BatchStopIntegrationTasksResponse BatchStopIntegrationTasksSync(BatchStopIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchStopIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchStopIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchStopIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 仅对任务状态为”调度中“和”已暂停“有效，对所选任务的任务实例进行终止，并停止调度
        /// </summary>
        /// <param name="req"><see cref="BatchStopTasksNewRequest"/></param>
        /// <returns><see cref="BatchStopTasksNewResponse"/></returns>
        public async Task<BatchStopTasksNewResponse> BatchStopTasksNew(BatchStopTasksNewRequest req)
        {
             JsonResponseModel<BatchStopTasksNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchStopTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchStopTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 仅对任务状态为”调度中“和”已暂停“有效，对所选任务的任务实例进行终止，并停止调度
        /// </summary>
        /// <param name="req"><see cref="BatchStopTasksNewRequest"/></param>
        /// <returns><see cref="BatchStopTasksNewResponse"/></returns>
        public BatchStopTasksNewResponse BatchStopTasksNewSync(BatchStopTasksNewRequest req)
        {
             JsonResponseModel<BatchStopTasksNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchStopTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchStopTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量暂停集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchSuspendIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchSuspendIntegrationTasksResponse"/></returns>
        public async Task<BatchSuspendIntegrationTasksResponse> BatchSuspendIntegrationTasks(BatchSuspendIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchSuspendIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchSuspendIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchSuspendIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量暂停集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchSuspendIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchSuspendIntegrationTasksResponse"/></returns>
        public BatchSuspendIntegrationTasksResponse BatchSuspendIntegrationTasksSync(BatchSuspendIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchSuspendIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchSuspendIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchSuspendIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量更新集成任务（暂时仅支持批量更新责任人）
        /// </summary>
        /// <param name="req"><see cref="BatchUpdateIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchUpdateIntegrationTasksResponse"/></returns>
        public async Task<BatchUpdateIntegrationTasksResponse> BatchUpdateIntegrationTasks(BatchUpdateIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchUpdateIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchUpdateIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchUpdateIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量更新集成任务（暂时仅支持批量更新责任人）
        /// </summary>
        /// <param name="req"><see cref="BatchUpdateIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchUpdateIntegrationTasksResponse"/></returns>
        public BatchUpdateIntegrationTasksResponse BatchUpdateIntegrationTasksSync(BatchUpdateIntegrationTasksRequest req)
        {
             JsonResponseModel<BatchUpdateIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchUpdateIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchUpdateIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 判断告警规则重名
        /// </summary>
        /// <param name="req"><see cref="CheckAlarmRegularNameExistRequest"/></param>
        /// <returns><see cref="CheckAlarmRegularNameExistResponse"/></returns>
        public async Task<CheckAlarmRegularNameExistResponse> CheckAlarmRegularNameExist(CheckAlarmRegularNameExistRequest req)
        {
             JsonResponseModel<CheckAlarmRegularNameExistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckAlarmRegularNameExist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckAlarmRegularNameExistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 判断告警规则重名
        /// </summary>
        /// <param name="req"><see cref="CheckAlarmRegularNameExistRequest"/></param>
        /// <returns><see cref="CheckAlarmRegularNameExistResponse"/></returns>
        public CheckAlarmRegularNameExistResponse CheckAlarmRegularNameExistSync(CheckAlarmRegularNameExistRequest req)
        {
             JsonResponseModel<CheckAlarmRegularNameExistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckAlarmRegularNameExist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckAlarmRegularNameExistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查规则名称是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckDuplicateRuleNameRequest"/></param>
        /// <returns><see cref="CheckDuplicateRuleNameResponse"/></returns>
        public async Task<CheckDuplicateRuleNameResponse> CheckDuplicateRuleName(CheckDuplicateRuleNameRequest req)
        {
             JsonResponseModel<CheckDuplicateRuleNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckDuplicateRuleName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDuplicateRuleNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查规则名称是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckDuplicateRuleNameRequest"/></param>
        /// <returns><see cref="CheckDuplicateRuleNameResponse"/></returns>
        public CheckDuplicateRuleNameResponse CheckDuplicateRuleNameSync(CheckDuplicateRuleNameRequest req)
        {
             JsonResponseModel<CheckDuplicateRuleNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckDuplicateRuleName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDuplicateRuleNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查规则模板名称是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckDuplicateTemplateNameRequest"/></param>
        /// <returns><see cref="CheckDuplicateTemplateNameResponse"/></returns>
        public async Task<CheckDuplicateTemplateNameResponse> CheckDuplicateTemplateName(CheckDuplicateTemplateNameRequest req)
        {
             JsonResponseModel<CheckDuplicateTemplateNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckDuplicateTemplateName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDuplicateTemplateNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查规则模板名称是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckDuplicateTemplateNameRequest"/></param>
        /// <returns><see cref="CheckDuplicateTemplateNameResponse"/></returns>
        public CheckDuplicateTemplateNameResponse CheckDuplicateTemplateNameSync(CheckDuplicateTemplateNameRequest req)
        {
             JsonResponseModel<CheckDuplicateTemplateNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckDuplicateTemplateName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDuplicateTemplateNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 判断集成节点名称是否存在
        /// </summary>
        /// <param name="req"><see cref="CheckIntegrationNodeNameExistsRequest"/></param>
        /// <returns><see cref="CheckIntegrationNodeNameExistsResponse"/></returns>
        public async Task<CheckIntegrationNodeNameExistsResponse> CheckIntegrationNodeNameExists(CheckIntegrationNodeNameExistsRequest req)
        {
             JsonResponseModel<CheckIntegrationNodeNameExistsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckIntegrationNodeNameExists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIntegrationNodeNameExistsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 判断集成节点名称是否存在
        /// </summary>
        /// <param name="req"><see cref="CheckIntegrationNodeNameExistsRequest"/></param>
        /// <returns><see cref="CheckIntegrationNodeNameExistsResponse"/></returns>
        public CheckIntegrationNodeNameExistsResponse CheckIntegrationNodeNameExistsSync(CheckIntegrationNodeNameExistsRequest req)
        {
             JsonResponseModel<CheckIntegrationNodeNameExistsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckIntegrationNodeNameExists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIntegrationNodeNameExistsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 判断集成任务名称是否存在
        /// </summary>
        /// <param name="req"><see cref="CheckIntegrationTaskNameExistsRequest"/></param>
        /// <returns><see cref="CheckIntegrationTaskNameExistsResponse"/></returns>
        public async Task<CheckIntegrationTaskNameExistsResponse> CheckIntegrationTaskNameExists(CheckIntegrationTaskNameExistsRequest req)
        {
             JsonResponseModel<CheckIntegrationTaskNameExistsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckIntegrationTaskNameExists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIntegrationTaskNameExistsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 判断集成任务名称是否存在
        /// </summary>
        /// <param name="req"><see cref="CheckIntegrationTaskNameExistsRequest"/></param>
        /// <returns><see cref="CheckIntegrationTaskNameExistsResponse"/></returns>
        public CheckIntegrationTaskNameExistsResponse CheckIntegrationTaskNameExistsSync(CheckIntegrationTaskNameExistsRequest req)
        {
             JsonResponseModel<CheckIntegrationTaskNameExistsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckIntegrationTaskNameExists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIntegrationTaskNameExistsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 离线任务重名校验
        /// </summary>
        /// <param name="req"><see cref="CheckTaskNameExistRequest"/></param>
        /// <returns><see cref="CheckTaskNameExistResponse"/></returns>
        public async Task<CheckTaskNameExistResponse> CheckTaskNameExist(CheckTaskNameExistRequest req)
        {
             JsonResponseModel<CheckTaskNameExistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckTaskNameExist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckTaskNameExistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 离线任务重名校验
        /// </summary>
        /// <param name="req"><see cref="CheckTaskNameExistRequest"/></param>
        /// <returns><see cref="CheckTaskNameExistResponse"/></returns>
        public CheckTaskNameExistResponse CheckTaskNameExistSync(CheckTaskNameExistRequest req)
        {
             JsonResponseModel<CheckTaskNameExistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckTaskNameExist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckTaskNameExistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交数据导出任务
        /// </summary>
        /// <param name="req"><see cref="CommitExportTaskRequest"/></param>
        /// <returns><see cref="CommitExportTaskResponse"/></returns>
        public async Task<CommitExportTaskResponse> CommitExportTask(CommitExportTaskRequest req)
        {
             JsonResponseModel<CommitExportTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CommitExportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitExportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交数据导出任务
        /// </summary>
        /// <param name="req"><see cref="CommitExportTaskRequest"/></param>
        /// <returns><see cref="CommitExportTaskResponse"/></returns>
        public CommitExportTaskResponse CommitExportTaskSync(CommitExportTaskRequest req)
        {
             JsonResponseModel<CommitExportTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CommitExportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitExportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交集成任务
        /// </summary>
        /// <param name="req"><see cref="CommitIntegrationTaskRequest"/></param>
        /// <returns><see cref="CommitIntegrationTaskResponse"/></returns>
        public async Task<CommitIntegrationTaskResponse> CommitIntegrationTask(CommitIntegrationTaskRequest req)
        {
             JsonResponseModel<CommitIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CommitIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交集成任务
        /// </summary>
        /// <param name="req"><see cref="CommitIntegrationTaskRequest"/></param>
        /// <returns><see cref="CommitIntegrationTaskResponse"/></returns>
        public CommitIntegrationTaskResponse CommitIntegrationTaskSync(CommitIntegrationTaskRequest req)
        {
             JsonResponseModel<CommitIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CommitIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Runner 规则检测结果上报
        /// </summary>
        /// <param name="req"><see cref="CommitRuleGroupExecResultRequest"/></param>
        /// <returns><see cref="CommitRuleGroupExecResultResponse"/></returns>
        public async Task<CommitRuleGroupExecResultResponse> CommitRuleGroupExecResult(CommitRuleGroupExecResultRequest req)
        {
             JsonResponseModel<CommitRuleGroupExecResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CommitRuleGroupExecResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitRuleGroupExecResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Runner 规则检测结果上报
        /// </summary>
        /// <param name="req"><see cref="CommitRuleGroupExecResultRequest"/></param>
        /// <returns><see cref="CommitRuleGroupExecResultResponse"/></returns>
        public CommitRuleGroupExecResultResponse CommitRuleGroupExecResultSync(CommitRuleGroupExecResultRequest req)
        {
             JsonResponseModel<CommitRuleGroupExecResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CommitRuleGroupExecResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitRuleGroupExecResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交规则组运行任务接口
        /// </summary>
        /// <param name="req"><see cref="CommitRuleGroupTaskRequest"/></param>
        /// <returns><see cref="CommitRuleGroupTaskResponse"/></returns>
        public async Task<CommitRuleGroupTaskResponse> CommitRuleGroupTask(CommitRuleGroupTaskRequest req)
        {
             JsonResponseModel<CommitRuleGroupTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CommitRuleGroupTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitRuleGroupTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交规则组运行任务接口
        /// </summary>
        /// <param name="req"><see cref="CommitRuleGroupTaskRequest"/></param>
        /// <returns><see cref="CommitRuleGroupTaskResponse"/></returns>
        public CommitRuleGroupTaskResponse CommitRuleGroupTaskSync(CommitRuleGroupTaskRequest req)
        {
             JsonResponseModel<CommitRuleGroupTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CommitRuleGroupTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitRuleGroupTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  创建用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="CreateCustomFunctionRequest"/></param>
        /// <returns><see cref="CreateCustomFunctionResponse"/></returns>
        public async Task<CreateCustomFunctionResponse> CreateCustomFunction(CreateCustomFunctionRequest req)
        {
             JsonResponseModel<CreateCustomFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  创建用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="CreateCustomFunctionRequest"/></param>
        /// <returns><see cref="CreateCustomFunctionResponse"/></returns>
        public CreateCustomFunctionResponse CreateCustomFunctionSync(CreateCustomFunctionRequest req)
        {
             JsonResponseModel<CreateCustomFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public async Task<CreateDataSourceResponse> CreateDataSource(CreateDataSourceRequest req)
        {
             JsonResponseModel<CreateDataSourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDataSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public CreateDataSourceResponse CreateDataSourceSync(CreateDataSourceRequest req)
        {
             JsonResponseModel<CreateDataSourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDataSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateFolderRequest"/></param>
        /// <returns><see cref="CreateFolderResponse"/></returns>
        public async Task<CreateFolderResponse> CreateFolder(CreateFolderRequest req)
        {
             JsonResponseModel<CreateFolderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFolder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFolderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateFolderRequest"/></param>
        /// <returns><see cref="CreateFolderResponse"/></returns>
        public CreateFolderResponse CreateFolderSync(CreateFolderRequest req)
        {
             JsonResponseModel<CreateFolderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFolder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFolderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 建hive表
        /// </summary>
        /// <param name="req"><see cref="CreateHiveTableRequest"/></param>
        /// <returns><see cref="CreateHiveTableResponse"/></returns>
        public async Task<CreateHiveTableResponse> CreateHiveTable(CreateHiveTableRequest req)
        {
             JsonResponseModel<CreateHiveTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHiveTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHiveTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 建hive表
        /// </summary>
        /// <param name="req"><see cref="CreateHiveTableRequest"/></param>
        /// <returns><see cref="CreateHiveTableResponse"/></returns>
        public CreateHiveTableResponse CreateHiveTableSync(CreateHiveTableRequest req)
        {
             JsonResponseModel<CreateHiveTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHiveTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHiveTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建hive表，返回表名称
        /// </summary>
        /// <param name="req"><see cref="CreateHiveTableByDDLRequest"/></param>
        /// <returns><see cref="CreateHiveTableByDDLResponse"/></returns>
        public async Task<CreateHiveTableByDDLResponse> CreateHiveTableByDDL(CreateHiveTableByDDLRequest req)
        {
             JsonResponseModel<CreateHiveTableByDDLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHiveTableByDDL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHiveTableByDDLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建hive表，返回表名称
        /// </summary>
        /// <param name="req"><see cref="CreateHiveTableByDDLRequest"/></param>
        /// <returns><see cref="CreateHiveTableByDDLResponse"/></returns>
        public CreateHiveTableByDDLResponse CreateHiveTableByDDLSync(CreateHiveTableByDDLRequest req)
        {
             JsonResponseModel<CreateHiveTableByDDLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHiveTableByDDL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHiveTableByDDLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册采集器
        /// </summary>
        /// <param name="req"><see cref="CreateInLongAgentRequest"/></param>
        /// <returns><see cref="CreateInLongAgentResponse"/></returns>
        public async Task<CreateInLongAgentResponse> CreateInLongAgent(CreateInLongAgentRequest req)
        {
             JsonResponseModel<CreateInLongAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInLongAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInLongAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册采集器
        /// </summary>
        /// <param name="req"><see cref="CreateInLongAgentRequest"/></param>
        /// <returns><see cref="CreateInLongAgentResponse"/></returns>
        public CreateInLongAgentResponse CreateInLongAgentSync(CreateInLongAgentRequest req)
        {
             JsonResponseModel<CreateInLongAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInLongAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInLongAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集成节点
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationNodeRequest"/></param>
        /// <returns><see cref="CreateIntegrationNodeResponse"/></returns>
        public async Task<CreateIntegrationNodeResponse> CreateIntegrationNode(CreateIntegrationNodeRequest req)
        {
             JsonResponseModel<CreateIntegrationNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIntegrationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntegrationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集成节点
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationNodeRequest"/></param>
        /// <returns><see cref="CreateIntegrationNodeResponse"/></returns>
        public CreateIntegrationNodeResponse CreateIntegrationNodeSync(CreateIntegrationNodeRequest req)
        {
             JsonResponseModel<CreateIntegrationNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIntegrationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntegrationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集成任务
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationTaskRequest"/></param>
        /// <returns><see cref="CreateIntegrationTaskResponse"/></returns>
        public async Task<CreateIntegrationTaskResponse> CreateIntegrationTask(CreateIntegrationTaskRequest req)
        {
             JsonResponseModel<CreateIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集成任务
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationTaskRequest"/></param>
        /// <returns><see cref="CreateIntegrationTaskResponse"/></returns>
        public CreateIntegrationTaskResponse CreateIntegrationTaskSync(CreateIntegrationTaskRequest req)
        {
             JsonResponseModel<CreateIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建离线任务
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineTaskRequest"/></param>
        /// <returns><see cref="CreateOfflineTaskResponse"/></returns>
        public async Task<CreateOfflineTaskResponse> CreateOfflineTask(CreateOfflineTaskRequest req)
        {
             JsonResponseModel<CreateOfflineTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOfflineTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOfflineTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建离线任务
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineTaskRequest"/></param>
        /// <returns><see cref="CreateOfflineTaskResponse"/></returns>
        public CreateOfflineTaskResponse CreateOfflineTaskSync(CreateOfflineTaskRequest req)
        {
             JsonResponseModel<CreateOfflineTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOfflineTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOfflineTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资源管理需要先将资源上传到cos中，然后调用该接口，将cos资源绑定到wedata
        /// </summary>
        /// <param name="req"><see cref="CreateOrUpdateResourceRequest"/></param>
        /// <returns><see cref="CreateOrUpdateResourceResponse"/></returns>
        public async Task<CreateOrUpdateResourceResponse> CreateOrUpdateResource(CreateOrUpdateResourceRequest req)
        {
             JsonResponseModel<CreateOrUpdateResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrUpdateResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrUpdateResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资源管理需要先将资源上传到cos中，然后调用该接口，将cos资源绑定到wedata
        /// </summary>
        /// <param name="req"><see cref="CreateOrUpdateResourceRequest"/></param>
        /// <returns><see cref="CreateOrUpdateResourceResponse"/></returns>
        public CreateOrUpdateResourceResponse CreateOrUpdateResourceSync(CreateOrUpdateResourceRequest req)
        {
             JsonResponseModel<CreateOrUpdateResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrUpdateResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrUpdateResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文件路径的根目录为 /datastudio/resource，如果要在根目录下创建 aaa 文件夹，FilePath的值应该为 /datastudio/resource，如果根目录下已经创建了 aaa 文件夹，要在 aaa 下创建  bbb 文件夹，FilePath的值应该为 /datastudio/resource/aaa
        /// </summary>
        /// <param name="req"><see cref="CreateResourcePathRequest"/></param>
        /// <returns><see cref="CreateResourcePathResponse"/></returns>
        public async Task<CreateResourcePathResponse> CreateResourcePath(CreateResourcePathRequest req)
        {
             JsonResponseModel<CreateResourcePathResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateResourcePath");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourcePathResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文件路径的根目录为 /datastudio/resource，如果要在根目录下创建 aaa 文件夹，FilePath的值应该为 /datastudio/resource，如果根目录下已经创建了 aaa 文件夹，要在 aaa 下创建  bbb 文件夹，FilePath的值应该为 /datastudio/resource/aaa
        /// </summary>
        /// <param name="req"><see cref="CreateResourcePathRequest"/></param>
        /// <returns><see cref="CreateResourcePathResponse"/></returns>
        public CreateResourcePathResponse CreateResourcePathSync(CreateResourcePathRequest req)
        {
             JsonResponseModel<CreateResourcePathResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateResourcePath");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourcePathResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建质量规则接口
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public async Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建质量规则接口
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建规则模版
        /// </summary>
        /// <param name="req"><see cref="CreateRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateRuleTemplateResponse"/></returns>
        public async Task<CreateRuleTemplateResponse> CreateRuleTemplate(CreateRuleTemplateRequest req)
        {
             JsonResponseModel<CreateRuleTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRuleTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建规则模版
        /// </summary>
        /// <param name="req"><see cref="CreateRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateRuleTemplateResponse"/></returns>
        public CreateRuleTemplateResponse CreateRuleTemplateSync(CreateRuleTemplateRequest req)
        {
             JsonResponseModel<CreateRuleTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRuleTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public async Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建任务告警规则
        /// </summary>
        /// <param name="req"><see cref="CreateTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="CreateTaskAlarmRegularResponse"/></returns>
        public async Task<CreateTaskAlarmRegularResponse> CreateTaskAlarmRegular(CreateTaskAlarmRegularRequest req)
        {
             JsonResponseModel<CreateTaskAlarmRegularResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTaskAlarmRegular");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskAlarmRegularResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建任务告警规则
        /// </summary>
        /// <param name="req"><see cref="CreateTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="CreateTaskAlarmRegularResponse"/></returns>
        public CreateTaskAlarmRegularResponse CreateTaskAlarmRegularSync(CreateTaskAlarmRegularRequest req)
        {
             JsonResponseModel<CreateTaskAlarmRegularResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTaskAlarmRegular");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskAlarmRegularResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public async Task<CreateWorkflowResponse> CreateWorkflow(CreateWorkflowRequest req)
        {
             JsonResponseModel<CreateWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public CreateWorkflowResponse CreateWorkflowSync(CreateWorkflowRequest req)
        {
             JsonResponseModel<CreateWorkflowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomFunctionRequest"/></param>
        /// <returns><see cref="DeleteCustomFunctionResponse"/></returns>
        public async Task<DeleteCustomFunctionResponse> DeleteCustomFunction(DeleteCustomFunctionRequest req)
        {
             JsonResponseModel<DeleteCustomFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomFunctionRequest"/></param>
        /// <returns><see cref="DeleteCustomFunctionResponse"/></returns>
        public DeleteCustomFunctionResponse DeleteCustomFunctionSync(DeleteCustomFunctionRequest req)
        {
             JsonResponseModel<DeleteCustomFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCustomFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourcesRequest"/></param>
        /// <returns><see cref="DeleteDataSourcesResponse"/></returns>
        public async Task<DeleteDataSourcesResponse> DeleteDataSources(DeleteDataSourcesRequest req)
        {
             JsonResponseModel<DeleteDataSourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDataSources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDataSourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourcesRequest"/></param>
        /// <returns><see cref="DeleteDataSourcesResponse"/></returns>
        public DeleteDataSourcesResponse DeleteDataSourcesSync(DeleteDataSourcesRequest req)
        {
             JsonResponseModel<DeleteDataSourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDataSources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDataSourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteFolderRequest"/></param>
        /// <returns><see cref="DeleteFolderResponse"/></returns>
        public async Task<DeleteFolderResponse> DeleteFolder(DeleteFolderRequest req)
        {
             JsonResponseModel<DeleteFolderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFolder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFolderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteFolderRequest"/></param>
        /// <returns><see cref="DeleteFolderResponse"/></returns>
        public DeleteFolderResponse DeleteFolderSync(DeleteFolderRequest req)
        {
             JsonResponseModel<DeleteFolderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFolder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFolderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除采集器
        /// </summary>
        /// <param name="req"><see cref="DeleteInLongAgentRequest"/></param>
        /// <returns><see cref="DeleteInLongAgentResponse"/></returns>
        public async Task<DeleteInLongAgentResponse> DeleteInLongAgent(DeleteInLongAgentRequest req)
        {
             JsonResponseModel<DeleteInLongAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInLongAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInLongAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除采集器
        /// </summary>
        /// <param name="req"><see cref="DeleteInLongAgentRequest"/></param>
        /// <returns><see cref="DeleteInLongAgentResponse"/></returns>
        public DeleteInLongAgentResponse DeleteInLongAgentSync(DeleteInLongAgentRequest req)
        {
             JsonResponseModel<DeleteInLongAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInLongAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInLongAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集成节点
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationNodeRequest"/></param>
        /// <returns><see cref="DeleteIntegrationNodeResponse"/></returns>
        public async Task<DeleteIntegrationNodeResponse> DeleteIntegrationNode(DeleteIntegrationNodeRequest req)
        {
             JsonResponseModel<DeleteIntegrationNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIntegrationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntegrationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集成节点
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationNodeRequest"/></param>
        /// <returns><see cref="DeleteIntegrationNodeResponse"/></returns>
        public DeleteIntegrationNodeResponse DeleteIntegrationNodeSync(DeleteIntegrationNodeRequest req)
        {
             JsonResponseModel<DeleteIntegrationNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIntegrationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntegrationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集成任务
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationTaskRequest"/></param>
        /// <returns><see cref="DeleteIntegrationTaskResponse"/></returns>
        public async Task<DeleteIntegrationTaskResponse> DeleteIntegrationTask(DeleteIntegrationTaskRequest req)
        {
             JsonResponseModel<DeleteIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集成任务
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationTaskRequest"/></param>
        /// <returns><see cref="DeleteIntegrationTaskResponse"/></returns>
        public DeleteIntegrationTaskResponse DeleteIntegrationTaskSync(DeleteIntegrationTaskRequest req)
        {
             JsonResponseModel<DeleteIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineTaskRequest"/></param>
        /// <returns><see cref="DeleteOfflineTaskResponse"/></returns>
        public async Task<DeleteOfflineTaskResponse> DeleteOfflineTask(DeleteOfflineTaskRequest req)
        {
             JsonResponseModel<DeleteOfflineTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOfflineTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOfflineTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineTaskRequest"/></param>
        /// <returns><see cref="DeleteOfflineTaskResponse"/></returns>
        public DeleteOfflineTaskResponse DeleteOfflineTaskSync(DeleteOfflineTaskRequest req)
        {
             JsonResponseModel<DeleteOfflineTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOfflineTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOfflineTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资源管理删除资源
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceRequest"/></param>
        /// <returns><see cref="DeleteResourceResponse"/></returns>
        public async Task<DeleteResourceResponse> DeleteResource(DeleteResourceRequest req)
        {
             JsonResponseModel<DeleteResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资源管理删除资源
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceRequest"/></param>
        /// <returns><see cref="DeleteResourceResponse"/></returns>
        public DeleteResourceResponse DeleteResourceSync(DeleteResourceRequest req)
        {
             JsonResponseModel<DeleteResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除质量规则接口
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public async Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除质量规则接口
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则模版
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleTemplateRequest"/></param>
        /// <returns><see cref="DeleteRuleTemplateResponse"/></returns>
        public async Task<DeleteRuleTemplateResponse> DeleteRuleTemplate(DeleteRuleTemplateRequest req)
        {
             JsonResponseModel<DeleteRuleTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRuleTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则模版
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleTemplateRequest"/></param>
        /// <returns><see cref="DeleteRuleTemplateResponse"/></returns>
        public DeleteRuleTemplateResponse DeleteRuleTemplateSync(DeleteRuleTemplateRequest req)
        {
             JsonResponseModel<DeleteRuleTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRuleTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务告警规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="DeleteTaskAlarmRegularResponse"/></returns>
        public async Task<DeleteTaskAlarmRegularResponse> DeleteTaskAlarmRegular(DeleteTaskAlarmRegularRequest req)
        {
             JsonResponseModel<DeleteTaskAlarmRegularResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTaskAlarmRegular");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskAlarmRegularResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务告警规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="DeleteTaskAlarmRegularResponse"/></returns>
        public DeleteTaskAlarmRegularResponse DeleteTaskAlarmRegularSync(DeleteTaskAlarmRegularRequest req)
        {
             JsonResponseModel<DeleteTaskAlarmRegularResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTaskAlarmRegular");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskAlarmRegularResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除工作流
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowNewRequest"/></param>
        /// <returns><see cref="DeleteWorkflowNewResponse"/></returns>
        public async Task<DeleteWorkflowNewResponse> DeleteWorkflowNew(DeleteWorkflowNewRequest req)
        {
             JsonResponseModel<DeleteWorkflowNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWorkflowNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWorkflowNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除工作流
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowNewRequest"/></param>
        /// <returns><see cref="DeleteWorkflowNewResponse"/></returns>
        public DeleteWorkflowNewResponse DeleteWorkflowNewSync(DeleteWorkflowNewRequest req)
        {
             JsonResponseModel<DeleteWorkflowNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWorkflowNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWorkflowNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public async Task<DescribeAlarmEventsResponse> DescribeAlarmEvents(DescribeAlarmEventsRequest req)
        {
             JsonResponseModel<DescribeAlarmEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public DescribeAlarmEventsResponse DescribeAlarmEventsSync(DescribeAlarmEventsRequest req)
        {
             JsonResponseModel<DescribeAlarmEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警接收人详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmReceiverRequest"/></param>
        /// <returns><see cref="DescribeAlarmReceiverResponse"/></returns>
        public async Task<DescribeAlarmReceiverResponse> DescribeAlarmReceiver(DescribeAlarmReceiverRequest req)
        {
             JsonResponseModel<DescribeAlarmReceiverResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警接收人详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmReceiverRequest"/></param>
        /// <returns><see cref="DescribeAlarmReceiverResponse"/></returns>
        public DescribeAlarmReceiverResponse DescribeAlarmReceiverSync(DescribeAlarmReceiverRequest req)
        {
             JsonResponseModel<DescribeAlarmReceiverResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeClusterNamespaceListResponse"/></returns>
        public async Task<DescribeClusterNamespaceListResponse> DescribeClusterNamespaceList(DescribeClusterNamespaceListRequest req)
        {
             JsonResponseModel<DescribeClusterNamespaceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterNamespaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNamespaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeClusterNamespaceListResponse"/></returns>
        public DescribeClusterNamespaceListResponse DescribeClusterNamespaceListSync(DescribeClusterNamespaceListRequest req)
        {
             JsonResponseModel<DescribeClusterNamespaceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterNamespaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNamespaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据来源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataBasesRequest"/></param>
        /// <returns><see cref="DescribeDataBasesResponse"/></returns>
        public async Task<DescribeDataBasesResponse> DescribeDataBases(DescribeDataBasesRequest req)
        {
             JsonResponseModel<DescribeDataBasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataBases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataBasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据来源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataBasesRequest"/></param>
        /// <returns><see cref="DescribeDataBasesResponse"/></returns>
        public DescribeDataBasesResponse DescribeDataBasesSync(DescribeDataBasesRequest req)
        {
             JsonResponseModel<DescribeDataBasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataBases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataBasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量的概览页面数据监测情况接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCheckStatRequest"/></param>
        /// <returns><see cref="DescribeDataCheckStatResponse"/></returns>
        public async Task<DescribeDataCheckStatResponse> DescribeDataCheckStat(DescribeDataCheckStatRequest req)
        {
             JsonResponseModel<DescribeDataCheckStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataCheckStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataCheckStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量的概览页面数据监测情况接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCheckStatRequest"/></param>
        /// <returns><see cref="DescribeDataCheckStatResponse"/></returns>
        public DescribeDataCheckStatResponse DescribeDataCheckStatSync(DescribeDataCheckStatRequest req)
        {
             JsonResponseModel<DescribeDataCheckStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataCheckStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataCheckStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则组数据对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataObjectsRequest"/></param>
        /// <returns><see cref="DescribeDataObjectsResponse"/></returns>
        public async Task<DescribeDataObjectsResponse> DescribeDataObjects(DescribeDataObjectsRequest req)
        {
             JsonResponseModel<DescribeDataObjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则组数据对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataObjectsRequest"/></param>
        /// <returns><see cref="DescribeDataObjectsResponse"/></returns>
        public DescribeDataObjectsResponse DescribeDataObjectsSync(DescribeDataObjectsRequest req)
        {
             JsonResponseModel<DescribeDataObjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据源信息-数据源分页列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceInfoListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceInfoListResponse"/></returns>
        public async Task<DescribeDataSourceInfoListResponse> DescribeDataSourceInfoList(DescribeDataSourceInfoListRequest req)
        {
             JsonResponseModel<DescribeDataSourceInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataSourceInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataSourceInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据源信息-数据源分页列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceInfoListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceInfoListResponse"/></returns>
        public DescribeDataSourceInfoListResponse DescribeDataSourceInfoListSync(DescribeDataSourceInfoListRequest req)
        {
             JsonResponseModel<DescribeDataSourceInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataSourceInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataSourceInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceListResponse"/></returns>
        public async Task<DescribeDataSourceListResponse> DescribeDataSourceList(DescribeDataSourceListRequest req)
        {
             JsonResponseModel<DescribeDataSourceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataSourceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataSourceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceListResponse"/></returns>
        public DescribeDataSourceListResponse DescribeDataSourceListSync(DescribeDataSourceListRequest req)
        {
             JsonResponseModel<DescribeDataSourceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataSourceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataSourceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceWithoutInfoRequest"/></param>
        /// <returns><see cref="DescribeDataSourceWithoutInfoResponse"/></returns>
        public async Task<DescribeDataSourceWithoutInfoResponse> DescribeDataSourceWithoutInfo(DescribeDataSourceWithoutInfoRequest req)
        {
             JsonResponseModel<DescribeDataSourceWithoutInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataSourceWithoutInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataSourceWithoutInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceWithoutInfoRequest"/></param>
        /// <returns><see cref="DescribeDataSourceWithoutInfoResponse"/></returns>
        public DescribeDataSourceWithoutInfoResponse DescribeDataSourceWithoutInfoSync(DescribeDataSourceWithoutInfoRequest req)
        {
             JsonResponseModel<DescribeDataSourceWithoutInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataSourceWithoutInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataSourceWithoutInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取字段类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataTypesRequest"/></param>
        /// <returns><see cref="DescribeDataTypesResponse"/></returns>
        public async Task<DescribeDataTypesResponse> DescribeDataTypes(DescribeDataTypesRequest req)
        {
             JsonResponseModel<DescribeDataTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取字段类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataTypesRequest"/></param>
        /// <returns><see cref="DescribeDataTypesResponse"/></returns>
        public DescribeDataTypesResponse DescribeDataTypesSync(DescribeDataTypesRequest req)
        {
             JsonResponseModel<DescribeDataTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseInfoListRequest"/></param>
        /// <returns><see cref="DescribeDatabaseInfoListResponse"/></returns>
        public async Task<DescribeDatabaseInfoListResponse> DescribeDatabaseInfoList(DescribeDatabaseInfoListRequest req)
        {
             JsonResponseModel<DescribeDatabaseInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabaseInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseInfoListRequest"/></param>
        /// <returns><see cref="DescribeDatabaseInfoListResponse"/></returns>
        public DescribeDatabaseInfoListResponse DescribeDatabaseInfoListSync(DescribeDatabaseInfoListRequest req)
        {
             JsonResponseModel<DescribeDatabaseInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatabaseInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceRequest"/></param>
        /// <returns><see cref="DescribeDatasourceResponse"/></returns>
        public async Task<DescribeDatasourceResponse> DescribeDatasource(DescribeDatasourceRequest req)
        {
             JsonResponseModel<DescribeDatasourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatasource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceRequest"/></param>
        /// <returns><see cref="DescribeDatasourceResponse"/></returns>
        public DescribeDatasourceResponse DescribeDatasourceSync(DescribeDatasourceRequest req)
        {
             JsonResponseModel<DescribeDatasourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatasource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 根据层级查找上/下游任务节点
        /// </summary>
        /// <param name="req"><see cref="DescribeDependTasksNewRequest"/></param>
        /// <returns><see cref="DescribeDependTasksNewResponse"/></returns>
        public async Task<DescribeDependTasksNewResponse> DescribeDependTasksNew(DescribeDependTasksNewRequest req)
        {
             JsonResponseModel<DescribeDependTasksNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDependTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDependTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 根据层级查找上/下游任务节点
        /// </summary>
        /// <param name="req"><see cref="DescribeDependTasksNewRequest"/></param>
        /// <returns><see cref="DescribeDependTasksNewResponse"/></returns>
        public DescribeDependTasksNewResponse DescribeDependTasksNewSync(DescribeDependTasksNewRequest req)
        {
             JsonResponseModel<DescribeDependTasksNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDependTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDependTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 质量报告-查询质量评分
        /// </summary>
        /// <param name="req"><see cref="DescribeDimensionScoreRequest"/></param>
        /// <returns><see cref="DescribeDimensionScoreResponse"/></returns>
        public async Task<DescribeDimensionScoreResponse> DescribeDimensionScore(DescribeDimensionScoreRequest req)
        {
             JsonResponseModel<DescribeDimensionScoreResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDimensionScore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDimensionScoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 质量报告-查询质量评分
        /// </summary>
        /// <param name="req"><see cref="DescribeDimensionScoreRequest"/></param>
        /// <returns><see cref="DescribeDimensionScoreResponse"/></returns>
        public DescribeDimensionScoreResponse DescribeDimensionScoreSync(DescribeDimensionScoreRequest req)
        {
             JsonResponseModel<DescribeDimensionScoreResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDimensionScore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDimensionScoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则组执行策略
        /// </summary>
        /// <param name="req"><see cref="DescribeExecStrategyRequest"/></param>
        /// <returns><see cref="DescribeExecStrategyResponse"/></returns>
        public async Task<DescribeExecStrategyResponse> DescribeExecStrategy(DescribeExecStrategyRequest req)
        {
             JsonResponseModel<DescribeExecStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExecStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExecStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则组执行策略
        /// </summary>
        /// <param name="req"><see cref="DescribeExecStrategyRequest"/></param>
        /// <returns><see cref="DescribeExecStrategyResponse"/></returns>
        public DescribeExecStrategyResponse DescribeExecStrategySync(DescribeExecStrategyRequest req)
        {
             JsonResponseModel<DescribeExecStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExecStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExecStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 拉取文件夹目录
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderListRequest"/></param>
        /// <returns><see cref="DescribeFolderListResponse"/></returns>
        public async Task<DescribeFolderListResponse> DescribeFolderList(DescribeFolderListRequest req)
        {
             JsonResponseModel<DescribeFolderListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFolderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFolderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 拉取文件夹目录
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderListRequest"/></param>
        /// <returns><see cref="DescribeFolderListResponse"/></returns>
        public DescribeFolderListResponse DescribeFolderListSync(DescribeFolderListRequest req)
        {
             JsonResponseModel<DescribeFolderListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFolderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFolderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 拉取文件夹下的工作流
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderWorkflowListRequest"/></param>
        /// <returns><see cref="DescribeFolderWorkflowListResponse"/></returns>
        public async Task<DescribeFolderWorkflowListResponse> DescribeFolderWorkflowList(DescribeFolderWorkflowListRequest req)
        {
             JsonResponseModel<DescribeFolderWorkflowListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFolderWorkflowList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFolderWorkflowListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 拉取文件夹下的工作流
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderWorkflowListRequest"/></param>
        /// <returns><see cref="DescribeFolderWorkflowListResponse"/></returns>
        public DescribeFolderWorkflowListResponse DescribeFolderWorkflowListSync(DescribeFolderWorkflowListRequest req)
        {
             JsonResponseModel<DescribeFolderWorkflowListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFolderWorkflowList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFolderWorkflowListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询函数分类
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionKindsRequest"/></param>
        /// <returns><see cref="DescribeFunctionKindsResponse"/></returns>
        public async Task<DescribeFunctionKindsResponse> DescribeFunctionKinds(DescribeFunctionKindsRequest req)
        {
             JsonResponseModel<DescribeFunctionKindsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFunctionKinds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFunctionKindsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询函数分类
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionKindsRequest"/></param>
        /// <returns><see cref="DescribeFunctionKindsResponse"/></returns>
        public DescribeFunctionKindsResponse DescribeFunctionKindsSync(DescribeFunctionKindsRequest req)
        {
             JsonResponseModel<DescribeFunctionKindsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFunctionKinds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFunctionKindsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询函数类型
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionTypesRequest"/></param>
        /// <returns><see cref="DescribeFunctionTypesResponse"/></returns>
        public async Task<DescribeFunctionTypesResponse> DescribeFunctionTypes(DescribeFunctionTypesRequest req)
        {
             JsonResponseModel<DescribeFunctionTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFunctionTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFunctionTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询函数类型
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionTypesRequest"/></param>
        /// <returns><see cref="DescribeFunctionTypesResponse"/></returns>
        public DescribeFunctionTypesResponse DescribeFunctionTypesSync(DescribeFunctionTypesRequest req)
        {
             JsonResponseModel<DescribeFunctionTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFunctionTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFunctionTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取采集器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongAgentListRequest"/></param>
        /// <returns><see cref="DescribeInLongAgentListResponse"/></returns>
        public async Task<DescribeInLongAgentListResponse> DescribeInLongAgentList(DescribeInLongAgentListRequest req)
        {
             JsonResponseModel<DescribeInLongAgentListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInLongAgentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInLongAgentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取采集器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongAgentListRequest"/></param>
        /// <returns><see cref="DescribeInLongAgentListResponse"/></returns>
        public DescribeInLongAgentListResponse DescribeInLongAgentListSync(DescribeInLongAgentListRequest req)
        {
             JsonResponseModel<DescribeInLongAgentListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInLongAgentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInLongAgentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询采集器关联的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongAgentTaskListRequest"/></param>
        /// <returns><see cref="DescribeInLongAgentTaskListResponse"/></returns>
        public async Task<DescribeInLongAgentTaskListResponse> DescribeInLongAgentTaskList(DescribeInLongAgentTaskListRequest req)
        {
             JsonResponseModel<DescribeInLongAgentTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInLongAgentTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInLongAgentTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询采集器关联的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongAgentTaskListRequest"/></param>
        /// <returns><see cref="DescribeInLongAgentTaskListResponse"/></returns>
        public DescribeInLongAgentTaskListResponse DescribeInLongAgentTaskListSync(DescribeInLongAgentTaskListRequest req)
        {
             JsonResponseModel<DescribeInLongAgentTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInLongAgentTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInLongAgentTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取采集器所在集群的VPC列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongAgentVpcListRequest"/></param>
        /// <returns><see cref="DescribeInLongAgentVpcListResponse"/></returns>
        public async Task<DescribeInLongAgentVpcListResponse> DescribeInLongAgentVpcList(DescribeInLongAgentVpcListRequest req)
        {
             JsonResponseModel<DescribeInLongAgentVpcListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInLongAgentVpcList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInLongAgentVpcListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取采集器所在集群的VPC列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongAgentVpcListRequest"/></param>
        /// <returns><see cref="DescribeInLongAgentVpcListResponse"/></returns>
        public DescribeInLongAgentVpcListResponse DescribeInLongAgentVpcListSync(DescribeInLongAgentVpcListRequest req)
        {
             JsonResponseModel<DescribeInLongAgentVpcListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInLongAgentVpcList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInLongAgentVpcListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TKE集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongTkeClusterListRequest"/></param>
        /// <returns><see cref="DescribeInLongTkeClusterListResponse"/></returns>
        public async Task<DescribeInLongTkeClusterListResponse> DescribeInLongTkeClusterList(DescribeInLongTkeClusterListRequest req)
        {
             JsonResponseModel<DescribeInLongTkeClusterListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInLongTkeClusterList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInLongTkeClusterListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TKE集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongTkeClusterListRequest"/></param>
        /// <returns><see cref="DescribeInLongTkeClusterListResponse"/></returns>
        public DescribeInLongTkeClusterListResponse DescribeInLongTkeClusterListSync(DescribeInLongTkeClusterListRequest req)
        {
             JsonResponseModel<DescribeInLongTkeClusterListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInLongTkeClusterList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInLongTkeClusterListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 日志获取详情页面
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLastLogRequest"/></param>
        /// <returns><see cref="DescribeInstanceLastLogResponse"/></returns>
        public async Task<DescribeInstanceLastLogResponse> DescribeInstanceLastLog(DescribeInstanceLastLogRequest req)
        {
             JsonResponseModel<DescribeInstanceLastLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceLastLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLastLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 日志获取详情页面
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLastLogRequest"/></param>
        /// <returns><see cref="DescribeInstanceLastLogResponse"/></returns>
        public DescribeInstanceLastLogResponse DescribeInstanceLastLogSync(DescribeInstanceLastLogRequest req)
        {
             JsonResponseModel<DescribeInstanceLastLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceLastLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLastLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public async Task<DescribeInstanceListResponse> DescribeInstanceList(DescribeInstanceListRequest req)
        {
             JsonResponseModel<DescribeInstanceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public DescribeInstanceListResponse DescribeInstanceListSync(DescribeInstanceListRequest req)
        {
             JsonResponseModel<DescribeInstanceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例运行日志
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogResponse"/></returns>
        public async Task<DescribeInstanceLogResponse> DescribeInstanceLog(DescribeInstanceLogRequest req)
        {
             JsonResponseModel<DescribeInstanceLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例运行日志
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogResponse"/></returns>
        public DescribeInstanceLogResponse DescribeInstanceLogSync(DescribeInstanceLogRequest req)
        {
             JsonResponseModel<DescribeInstanceLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 离线任务实例运行日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogListRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogListResponse"/></returns>
        public async Task<DescribeInstanceLogListResponse> DescribeInstanceLogList(DescribeInstanceLogListRequest req)
        {
             JsonResponseModel<DescribeInstanceLogListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceLogList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 离线任务实例运行日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogListRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogListResponse"/></returns>
        public DescribeInstanceLogListResponse DescribeInstanceLogListSync(DescribeInstanceLogListRequest req)
        {
             JsonResponseModel<DescribeInstanceLogListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceLogList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 获取实例日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public async Task<DescribeInstanceLogsResponse> DescribeInstanceLogs(DescribeInstanceLogsRequest req)
        {
             JsonResponseModel<DescribeInstanceLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 获取实例日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public DescribeInstanceLogsResponse DescribeInstanceLogsSync(DescribeInstanceLogsRequest req)
        {
             JsonResponseModel<DescribeInstanceLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量，查询调度任务的实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量，查询调度任务的实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集成节点
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationNodeRequest"/></param>
        /// <returns><see cref="DescribeIntegrationNodeResponse"/></returns>
        public async Task<DescribeIntegrationNodeResponse> DescribeIntegrationNode(DescribeIntegrationNodeRequest req)
        {
             JsonResponseModel<DescribeIntegrationNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集成节点
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationNodeRequest"/></param>
        /// <returns><see cref="DescribeIntegrationNodeResponse"/></returns>
        public DescribeIntegrationNodeResponse DescribeIntegrationNodeSync(DescribeIntegrationNodeRequest req)
        {
             JsonResponseModel<DescribeIntegrationNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据集成大屏概览
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsResponse"/></returns>
        public async Task<DescribeIntegrationStatisticsResponse> DescribeIntegrationStatistics(DescribeIntegrationStatisticsRequest req)
        {
             JsonResponseModel<DescribeIntegrationStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据集成大屏概览
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsResponse"/></returns>
        public DescribeIntegrationStatisticsResponse DescribeIntegrationStatisticsSync(DescribeIntegrationStatisticsRequest req)
        {
             JsonResponseModel<DescribeIntegrationStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据集成大屏采集器状态分布统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsAgentStatusRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsAgentStatusResponse"/></returns>
        public async Task<DescribeIntegrationStatisticsAgentStatusResponse> DescribeIntegrationStatisticsAgentStatus(DescribeIntegrationStatisticsAgentStatusRequest req)
        {
             JsonResponseModel<DescribeIntegrationStatisticsAgentStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationStatisticsAgentStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationStatisticsAgentStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据集成大屏采集器状态分布统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsAgentStatusRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsAgentStatusResponse"/></returns>
        public DescribeIntegrationStatisticsAgentStatusResponse DescribeIntegrationStatisticsAgentStatusSync(DescribeIntegrationStatisticsAgentStatusRequest req)
        {
             JsonResponseModel<DescribeIntegrationStatisticsAgentStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationStatisticsAgentStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationStatisticsAgentStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据集成大屏实例状态统计趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsInstanceTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsInstanceTrendResponse"/></returns>
        public async Task<DescribeIntegrationStatisticsInstanceTrendResponse> DescribeIntegrationStatisticsInstanceTrend(DescribeIntegrationStatisticsInstanceTrendRequest req)
        {
             JsonResponseModel<DescribeIntegrationStatisticsInstanceTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationStatisticsInstanceTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationStatisticsInstanceTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据集成大屏实例状态统计趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsInstanceTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsInstanceTrendResponse"/></returns>
        public DescribeIntegrationStatisticsInstanceTrendResponse DescribeIntegrationStatisticsInstanceTrendSync(DescribeIntegrationStatisticsInstanceTrendRequest req)
        {
             JsonResponseModel<DescribeIntegrationStatisticsInstanceTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationStatisticsInstanceTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationStatisticsInstanceTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据集成大屏同步条数统计趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsRecordsTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsRecordsTrendResponse"/></returns>
        public async Task<DescribeIntegrationStatisticsRecordsTrendResponse> DescribeIntegrationStatisticsRecordsTrend(DescribeIntegrationStatisticsRecordsTrendRequest req)
        {
             JsonResponseModel<DescribeIntegrationStatisticsRecordsTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationStatisticsRecordsTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationStatisticsRecordsTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据集成大屏同步条数统计趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsRecordsTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsRecordsTrendResponse"/></returns>
        public DescribeIntegrationStatisticsRecordsTrendResponse DescribeIntegrationStatisticsRecordsTrendSync(DescribeIntegrationStatisticsRecordsTrendRequest req)
        {
             JsonResponseModel<DescribeIntegrationStatisticsRecordsTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationStatisticsRecordsTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationStatisticsRecordsTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据集成大屏任务状态分布统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsTaskStatusResponse"/></returns>
        public async Task<DescribeIntegrationStatisticsTaskStatusResponse> DescribeIntegrationStatisticsTaskStatus(DescribeIntegrationStatisticsTaskStatusRequest req)
        {
             JsonResponseModel<DescribeIntegrationStatisticsTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationStatisticsTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationStatisticsTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据集成大屏任务状态分布统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsTaskStatusResponse"/></returns>
        public DescribeIntegrationStatisticsTaskStatusResponse DescribeIntegrationStatisticsTaskStatusSync(DescribeIntegrationStatisticsTaskStatusRequest req)
        {
             JsonResponseModel<DescribeIntegrationStatisticsTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationStatisticsTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationStatisticsTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据集成大屏任务状态统计趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsTaskStatusTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsTaskStatusTrendResponse"/></returns>
        public async Task<DescribeIntegrationStatisticsTaskStatusTrendResponse> DescribeIntegrationStatisticsTaskStatusTrend(DescribeIntegrationStatisticsTaskStatusTrendRequest req)
        {
             JsonResponseModel<DescribeIntegrationStatisticsTaskStatusTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationStatisticsTaskStatusTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationStatisticsTaskStatusTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据集成大屏任务状态统计趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsTaskStatusTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsTaskStatusTrendResponse"/></returns>
        public DescribeIntegrationStatisticsTaskStatusTrendResponse DescribeIntegrationStatisticsTaskStatusTrendSync(DescribeIntegrationStatisticsTaskStatusTrendRequest req)
        {
             JsonResponseModel<DescribeIntegrationStatisticsTaskStatusTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationStatisticsTaskStatusTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationStatisticsTaskStatusTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集成任务
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationTaskRequest"/></param>
        /// <returns><see cref="DescribeIntegrationTaskResponse"/></returns>
        public async Task<DescribeIntegrationTaskResponse> DescribeIntegrationTask(DescribeIntegrationTaskRequest req)
        {
             JsonResponseModel<DescribeIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集成任务
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationTaskRequest"/></param>
        /// <returns><see cref="DescribeIntegrationTaskResponse"/></returns>
        public DescribeIntegrationTaskResponse DescribeIntegrationTaskSync(DescribeIntegrationTaskRequest req)
        {
             JsonResponseModel<DescribeIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集成任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationTasksRequest"/></param>
        /// <returns><see cref="DescribeIntegrationTasksResponse"/></returns>
        public async Task<DescribeIntegrationTasksResponse> DescribeIntegrationTasks(DescribeIntegrationTasksRequest req)
        {
             JsonResponseModel<DescribeIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集成任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationTasksRequest"/></param>
        /// <returns><see cref="DescribeIntegrationTasksResponse"/></returns>
        public DescribeIntegrationTasksResponse DescribeIntegrationTasksSync(DescribeIntegrationTasksRequest req)
        {
             JsonResponseModel<DescribeIntegrationTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集成任务版本节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationVersionNodesInfoRequest"/></param>
        /// <returns><see cref="DescribeIntegrationVersionNodesInfoResponse"/></returns>
        public async Task<DescribeIntegrationVersionNodesInfoResponse> DescribeIntegrationVersionNodesInfo(DescribeIntegrationVersionNodesInfoRequest req)
        {
             JsonResponseModel<DescribeIntegrationVersionNodesInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationVersionNodesInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationVersionNodesInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集成任务版本节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationVersionNodesInfoRequest"/></param>
        /// <returns><see cref="DescribeIntegrationVersionNodesInfoResponse"/></returns>
        public DescribeIntegrationVersionNodesInfoResponse DescribeIntegrationVersionNodesInfoSync(DescribeIntegrationVersionNodesInfoRequest req)
        {
             JsonResponseModel<DescribeIntegrationVersionNodesInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationVersionNodesInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationVersionNodesInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取kafka的topic信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaTopicInfoRequest"/></param>
        /// <returns><see cref="DescribeKafkaTopicInfoResponse"/></returns>
        public async Task<DescribeKafkaTopicInfoResponse> DescribeKafkaTopicInfo(DescribeKafkaTopicInfoRequest req)
        {
             JsonResponseModel<DescribeKafkaTopicInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKafkaTopicInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKafkaTopicInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取kafka的topic信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaTopicInfoRequest"/></param>
        /// <returns><see cref="DescribeKafkaTopicInfoResponse"/></returns>
        public DescribeKafkaTopicInfoResponse DescribeKafkaTopicInfoSync(DescribeKafkaTopicInfoRequest req)
        {
             JsonResponseModel<DescribeKafkaTopicInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKafkaTopicInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKafkaTopicInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询质量监控组
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorsByPageRequest"/></param>
        /// <returns><see cref="DescribeMonitorsByPageResponse"/></returns>
        public async Task<DescribeMonitorsByPageResponse> DescribeMonitorsByPage(DescribeMonitorsByPageRequest req)
        {
             JsonResponseModel<DescribeMonitorsByPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMonitorsByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonitorsByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询质量监控组
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorsByPageRequest"/></param>
        /// <returns><see cref="DescribeMonitorsByPageResponse"/></returns>
        public DescribeMonitorsByPageResponse DescribeMonitorsByPageSync(DescribeMonitorsByPageRequest req)
        {
             JsonResponseModel<DescribeMonitorsByPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMonitorsByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonitorsByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取离线任务长连接Token
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineTaskTokenRequest"/></param>
        /// <returns><see cref="DescribeOfflineTaskTokenResponse"/></returns>
        public async Task<DescribeOfflineTaskTokenResponse> DescribeOfflineTaskToken(DescribeOfflineTaskTokenRequest req)
        {
             JsonResponseModel<DescribeOfflineTaskTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOfflineTaskToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineTaskTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取离线任务长连接Token
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineTaskTokenRequest"/></param>
        /// <returns><see cref="DescribeOfflineTaskTokenResponse"/></returns>
        public DescribeOfflineTaskTokenResponse DescribeOfflineTaskTokenSync(DescribeOfflineTaskTokenRequest req)
        {
             JsonResponseModel<DescribeOfflineTaskTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOfflineTaskToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineTaskTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询全量函数
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationalFunctionsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationalFunctionsResponse"/></returns>
        public async Task<DescribeOrganizationalFunctionsResponse> DescribeOrganizationalFunctions(DescribeOrganizationalFunctionsRequest req)
        {
             JsonResponseModel<DescribeOrganizationalFunctionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrganizationalFunctions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationalFunctionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询全量函数
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationalFunctionsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationalFunctionsResponse"/></returns>
        public DescribeOrganizationalFunctionsResponse DescribeOrganizationalFunctionsSync(DescribeOrganizationalFunctionsRequest req)
        {
             JsonResponseModel<DescribeOrganizationalFunctionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrganizationalFunctions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationalFunctionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量获取生产调度任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProdTasksRequest"/></param>
        /// <returns><see cref="DescribeProdTasksResponse"/></returns>
        public async Task<DescribeProdTasksResponse> DescribeProdTasks(DescribeProdTasksRequest req)
        {
             JsonResponseModel<DescribeProdTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProdTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProdTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量获取生产调度任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProdTasksRequest"/></param>
        /// <returns><see cref="DescribeProdTasksResponse"/></returns>
        public DescribeProdTasksResponse DescribeProdTasksSync(DescribeProdTasksRequest req)
        {
             JsonResponseModel<DescribeProdTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProdTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProdTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public async Task<DescribeProjectResponse> DescribeProject(DescribeProjectRequest req)
        {
             JsonResponseModel<DescribeProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public DescribeProjectResponse DescribeProjectSync(DescribeProjectRequest req)
        {
             JsonResponseModel<DescribeProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 质量报告-质量评分
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreResponse"/></returns>
        public async Task<DescribeQualityScoreResponse> DescribeQualityScore(DescribeQualityScoreRequest req)
        {
             JsonResponseModel<DescribeQualityScoreResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQualityScore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQualityScoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 质量报告-质量评分
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreResponse"/></returns>
        public DescribeQualityScoreResponse DescribeQualityScoreSync(DescribeQualityScoreRequest req)
        {
             JsonResponseModel<DescribeQualityScoreResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQualityScore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQualityScoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 质量报告-质量分周期趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreTrendRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreTrendResponse"/></returns>
        public async Task<DescribeQualityScoreTrendResponse> DescribeQualityScoreTrend(DescribeQualityScoreTrendRequest req)
        {
             JsonResponseModel<DescribeQualityScoreTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQualityScoreTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQualityScoreTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 质量报告-质量分周期趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreTrendRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreTrendResponse"/></returns>
        public DescribeQualityScoreTrendResponse DescribeQualityScoreTrendSync(DescribeQualityScoreTrendRequest req)
        {
             JsonResponseModel<DescribeQualityScoreTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQualityScoreTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQualityScoreTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实时任务实例节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskInstanceNodeInfoResponse"/></returns>
        public async Task<DescribeRealTimeTaskInstanceNodeInfoResponse> DescribeRealTimeTaskInstanceNodeInfo(DescribeRealTimeTaskInstanceNodeInfoRequest req)
        {
             JsonResponseModel<DescribeRealTimeTaskInstanceNodeInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealTimeTaskInstanceNodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealTimeTaskInstanceNodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实时任务实例节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskInstanceNodeInfoResponse"/></returns>
        public DescribeRealTimeTaskInstanceNodeInfoResponse DescribeRealTimeTaskInstanceNodeInfoSync(DescribeRealTimeTaskInstanceNodeInfoRequest req)
        {
             JsonResponseModel<DescribeRealTimeTaskInstanceNodeInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealTimeTaskInstanceNodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealTimeTaskInstanceNodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实时任务运行指标概览
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskMetricOverviewRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskMetricOverviewResponse"/></returns>
        public async Task<DescribeRealTimeTaskMetricOverviewResponse> DescribeRealTimeTaskMetricOverview(DescribeRealTimeTaskMetricOverviewRequest req)
        {
             JsonResponseModel<DescribeRealTimeTaskMetricOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealTimeTaskMetricOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealTimeTaskMetricOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实时任务运行指标概览
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskMetricOverviewRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskMetricOverviewResponse"/></returns>
        public DescribeRealTimeTaskMetricOverviewResponse DescribeRealTimeTaskMetricOverviewSync(DescribeRealTimeTaskMetricOverviewRequest req)
        {
             JsonResponseModel<DescribeRealTimeTaskMetricOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealTimeTaskMetricOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealTimeTaskMetricOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实时任务同步速度趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskSpeedRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskSpeedResponse"/></returns>
        public async Task<DescribeRealTimeTaskSpeedResponse> DescribeRealTimeTaskSpeed(DescribeRealTimeTaskSpeedRequest req)
        {
             JsonResponseModel<DescribeRealTimeTaskSpeedResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealTimeTaskSpeed");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealTimeTaskSpeedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实时任务同步速度趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskSpeedRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskSpeedResponse"/></returns>
        public DescribeRealTimeTaskSpeedResponse DescribeRealTimeTaskSpeedSync(DescribeRealTimeTaskSpeedRequest req)
        {
             JsonResponseModel<DescribeRealTimeTaskSpeedResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealTimeTaskSpeed");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealTimeTaskSpeedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务实例的关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedInstancesRequest"/></param>
        /// <returns><see cref="DescribeRelatedInstancesResponse"/></returns>
        public async Task<DescribeRelatedInstancesResponse> DescribeRelatedInstances(DescribeRelatedInstancesRequest req)
        {
             JsonResponseModel<DescribeRelatedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRelatedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelatedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务实例的关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedInstancesRequest"/></param>
        /// <returns><see cref="DescribeRelatedInstancesResponse"/></returns>
        public DescribeRelatedInstancesResponse DescribeRelatedInstancesSync(DescribeRelatedInstancesRequest req)
        {
             JsonResponseModel<DescribeRelatedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRelatedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelatedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资源管理目录树
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceManagePathTreesRequest"/></param>
        /// <returns><see cref="DescribeResourceManagePathTreesResponse"/></returns>
        public async Task<DescribeResourceManagePathTreesResponse> DescribeResourceManagePathTrees(DescribeResourceManagePathTreesRequest req)
        {
             JsonResponseModel<DescribeResourceManagePathTreesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceManagePathTrees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceManagePathTreesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资源管理目录树
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceManagePathTreesRequest"/></param>
        /// <returns><see cref="DescribeResourceManagePathTreesResponse"/></returns>
        public DescribeResourceManagePathTreesResponse DescribeResourceManagePathTreesSync(DescribeResourceManagePathTreesRequest req)
        {
             JsonResponseModel<DescribeResourceManagePathTreesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceManagePathTrees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceManagePathTreesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRequest"/></param>
        /// <returns><see cref="DescribeRuleResponse"/></returns>
        public async Task<DescribeRuleResponse> DescribeRule(DescribeRuleRequest req)
        {
             JsonResponseModel<DescribeRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRequest"/></param>
        /// <returns><see cref="DescribeRuleResponse"/></returns>
        public DescribeRuleResponse DescribeRuleSync(DescribeRuleRequest req)
        {
             JsonResponseModel<DescribeRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询质量规则数据源
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDataSourcesRequest"/></param>
        /// <returns><see cref="DescribeRuleDataSourcesResponse"/></returns>
        public async Task<DescribeRuleDataSourcesResponse> DescribeRuleDataSources(DescribeRuleDataSourcesRequest req)
        {
             JsonResponseModel<DescribeRuleDataSourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleDataSources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleDataSourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询质量规则数据源
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDataSourcesRequest"/></param>
        /// <returns><see cref="DescribeRuleDataSourcesResponse"/></returns>
        public DescribeRuleDataSourcesResponse DescribeRuleDataSourcesSync(DescribeRuleDataSourcesRequest req)
        {
             JsonResponseModel<DescribeRuleDataSourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleDataSources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleDataSourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量概览页面触发维度分布统计接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDimStatRequest"/></param>
        /// <returns><see cref="DescribeRuleDimStatResponse"/></returns>
        public async Task<DescribeRuleDimStatResponse> DescribeRuleDimStat(DescribeRuleDimStatRequest req)
        {
             JsonResponseModel<DescribeRuleDimStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleDimStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleDimStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量概览页面触发维度分布统计接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDimStatRequest"/></param>
        /// <returns><see cref="DescribeRuleDimStatResponse"/></returns>
        public DescribeRuleDimStatResponse DescribeRuleDimStatSync(DescribeRuleDimStatRequest req)
        {
             JsonResponseModel<DescribeRuleDimStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleDimStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleDimStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则执行结果详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleExecDetailResponse"/></returns>
        public async Task<DescribeRuleExecDetailResponse> DescribeRuleExecDetail(DescribeRuleExecDetailRequest req)
        {
             JsonResponseModel<DescribeRuleExecDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleExecDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则执行结果详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleExecDetailResponse"/></returns>
        public DescribeRuleExecDetailResponse DescribeRuleExecDetailSync(DescribeRuleExecDetailRequest req)
        {
             JsonResponseModel<DescribeRuleExecDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleExecDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则执行导出结果
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecExportResultRequest"/></param>
        /// <returns><see cref="DescribeRuleExecExportResultResponse"/></returns>
        public async Task<DescribeRuleExecExportResultResponse> DescribeRuleExecExportResult(DescribeRuleExecExportResultRequest req)
        {
             JsonResponseModel<DescribeRuleExecExportResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleExecExportResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecExportResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则执行导出结果
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecExportResultRequest"/></param>
        /// <returns><see cref="DescribeRuleExecExportResultResponse"/></returns>
        public DescribeRuleExecExportResultResponse DescribeRuleExecExportResultSync(DescribeRuleExecExportResultRequest req)
        {
             JsonResponseModel<DescribeRuleExecExportResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleExecExportResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecExportResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则执行历史， 最近30条
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecHistoryRequest"/></param>
        /// <returns><see cref="DescribeRuleExecHistoryResponse"/></returns>
        public async Task<DescribeRuleExecHistoryResponse> DescribeRuleExecHistory(DescribeRuleExecHistoryRequest req)
        {
             JsonResponseModel<DescribeRuleExecHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleExecHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则执行历史， 最近30条
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecHistoryRequest"/></param>
        /// <returns><see cref="DescribeRuleExecHistoryResponse"/></returns>
        public DescribeRuleExecHistoryResponse DescribeRuleExecHistorySync(DescribeRuleExecHistoryRequest req)
        {
             JsonResponseModel<DescribeRuleExecHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleExecHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 规则执行日志查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecLogRequest"/></param>
        /// <returns><see cref="DescribeRuleExecLogResponse"/></returns>
        public async Task<DescribeRuleExecLogResponse> DescribeRuleExecLog(DescribeRuleExecLogRequest req)
        {
             JsonResponseModel<DescribeRuleExecLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleExecLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 规则执行日志查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecLogRequest"/></param>
        /// <returns><see cref="DescribeRuleExecLogResponse"/></returns>
        public DescribeRuleExecLogResponse DescribeRuleExecLogSync(DescribeRuleExecLogRequest req)
        {
             JsonResponseModel<DescribeRuleExecLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleExecLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 规则执行结果列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecResultsRequest"/></param>
        /// <returns><see cref="DescribeRuleExecResultsResponse"/></returns>
        public async Task<DescribeRuleExecResultsResponse> DescribeRuleExecResults(DescribeRuleExecResultsRequest req)
        {
             JsonResponseModel<DescribeRuleExecResultsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleExecResults");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecResultsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 规则执行结果列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecResultsRequest"/></param>
        /// <returns><see cref="DescribeRuleExecResultsResponse"/></returns>
        public DescribeRuleExecResultsResponse DescribeRuleExecResultsSync(DescribeRuleExecResultsRequest req)
        {
             JsonResponseModel<DescribeRuleExecResultsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleExecResults");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecResultsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询规则执行结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecResultsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleExecResultsByPageResponse"/></returns>
        public async Task<DescribeRuleExecResultsByPageResponse> DescribeRuleExecResultsByPage(DescribeRuleExecResultsByPageRequest req)
        {
             JsonResponseModel<DescribeRuleExecResultsByPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleExecResultsByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecResultsByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询规则执行结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecResultsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleExecResultsByPageResponse"/></returns>
        public DescribeRuleExecResultsByPageResponse DescribeRuleExecResultsByPageSync(DescribeRuleExecResultsByPageRequest req)
        {
             JsonResponseModel<DescribeRuleExecResultsByPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleExecResultsByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecResultsByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量概览页面规则运行情况接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecStatRequest"/></param>
        /// <returns><see cref="DescribeRuleExecStatResponse"/></returns>
        public async Task<DescribeRuleExecStatResponse> DescribeRuleExecStat(DescribeRuleExecStatRequest req)
        {
             JsonResponseModel<DescribeRuleExecStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleExecStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量概览页面规则运行情况接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecStatRequest"/></param>
        /// <returns><see cref="DescribeRuleExecStatResponse"/></returns>
        public DescribeRuleExecStatResponse DescribeRuleExecStatSync(DescribeRuleExecStatRequest req)
        {
             JsonResponseModel<DescribeRuleExecStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleExecStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleExecStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则组详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupResponse"/></returns>
        public async Task<DescribeRuleGroupResponse> DescribeRuleGroup(DescribeRuleGroupRequest req)
        {
             JsonResponseModel<DescribeRuleGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则组详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupResponse"/></returns>
        public DescribeRuleGroupResponse DescribeRuleGroupSync(DescribeRuleGroupRequest req)
        {
             JsonResponseModel<DescribeRuleGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 规则组执行结果分页查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupExecResultsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupExecResultsByPageResponse"/></returns>
        public async Task<DescribeRuleGroupExecResultsByPageResponse> DescribeRuleGroupExecResultsByPage(DescribeRuleGroupExecResultsByPageRequest req)
        {
             JsonResponseModel<DescribeRuleGroupExecResultsByPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleGroupExecResultsByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleGroupExecResultsByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 规则组执行结果分页查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupExecResultsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupExecResultsByPageResponse"/></returns>
        public DescribeRuleGroupExecResultsByPageResponse DescribeRuleGroupExecResultsByPageSync(DescribeRuleGroupExecResultsByPageRequest req)
        {
             JsonResponseModel<DescribeRuleGroupExecResultsByPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleGroupExecResultsByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleGroupExecResultsByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 规则组执行结果分页查询接口不带鉴权
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupExecResultsByPageWithoutAuthRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupExecResultsByPageWithoutAuthResponse"/></returns>
        public async Task<DescribeRuleGroupExecResultsByPageWithoutAuthResponse> DescribeRuleGroupExecResultsByPageWithoutAuth(DescribeRuleGroupExecResultsByPageWithoutAuthRequest req)
        {
             JsonResponseModel<DescribeRuleGroupExecResultsByPageWithoutAuthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleGroupExecResultsByPageWithoutAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleGroupExecResultsByPageWithoutAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 规则组执行结果分页查询接口不带鉴权
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupExecResultsByPageWithoutAuthRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupExecResultsByPageWithoutAuthResponse"/></returns>
        public DescribeRuleGroupExecResultsByPageWithoutAuthResponse DescribeRuleGroupExecResultsByPageWithoutAuthSync(DescribeRuleGroupExecResultsByPageWithoutAuthRequest req)
        {
             JsonResponseModel<DescribeRuleGroupExecResultsByPageWithoutAuthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleGroupExecResultsByPageWithoutAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleGroupExecResultsByPageWithoutAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则组订阅信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupSubscriptionRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupSubscriptionResponse"/></returns>
        public async Task<DescribeRuleGroupSubscriptionResponse> DescribeRuleGroupSubscription(DescribeRuleGroupSubscriptionRequest req)
        {
             JsonResponseModel<DescribeRuleGroupSubscriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleGroupSubscription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleGroupSubscriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则组订阅信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupSubscriptionRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupSubscriptionResponse"/></returns>
        public DescribeRuleGroupSubscriptionResponse DescribeRuleGroupSubscriptionSync(DescribeRuleGroupSubscriptionRequest req)
        {
             JsonResponseModel<DescribeRuleGroupSubscriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleGroupSubscription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleGroupSubscriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询表绑定执行规则组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupTableRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupTableResponse"/></returns>
        public async Task<DescribeRuleGroupTableResponse> DescribeRuleGroupTable(DescribeRuleGroupTableRequest req)
        {
             JsonResponseModel<DescribeRuleGroupTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleGroupTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleGroupTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询表绑定执行规则组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupTableRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupTableResponse"/></returns>
        public DescribeRuleGroupTableResponse DescribeRuleGroupTableSync(DescribeRuleGroupTableRequest req)
        {
             JsonResponseModel<DescribeRuleGroupTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleGroupTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleGroupTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 【过滤条件】
        /// {表名称TableName,支持模糊匹配}       {表负责人TableOwnerName,支持模糊匹配}      {监控方式MonitorTypes，1.未配置 2.关联生产调度 3.离线周期检测,支持多选}  {订阅人ReceiverUin}
        /// 【必要字段】
        /// {数据来源DatasourceId}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupsByPageResponse"/></returns>
        public async Task<DescribeRuleGroupsByPageResponse> DescribeRuleGroupsByPage(DescribeRuleGroupsByPageRequest req)
        {
             JsonResponseModel<DescribeRuleGroupsByPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleGroupsByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleGroupsByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 【过滤条件】
        /// {表名称TableName,支持模糊匹配}       {表负责人TableOwnerName,支持模糊匹配}      {监控方式MonitorTypes，1.未配置 2.关联生产调度 3.离线周期检测,支持多选}  {订阅人ReceiverUin}
        /// 【必要字段】
        /// {数据来源DatasourceId}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupsByPageResponse"/></returns>
        public DescribeRuleGroupsByPageResponse DescribeRuleGroupsByPageSync(DescribeRuleGroupsByPageRequest req)
        {
             JsonResponseModel<DescribeRuleGroupsByPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleGroupsByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleGroupsByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 过滤条件【必要字段】{ruleId}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleHistoryByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleHistoryByPageResponse"/></returns>
        public async Task<DescribeRuleHistoryByPageResponse> DescribeRuleHistoryByPage(DescribeRuleHistoryByPageRequest req)
        {
             JsonResponseModel<DescribeRuleHistoryByPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleHistoryByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleHistoryByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 过滤条件【必要字段】{ruleId}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleHistoryByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleHistoryByPageResponse"/></returns>
        public DescribeRuleHistoryByPageResponse DescribeRuleHistoryByPageSync(DescribeRuleHistoryByPageRequest req)
        {
             JsonResponseModel<DescribeRuleHistoryByPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleHistoryByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleHistoryByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取表列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTablesByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleTablesByPageResponse"/></returns>
        public async Task<DescribeRuleTablesByPageResponse> DescribeRuleTablesByPage(DescribeRuleTablesByPageRequest req)
        {
             JsonResponseModel<DescribeRuleTablesByPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleTablesByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleTablesByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取表列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTablesByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleTablesByPageResponse"/></returns>
        public DescribeRuleTablesByPageResponse DescribeRuleTablesByPageSync(DescribeRuleTablesByPageRequest req)
        {
             JsonResponseModel<DescribeRuleTablesByPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleTablesByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleTablesByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplateRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplateResponse"/></returns>
        public async Task<DescribeRuleTemplateResponse> DescribeRuleTemplate(DescribeRuleTemplateRequest req)
        {
             JsonResponseModel<DescribeRuleTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplateRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplateResponse"/></returns>
        public DescribeRuleTemplateResponse DescribeRuleTemplateSync(DescribeRuleTemplateRequest req)
        {
             JsonResponseModel<DescribeRuleTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则模版列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesResponse"/></returns>
        public async Task<DescribeRuleTemplatesResponse> DescribeRuleTemplates(DescribeRuleTemplatesRequest req)
        {
             JsonResponseModel<DescribeRuleTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则模版列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesResponse"/></returns>
        public DescribeRuleTemplatesResponse DescribeRuleTemplatesSync(DescribeRuleTemplatesRequest req)
        {
             JsonResponseModel<DescribeRuleTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 过滤条件】 {模版名称Name,支持模糊匹配} {模版类型type，1.系统模版 2.自定义模版} {质量检测维度QualityDims, 1.准确性 2.唯一性 3.完整性 4.一致性 5.及时性 6.有效性} 【排序字段】 { 引用数排序类型CitationOrderType，根据引用数量排序 ASC DESC}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesByPageResponse"/></returns>
        public async Task<DescribeRuleTemplatesByPageResponse> DescribeRuleTemplatesByPage(DescribeRuleTemplatesByPageRequest req)
        {
             JsonResponseModel<DescribeRuleTemplatesByPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleTemplatesByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleTemplatesByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 过滤条件】 {模版名称Name,支持模糊匹配} {模版类型type，1.系统模版 2.自定义模版} {质量检测维度QualityDims, 1.准确性 2.唯一性 3.完整性 4.一致性 5.及时性 6.有效性} 【排序字段】 { 引用数排序类型CitationOrderType，根据引用数量排序 ASC DESC}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesByPageResponse"/></returns>
        public DescribeRuleTemplatesByPageResponse DescribeRuleTemplatesByPageSync(DescribeRuleTemplatesByPageRequest req)
        {
             JsonResponseModel<DescribeRuleTemplatesByPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleTemplatesByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleTemplatesByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询质量规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public async Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
             JsonResponseModel<DescribeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询质量规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
             JsonResponseModel<DescribeRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询质量规则
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesByPageRequest"/></param>
        /// <returns><see cref="DescribeRulesByPageResponse"/></returns>
        public async Task<DescribeRulesByPageResponse> DescribeRulesByPage(DescribeRulesByPageRequest req)
        {
             JsonResponseModel<DescribeRulesByPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRulesByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询质量规则
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesByPageRequest"/></param>
        /// <returns><see cref="DescribeRulesByPageResponse"/></returns>
        public DescribeRulesByPageResponse DescribeRulesByPageSync(DescribeRulesByPageRequest req)
        {
             JsonResponseModel<DescribeRulesByPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRulesByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据标准规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeStandardRuleDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribeStandardRuleDetailInfoListResponse"/></returns>
        public async Task<DescribeStandardRuleDetailInfoListResponse> DescribeStandardRuleDetailInfoList(DescribeStandardRuleDetailInfoListRequest req)
        {
             JsonResponseModel<DescribeStandardRuleDetailInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStandardRuleDetailInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStandardRuleDetailInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据标准规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeStandardRuleDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribeStandardRuleDetailInfoListResponse"/></returns>
        public DescribeStandardRuleDetailInfoListResponse DescribeStandardRuleDetailInfoListSync(DescribeStandardRuleDetailInfoListRequest req)
        {
             JsonResponseModel<DescribeStandardRuleDetailInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStandardRuleDetailInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStandardRuleDetailInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实时任务日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeStreamTaskLogListResponse"/></returns>
        public async Task<DescribeStreamTaskLogListResponse> DescribeStreamTaskLogList(DescribeStreamTaskLogListRequest req)
        {
             JsonResponseModel<DescribeStreamTaskLogListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamTaskLogList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamTaskLogListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实时任务日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeStreamTaskLogListResponse"/></returns>
        public DescribeStreamTaskLogListResponse DescribeStreamTaskLogListSync(DescribeStreamTaskLogListRequest req)
        {
             JsonResponseModel<DescribeStreamTaskLogListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamTaskLogList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamTaskLogListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableInfoListRequest"/></param>
        /// <returns><see cref="DescribeTableInfoListResponse"/></returns>
        public async Task<DescribeTableInfoListResponse> DescribeTableInfoList(DescribeTableInfoListRequest req)
        {
             JsonResponseModel<DescribeTableInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTableInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableInfoListRequest"/></param>
        /// <returns><see cref="DescribeTableInfoListResponse"/></returns>
        public DescribeTableInfoListResponse DescribeTableInfoListSync(DescribeTableInfoListRequest req)
        {
             JsonResponseModel<DescribeTableInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTableInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 质量报告-查询表质量详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTableQualityDetailsRequest"/></param>
        /// <returns><see cref="DescribeTableQualityDetailsResponse"/></returns>
        public async Task<DescribeTableQualityDetailsResponse> DescribeTableQualityDetails(DescribeTableQualityDetailsRequest req)
        {
             JsonResponseModel<DescribeTableQualityDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTableQualityDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableQualityDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 质量报告-查询表质量详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTableQualityDetailsRequest"/></param>
        /// <returns><see cref="DescribeTableQualityDetailsResponse"/></returns>
        public DescribeTableQualityDetailsResponse DescribeTableQualityDetailsSync(DescribeTableQualityDetailsRequest req)
        {
             JsonResponseModel<DescribeTableQualityDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTableQualityDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableQualityDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取表schema信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableSchemaInfoRequest"/></param>
        /// <returns><see cref="DescribeTableSchemaInfoResponse"/></returns>
        public async Task<DescribeTableSchemaInfoResponse> DescribeTableSchemaInfo(DescribeTableSchemaInfoRequest req)
        {
             JsonResponseModel<DescribeTableSchemaInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTableSchemaInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableSchemaInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取表schema信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableSchemaInfoRequest"/></param>
        /// <returns><see cref="DescribeTableSchemaInfoResponse"/></returns>
        public DescribeTableSchemaInfoResponse DescribeTableSchemaInfoSync(DescribeTableSchemaInfoRequest req)
        {
             JsonResponseModel<DescribeTableSchemaInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTableSchemaInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableSchemaInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询表得分趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeTableScoreTrendRequest"/></param>
        /// <returns><see cref="DescribeTableScoreTrendResponse"/></returns>
        public async Task<DescribeTableScoreTrendResponse> DescribeTableScoreTrend(DescribeTableScoreTrendRequest req)
        {
             JsonResponseModel<DescribeTableScoreTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTableScoreTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableScoreTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询表得分趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeTableScoreTrendRequest"/></param>
        /// <returns><see cref="DescribeTableScoreTrendResponse"/></returns>
        public DescribeTableScoreTrendResponse DescribeTableScoreTrendSync(DescribeTableScoreTrendRequest req)
        {
             JsonResponseModel<DescribeTableScoreTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTableScoreTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableScoreTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务告警规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskAlarmRegulationsRequest"/></param>
        /// <returns><see cref="DescribeTaskAlarmRegulationsResponse"/></returns>
        public async Task<DescribeTaskAlarmRegulationsResponse> DescribeTaskAlarmRegulations(DescribeTaskAlarmRegulationsRequest req)
        {
             JsonResponseModel<DescribeTaskAlarmRegulationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskAlarmRegulations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskAlarmRegulationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务告警规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskAlarmRegulationsRequest"/></param>
        /// <returns><see cref="DescribeTaskAlarmRegulationsResponse"/></returns>
        public DescribeTaskAlarmRegulationsResponse DescribeTaskAlarmRegulationsSync(DescribeTaskAlarmRegulationsRequest req)
        {
             JsonResponseModel<DescribeTaskAlarmRegulationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskAlarmRegulations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskAlarmRegulationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 查询任务具体详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 查询任务具体详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 离线任务实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstanceRequest"/></param>
        /// <returns><see cref="DescribeTaskInstanceResponse"/></returns>
        public async Task<DescribeTaskInstanceResponse> DescribeTaskInstance(DescribeTaskInstanceRequest req)
        {
             JsonResponseModel<DescribeTaskInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 离线任务实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstanceRequest"/></param>
        /// <returns><see cref="DescribeTaskInstanceResponse"/></returns>
        public DescribeTaskInstanceResponse DescribeTaskInstanceSync(DescribeTaskInstanceRequest req)
        {
             JsonResponseModel<DescribeTaskInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 离线任务实例统计明细
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstanceReportDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskInstanceReportDetailResponse"/></returns>
        public async Task<DescribeTaskInstanceReportDetailResponse> DescribeTaskInstanceReportDetail(DescribeTaskInstanceReportDetailRequest req)
        {
             JsonResponseModel<DescribeTaskInstanceReportDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskInstanceReportDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInstanceReportDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 离线任务实例统计明细
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstanceReportDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskInstanceReportDetailResponse"/></returns>
        public DescribeTaskInstanceReportDetailResponse DescribeTaskInstanceReportDetailSync(DescribeTaskInstanceReportDetailRequest req)
        {
             JsonResponseModel<DescribeTaskInstanceReportDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskInstanceReportDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInstanceReportDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstancesRequest"/></param>
        /// <returns><see cref="DescribeTaskInstancesResponse"/></returns>
        public async Task<DescribeTaskInstancesResponse> DescribeTaskInstances(DescribeTaskInstancesRequest req)
        {
             JsonResponseModel<DescribeTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstancesRequest"/></param>
        /// <returns><see cref="DescribeTaskInstancesResponse"/></returns>
        public DescribeTaskInstancesResponse DescribeTaskInstancesSync(DescribeTaskInstancesRequest req)
        {
             JsonResponseModel<DescribeTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看任务锁状态信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLockStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskLockStatusResponse"/></returns>
        public async Task<DescribeTaskLockStatusResponse> DescribeTaskLockStatus(DescribeTaskLockStatusRequest req)
        {
             JsonResponseModel<DescribeTaskLockStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskLockStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskLockStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看任务锁状态信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLockStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskLockStatusResponse"/></returns>
        public DescribeTaskLockStatusResponse DescribeTaskLockStatusSync(DescribeTaskLockStatusRequest req)
        {
             JsonResponseModel<DescribeTaskLockStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskLockStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskLockStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按起止日期统计离线任务的所有实例的运行指标总和
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskReportRequest"/></param>
        /// <returns><see cref="DescribeTaskReportResponse"/></returns>
        public async Task<DescribeTaskReportResponse> DescribeTaskReport(DescribeTaskReportRequest req)
        {
             JsonResponseModel<DescribeTaskReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按起止日期统计离线任务的所有实例的运行指标总和
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskReportRequest"/></param>
        /// <returns><see cref="DescribeTaskReportResponse"/></returns>
        public DescribeTaskReportResponse DescribeTaskReportSync(DescribeTaskReportRequest req)
        {
             JsonResponseModel<DescribeTaskReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 离线任务周期统计明细
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskReportDetailListRequest"/></param>
        /// <returns><see cref="DescribeTaskReportDetailListResponse"/></returns>
        public async Task<DescribeTaskReportDetailListResponse> DescribeTaskReportDetailList(DescribeTaskReportDetailListRequest req)
        {
             JsonResponseModel<DescribeTaskReportDetailListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskReportDetailList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskReportDetailListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 离线任务周期统计明细
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskReportDetailListRequest"/></param>
        /// <returns><see cref="DescribeTaskReportDetailListResponse"/></returns>
        public DescribeTaskReportDetailListResponse DescribeTaskReportDetailListSync(DescribeTaskReportDetailListRequest req)
        {
             JsonResponseModel<DescribeTaskReportDetailListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskReportDetailList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskReportDetailListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 查询任务脚本
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskScriptRequest"/></param>
        /// <returns><see cref="DescribeTaskScriptResponse"/></returns>
        public async Task<DescribeTaskScriptResponse> DescribeTaskScript(DescribeTaskScriptRequest req)
        {
             JsonResponseModel<DescribeTaskScriptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 查询任务脚本
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskScriptRequest"/></param>
        /// <returns><see cref="DescribeTaskScriptResponse"/></returns>
        public DescribeTaskScriptResponse DescribeTaskScriptSync(DescribeTaskScriptRequest req)
        {
             JsonResponseModel<DescribeTaskScriptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 根据工作流分页查询任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksByPageRequest"/></param>
        /// <returns><see cref="DescribeTasksByPageResponse"/></returns>
        public async Task<DescribeTasksByPageResponse> DescribeTasksByPage(DescribeTasksByPageRequest req)
        {
             JsonResponseModel<DescribeTasksByPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasksByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 根据工作流分页查询任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksByPageRequest"/></param>
        /// <returns><see cref="DescribeTasksByPageResponse"/></returns>
        public DescribeTasksByPageResponse DescribeTasksByPageSync(DescribeTasksByPageRequest req)
        {
             JsonResponseModel<DescribeTasksByPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasksByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则模版维度分布情况
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateDimCountRequest"/></param>
        /// <returns><see cref="DescribeTemplateDimCountResponse"/></returns>
        public async Task<DescribeTemplateDimCountResponse> DescribeTemplateDimCount(DescribeTemplateDimCountRequest req)
        {
             JsonResponseModel<DescribeTemplateDimCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTemplateDimCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateDimCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则模版维度分布情况
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateDimCountRequest"/></param>
        /// <returns><see cref="DescribeTemplateDimCountResponse"/></returns>
        public DescribeTemplateDimCountResponse DescribeTemplateDimCountSync(DescribeTemplateDimCountRequest req)
        {
             JsonResponseModel<DescribeTemplateDimCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTemplateDimCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateDimCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则模版操作记录
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateHistoryRequest"/></param>
        /// <returns><see cref="DescribeTemplateHistoryResponse"/></returns>
        public async Task<DescribeTemplateHistoryResponse> DescribeTemplateHistory(DescribeTemplateHistoryRequest req)
        {
             JsonResponseModel<DescribeTemplateHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTemplateHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则模版操作记录
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateHistoryRequest"/></param>
        /// <returns><see cref="DescribeTemplateHistoryResponse"/></returns>
        public DescribeTemplateHistoryResponse DescribeTemplateHistorySync(DescribeTemplateHistoryRequest req)
        {
             JsonResponseModel<DescribeTemplateHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTemplateHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量概览页面表排行接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTopTableStatRequest"/></param>
        /// <returns><see cref="DescribeTopTableStatResponse"/></returns>
        public async Task<DescribeTopTableStatResponse> DescribeTopTableStat(DescribeTopTableStatRequest req)
        {
             JsonResponseModel<DescribeTopTableStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopTableStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopTableStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量概览页面表排行接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTopTableStatRequest"/></param>
        /// <returns><see cref="DescribeTopTableStatResponse"/></returns>
        public DescribeTopTableStatResponse DescribeTopTableStatSync(DescribeTopTableStatRequest req)
        {
             JsonResponseModel<DescribeTopTableStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopTableStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopTableStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量概览页面趋势变化接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTrendStatRequest"/></param>
        /// <returns><see cref="DescribeTrendStatResponse"/></returns>
        public async Task<DescribeTrendStatResponse> DescribeTrendStat(DescribeTrendStatRequest req)
        {
             JsonResponseModel<DescribeTrendStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrendStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrendStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据质量概览页面趋势变化接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTrendStatRequest"/></param>
        /// <returns><see cref="DescribeTrendStatResponse"/></returns>
        public DescribeTrendStatResponse DescribeTrendStatSync(DescribeTrendStatRequest req)
        {
             JsonResponseModel<DescribeTrendStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrendStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrendStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调试运行集成任务
        /// </summary>
        /// <param name="req"><see cref="DryRunDIOfflineTaskRequest"/></param>
        /// <returns><see cref="DryRunDIOfflineTaskResponse"/></returns>
        public async Task<DryRunDIOfflineTaskResponse> DryRunDIOfflineTask(DryRunDIOfflineTaskRequest req)
        {
             JsonResponseModel<DryRunDIOfflineTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DryRunDIOfflineTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DryRunDIOfflineTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调试运行集成任务
        /// </summary>
        /// <param name="req"><see cref="DryRunDIOfflineTaskRequest"/></param>
        /// <returns><see cref="DryRunDIOfflineTaskResponse"/></returns>
        public DryRunDIOfflineTaskResponse DryRunDIOfflineTaskSync(DryRunDIOfflineTaskRequest req)
        {
             JsonResponseModel<DryRunDIOfflineTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DryRunDIOfflineTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DryRunDIOfflineTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量置成功
        /// </summary>
        /// <param name="req"><see cref="ForceSucInstancesRequest"/></param>
        /// <returns><see cref="ForceSucInstancesResponse"/></returns>
        public async Task<ForceSucInstancesResponse> ForceSucInstances(ForceSucInstancesRequest req)
        {
             JsonResponseModel<ForceSucInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForceSucInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForceSucInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量置成功
        /// </summary>
        /// <param name="req"><see cref="ForceSucInstancesRequest"/></param>
        /// <returns><see cref="ForceSucInstancesResponse"/></returns>
        public ForceSucInstancesResponse ForceSucInstancesSync(ForceSucInstancesRequest req)
        {
             JsonResponseModel<ForceSucInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ForceSucInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForceSucInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量冻结任务
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksRequest"/></param>
        /// <returns><see cref="FreezeTasksResponse"/></returns>
        public async Task<FreezeTasksResponse> FreezeTasks(FreezeTasksRequest req)
        {
             JsonResponseModel<FreezeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FreezeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FreezeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量冻结任务
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksRequest"/></param>
        /// <returns><see cref="FreezeTasksResponse"/></returns>
        public FreezeTasksResponse FreezeTasksSync(FreezeTasksRequest req)
        {
             JsonResponseModel<FreezeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FreezeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FreezeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 基于多个工作流进行批量冻结任务操作
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksByMultiWorkflowRequest"/></param>
        /// <returns><see cref="FreezeTasksByMultiWorkflowResponse"/></returns>
        public async Task<FreezeTasksByMultiWorkflowResponse> FreezeTasksByMultiWorkflow(FreezeTasksByMultiWorkflowRequest req)
        {
             JsonResponseModel<FreezeTasksByMultiWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FreezeTasksByMultiWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FreezeTasksByMultiWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 基于多个工作流进行批量冻结任务操作
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksByMultiWorkflowRequest"/></param>
        /// <returns><see cref="FreezeTasksByMultiWorkflowResponse"/></returns>
        public FreezeTasksByMultiWorkflowResponse FreezeTasksByMultiWorkflowSync(FreezeTasksByMultiWorkflowRequest req)
        {
             JsonResponseModel<FreezeTasksByMultiWorkflowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FreezeTasksByMultiWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FreezeTasksByMultiWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成建hive表的sql
        /// </summary>
        /// <param name="req"><see cref="GenHiveTableDDLSqlRequest"/></param>
        /// <returns><see cref="GenHiveTableDDLSqlResponse"/></returns>
        public async Task<GenHiveTableDDLSqlResponse> GenHiveTableDDLSql(GenHiveTableDDLSqlRequest req)
        {
             JsonResponseModel<GenHiveTableDDLSqlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenHiveTableDDLSql");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenHiveTableDDLSqlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成建hive表的sql
        /// </summary>
        /// <param name="req"><see cref="GenHiveTableDDLSqlRequest"/></param>
        /// <returns><see cref="GenHiveTableDDLSqlResponse"/></returns>
        public GenHiveTableDDLSqlResponse GenHiveTableDDLSqlSync(GenHiveTableDDLSqlRequest req)
        {
             JsonResponseModel<GenHiveTableDDLSqlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenHiveTableDDLSql");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenHiveTableDDLSqlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提取数据集成节点字段Schema
        /// </summary>
        /// <param name="req"><see cref="GetIntegrationNodeColumnSchemaRequest"/></param>
        /// <returns><see cref="GetIntegrationNodeColumnSchemaResponse"/></returns>
        public async Task<GetIntegrationNodeColumnSchemaResponse> GetIntegrationNodeColumnSchema(GetIntegrationNodeColumnSchemaRequest req)
        {
             JsonResponseModel<GetIntegrationNodeColumnSchemaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetIntegrationNodeColumnSchema");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetIntegrationNodeColumnSchemaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提取数据集成节点字段Schema
        /// </summary>
        /// <param name="req"><see cref="GetIntegrationNodeColumnSchemaRequest"/></param>
        /// <returns><see cref="GetIntegrationNodeColumnSchemaResponse"/></returns>
        public GetIntegrationNodeColumnSchemaResponse GetIntegrationNodeColumnSchemaSync(GetIntegrationNodeColumnSchemaRequest req)
        {
             JsonResponseModel<GetIntegrationNodeColumnSchemaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetIntegrationNodeColumnSchema");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetIntegrationNodeColumnSchemaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取离线任务实例列表(新)
        /// </summary>
        /// <param name="req"><see cref="GetOfflineDIInstanceListRequest"/></param>
        /// <returns><see cref="GetOfflineDIInstanceListResponse"/></returns>
        public async Task<GetOfflineDIInstanceListResponse> GetOfflineDIInstanceList(GetOfflineDIInstanceListRequest req)
        {
             JsonResponseModel<GetOfflineDIInstanceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetOfflineDIInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOfflineDIInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取离线任务实例列表(新)
        /// </summary>
        /// <param name="req"><see cref="GetOfflineDIInstanceListRequest"/></param>
        /// <returns><see cref="GetOfflineDIInstanceListResponse"/></returns>
        public GetOfflineDIInstanceListResponse GetOfflineDIInstanceListSync(GetOfflineDIInstanceListRequest req)
        {
             JsonResponseModel<GetOfflineDIInstanceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetOfflineDIInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOfflineDIInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取离线任务实例
        /// </summary>
        /// <param name="req"><see cref="GetOfflineInstanceListRequest"/></param>
        /// <returns><see cref="GetOfflineInstanceListResponse"/></returns>
        public async Task<GetOfflineInstanceListResponse> GetOfflineInstanceList(GetOfflineInstanceListRequest req)
        {
             JsonResponseModel<GetOfflineInstanceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetOfflineInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOfflineInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取离线任务实例
        /// </summary>
        /// <param name="req"><see cref="GetOfflineInstanceListRequest"/></param>
        /// <returns><see cref="GetOfflineInstanceListResponse"/></returns>
        public GetOfflineInstanceListResponse GetOfflineInstanceListSync(GetOfflineInstanceListRequest req)
        {
             JsonResponseModel<GetOfflineInstanceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetOfflineInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOfflineInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量终止操作
        /// </summary>
        /// <param name="req"><see cref="KillInstancesRequest"/></param>
        /// <returns><see cref="KillInstancesResponse"/></returns>
        public async Task<KillInstancesResponse> KillInstances(KillInstancesRequest req)
        {
             JsonResponseModel<KillInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "KillInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量终止操作
        /// </summary>
        /// <param name="req"><see cref="KillInstancesRequest"/></param>
        /// <returns><see cref="KillInstancesResponse"/></returns>
        public KillInstancesResponse KillInstancesSync(KillInstancesRequest req)
        {
             JsonResponseModel<KillInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "KillInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 锁定集成任务
        /// </summary>
        /// <param name="req"><see cref="LockIntegrationTaskRequest"/></param>
        /// <returns><see cref="LockIntegrationTaskResponse"/></returns>
        public async Task<LockIntegrationTaskResponse> LockIntegrationTask(LockIntegrationTaskRequest req)
        {
             JsonResponseModel<LockIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LockIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LockIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 锁定集成任务
        /// </summary>
        /// <param name="req"><see cref="LockIntegrationTaskRequest"/></param>
        /// <returns><see cref="LockIntegrationTaskResponse"/></returns>
        public LockIntegrationTaskResponse LockIntegrationTaskSync(LockIntegrationTaskRequest req)
        {
             JsonResponseModel<LockIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LockIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LockIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 任务批量补录，调度状态任务才可以补录；
        /// 
        /// 
        /// </summary>
        /// <param name="req"><see cref="MakeUpTasksNewRequest"/></param>
        /// <returns><see cref="MakeUpTasksNewResponse"/></returns>
        public async Task<MakeUpTasksNewResponse> MakeUpTasksNew(MakeUpTasksNewRequest req)
        {
             JsonResponseModel<MakeUpTasksNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MakeUpTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MakeUpTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 任务批量补录，调度状态任务才可以补录；
        /// 
        /// 
        /// </summary>
        /// <param name="req"><see cref="MakeUpTasksNewRequest"/></param>
        /// <returns><see cref="MakeUpTasksNewResponse"/></returns>
        public MakeUpTasksNewResponse MakeUpTasksNewSync(MakeUpTasksNewRequest req)
        {
             JsonResponseModel<MakeUpTasksNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MakeUpTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MakeUpTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 工作流下所有任务的补录
        /// </summary>
        /// <param name="req"><see cref="MakeUpWorkflowNewRequest"/></param>
        /// <returns><see cref="MakeUpWorkflowNewResponse"/></returns>
        public async Task<MakeUpWorkflowNewResponse> MakeUpWorkflowNew(MakeUpWorkflowNewRequest req)
        {
             JsonResponseModel<MakeUpWorkflowNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MakeUpWorkflowNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MakeUpWorkflowNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 工作流下所有任务的补录
        /// </summary>
        /// <param name="req"><see cref="MakeUpWorkflowNewRequest"/></param>
        /// <returns><see cref="MakeUpWorkflowNewResponse"/></returns>
        public MakeUpWorkflowNewResponse MakeUpWorkflowNewSync(MakeUpWorkflowNewRequest req)
        {
             JsonResponseModel<MakeUpWorkflowNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MakeUpWorkflowNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MakeUpWorkflowNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 修改数据源
        /// </summary>
        /// <param name="req"><see cref="ModifyDataSourceRequest"/></param>
        /// <returns><see cref="ModifyDataSourceResponse"/></returns>
        public async Task<ModifyDataSourceResponse> ModifyDataSource(ModifyDataSourceRequest req)
        {
             JsonResponseModel<ModifyDataSourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDataSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDataSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 修改数据源
        /// </summary>
        /// <param name="req"><see cref="ModifyDataSourceRequest"/></param>
        /// <returns><see cref="ModifyDataSourceResponse"/></returns>
        public ModifyDataSourceResponse ModifyDataSourceSync(ModifyDataSourceRequest req)
        {
             JsonResponseModel<ModifyDataSourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDataSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDataSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 质量报告-修改维度权限
        /// </summary>
        /// <param name="req"><see cref="ModifyDimensionWeightRequest"/></param>
        /// <returns><see cref="ModifyDimensionWeightResponse"/></returns>
        public async Task<ModifyDimensionWeightResponse> ModifyDimensionWeight(ModifyDimensionWeightRequest req)
        {
             JsonResponseModel<ModifyDimensionWeightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDimensionWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDimensionWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 质量报告-修改维度权限
        /// </summary>
        /// <param name="req"><see cref="ModifyDimensionWeightRequest"/></param>
        /// <returns><see cref="ModifyDimensionWeightResponse"/></returns>
        public ModifyDimensionWeightResponse ModifyDimensionWeightSync(ModifyDimensionWeightRequest req)
        {
             JsonResponseModel<ModifyDimensionWeightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDimensionWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDimensionWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新规则组执行策略
        /// </summary>
        /// <param name="req"><see cref="ModifyExecStrategyRequest"/></param>
        /// <returns><see cref="ModifyExecStrategyResponse"/></returns>
        public async Task<ModifyExecStrategyResponse> ModifyExecStrategy(ModifyExecStrategyRequest req)
        {
             JsonResponseModel<ModifyExecStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyExecStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyExecStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新规则组执行策略
        /// </summary>
        /// <param name="req"><see cref="ModifyExecStrategyRequest"/></param>
        /// <returns><see cref="ModifyExecStrategyResponse"/></returns>
        public ModifyExecStrategyResponse ModifyExecStrategySync(ModifyExecStrategyRequest req)
        {
             JsonResponseModel<ModifyExecStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyExecStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyExecStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 文件夹更新
        /// </summary>
        /// <param name="req"><see cref="ModifyFolderRequest"/></param>
        /// <returns><see cref="ModifyFolderResponse"/></returns>
        public async Task<ModifyFolderResponse> ModifyFolder(ModifyFolderRequest req)
        {
             JsonResponseModel<ModifyFolderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFolder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFolderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 文件夹更新
        /// </summary>
        /// <param name="req"><see cref="ModifyFolderRequest"/></param>
        /// <returns><see cref="ModifyFolderResponse"/></returns>
        public ModifyFolderResponse ModifyFolderSync(ModifyFolderRequest req)
        {
             JsonResponseModel<ModifyFolderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFolder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFolderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新集成节点
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationNodeRequest"/></param>
        /// <returns><see cref="ModifyIntegrationNodeResponse"/></returns>
        public async Task<ModifyIntegrationNodeResponse> ModifyIntegrationNode(ModifyIntegrationNodeRequest req)
        {
             JsonResponseModel<ModifyIntegrationNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIntegrationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIntegrationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新集成节点
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationNodeRequest"/></param>
        /// <returns><see cref="ModifyIntegrationNodeResponse"/></returns>
        public ModifyIntegrationNodeResponse ModifyIntegrationNodeSync(ModifyIntegrationNodeRequest req)
        {
             JsonResponseModel<ModifyIntegrationNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIntegrationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIntegrationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新集成任务
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationTaskRequest"/></param>
        /// <returns><see cref="ModifyIntegrationTaskResponse"/></returns>
        public async Task<ModifyIntegrationTaskResponse> ModifyIntegrationTask(ModifyIntegrationTaskRequest req)
        {
             JsonResponseModel<ModifyIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新集成任务
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationTaskRequest"/></param>
        /// <returns><see cref="ModifyIntegrationTaskResponse"/></returns>
        public ModifyIntegrationTaskResponse ModifyIntegrationTaskSync(ModifyIntegrationTaskRequest req)
        {
             JsonResponseModel<ModifyIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新监控状态
        /// </summary>
        /// <param name="req"><see cref="ModifyMonitorStatusRequest"/></param>
        /// <returns><see cref="ModifyMonitorStatusResponse"/></returns>
        public async Task<ModifyMonitorStatusResponse> ModifyMonitorStatus(ModifyMonitorStatusRequest req)
        {
             JsonResponseModel<ModifyMonitorStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMonitorStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMonitorStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新监控状态
        /// </summary>
        /// <param name="req"><see cref="ModifyMonitorStatusRequest"/></param>
        /// <returns><see cref="ModifyMonitorStatusResponse"/></returns>
        public ModifyMonitorStatusResponse ModifyMonitorStatusSync(ModifyMonitorStatusRequest req)
        {
             JsonResponseModel<ModifyMonitorStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMonitorStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMonitorStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新质量规则接口
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public async Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
             JsonResponseModel<ModifyRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新质量规则接口
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
             JsonResponseModel<ModifyRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新规则组订阅信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleGroupSubscriptionRequest"/></param>
        /// <returns><see cref="ModifyRuleGroupSubscriptionResponse"/></returns>
        public async Task<ModifyRuleGroupSubscriptionResponse> ModifyRuleGroupSubscription(ModifyRuleGroupSubscriptionRequest req)
        {
             JsonResponseModel<ModifyRuleGroupSubscriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRuleGroupSubscription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleGroupSubscriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新规则组订阅信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleGroupSubscriptionRequest"/></param>
        /// <returns><see cref="ModifyRuleGroupSubscriptionResponse"/></returns>
        public ModifyRuleGroupSubscriptionResponse ModifyRuleGroupSubscriptionSync(ModifyRuleGroupSubscriptionRequest req)
        {
             JsonResponseModel<ModifyRuleGroupSubscriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRuleGroupSubscription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleGroupSubscriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑规则模版
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleTemplateRequest"/></param>
        /// <returns><see cref="ModifyRuleTemplateResponse"/></returns>
        public async Task<ModifyRuleTemplateResponse> ModifyRuleTemplate(ModifyRuleTemplateRequest req)
        {
             JsonResponseModel<ModifyRuleTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRuleTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑规则模版
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleTemplateRequest"/></param>
        /// <returns><see cref="ModifyRuleTemplateResponse"/></returns>
        public ModifyRuleTemplateResponse ModifyRuleTemplateSync(ModifyRuleTemplateRequest req)
        {
             JsonResponseModel<ModifyRuleTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRuleTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改任务告警规则
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="ModifyTaskAlarmRegularResponse"/></returns>
        public async Task<ModifyTaskAlarmRegularResponse> ModifyTaskAlarmRegular(ModifyTaskAlarmRegularRequest req)
        {
             JsonResponseModel<ModifyTaskAlarmRegularResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTaskAlarmRegular");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskAlarmRegularResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改任务告警规则
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="ModifyTaskAlarmRegularResponse"/></returns>
        public ModifyTaskAlarmRegularResponse ModifyTaskAlarmRegularSync(ModifyTaskAlarmRegularRequest req)
        {
             JsonResponseModel<ModifyTaskAlarmRegularResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTaskAlarmRegular");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskAlarmRegularResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskInfoRequest"/></param>
        /// <returns><see cref="ModifyTaskInfoResponse"/></returns>
        public async Task<ModifyTaskInfoResponse> ModifyTaskInfo(ModifyTaskInfoRequest req)
        {
             JsonResponseModel<ModifyTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskInfoRequest"/></param>
        /// <returns><see cref="ModifyTaskInfoResponse"/></returns>
        public ModifyTaskInfoResponse ModifyTaskInfoSync(ModifyTaskInfoRequest req)
        {
             JsonResponseModel<ModifyTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 添加父任务依赖
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskLinksRequest"/></param>
        /// <returns><see cref="ModifyTaskLinksResponse"/></returns>
        public async Task<ModifyTaskLinksResponse> ModifyTaskLinks(ModifyTaskLinksRequest req)
        {
             JsonResponseModel<ModifyTaskLinksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTaskLinks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskLinksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 添加父任务依赖
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskLinksRequest"/></param>
        /// <returns><see cref="ModifyTaskLinksResponse"/></returns>
        public ModifyTaskLinksResponse ModifyTaskLinksSync(ModifyTaskLinksRequest req)
        {
             JsonResponseModel<ModifyTaskLinksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTaskLinks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskLinksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重命名任务（任务编辑）
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskNameRequest"/></param>
        /// <returns><see cref="ModifyTaskNameResponse"/></returns>
        public async Task<ModifyTaskNameResponse> ModifyTaskName(ModifyTaskNameRequest req)
        {
             JsonResponseModel<ModifyTaskNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTaskName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重命名任务（任务编辑）
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskNameRequest"/></param>
        /// <returns><see cref="ModifyTaskNameResponse"/></returns>
        public ModifyTaskNameResponse ModifyTaskNameSync(ModifyTaskNameRequest req)
        {
             JsonResponseModel<ModifyTaskNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTaskName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 修改任务脚本
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskScriptRequest"/></param>
        /// <returns><see cref="ModifyTaskScriptResponse"/></returns>
        public async Task<ModifyTaskScriptResponse> ModifyTaskScript(ModifyTaskScriptRequest req)
        {
             JsonResponseModel<ModifyTaskScriptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTaskScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 修改任务脚本
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskScriptRequest"/></param>
        /// <returns><see cref="ModifyTaskScriptResponse"/></returns>
        public ModifyTaskScriptResponse ModifyTaskScriptSync(ModifyTaskScriptRequest req)
        {
             JsonResponseModel<ModifyTaskScriptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTaskScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新工作流
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowInfoRequest"/></param>
        /// <returns><see cref="ModifyWorkflowInfoResponse"/></returns>
        public async Task<ModifyWorkflowInfoResponse> ModifyWorkflowInfo(ModifyWorkflowInfoRequest req)
        {
             JsonResponseModel<ModifyWorkflowInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWorkflowInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkflowInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新工作流
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowInfoRequest"/></param>
        /// <returns><see cref="ModifyWorkflowInfoResponse"/></returns>
        public ModifyWorkflowInfoResponse ModifyWorkflowInfoSync(ModifyWorkflowInfoRequest req)
        {
             JsonResponseModel<ModifyWorkflowInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWorkflowInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkflowInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新工作流调度
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowScheduleRequest"/></param>
        /// <returns><see cref="ModifyWorkflowScheduleResponse"/></returns>
        public async Task<ModifyWorkflowScheduleResponse> ModifyWorkflowSchedule(ModifyWorkflowScheduleRequest req)
        {
             JsonResponseModel<ModifyWorkflowScheduleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWorkflowSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkflowScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新工作流调度
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowScheduleRequest"/></param>
        /// <returns><see cref="ModifyWorkflowScheduleResponse"/></returns>
        public ModifyWorkflowScheduleResponse ModifyWorkflowScheduleSync(ModifyWorkflowScheduleRequest req)
        {
             JsonResponseModel<ModifyWorkflowScheduleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWorkflowSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkflowScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件
        /// </summary>
        /// <param name="req"><see cref="RegisterEventRequest"/></param>
        /// <returns><see cref="RegisterEventResponse"/></returns>
        public async Task<RegisterEventResponse> RegisterEvent(RegisterEventRequest req)
        {
             JsonResponseModel<RegisterEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件
        /// </summary>
        /// <param name="req"><see cref="RegisterEventRequest"/></param>
        /// <returns><see cref="RegisterEventResponse"/></returns>
        public RegisterEventResponse RegisterEventSync(RegisterEventRequest req)
        {
             JsonResponseModel<RegisterEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件监听器
        /// </summary>
        /// <param name="req"><see cref="RegisterEventListenerRequest"/></param>
        /// <returns><see cref="RegisterEventListenerResponse"/></returns>
        public async Task<RegisterEventListenerResponse> RegisterEventListener(RegisterEventListenerRequest req)
        {
             JsonResponseModel<RegisterEventListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterEventListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterEventListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件监听器
        /// </summary>
        /// <param name="req"><see cref="RegisterEventListenerRequest"/></param>
        /// <returns><see cref="RegisterEventListenerResponse"/></returns>
        public RegisterEventListenerResponse RegisterEventListenerSync(RegisterEventListenerRequest req)
        {
             JsonResponseModel<RegisterEventListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterEventListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterEventListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量重跑
        /// </summary>
        /// <param name="req"><see cref="RerunInstancesRequest"/></param>
        /// <returns><see cref="RerunInstancesResponse"/></returns>
        public async Task<RerunInstancesResponse> RerunInstances(RerunInstancesRequest req)
        {
             JsonResponseModel<RerunInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RerunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RerunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量重跑
        /// </summary>
        /// <param name="req"><see cref="RerunInstancesRequest"/></param>
        /// <returns><see cref="RerunInstancesResponse"/></returns>
        public RerunInstancesResponse RerunInstancesSync(RerunInstancesRequest req)
        {
             JsonResponseModel<RerunInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RerunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RerunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启采集器
        /// </summary>
        /// <param name="req"><see cref="RestartInLongAgentRequest"/></param>
        /// <returns><see cref="RestartInLongAgentResponse"/></returns>
        public async Task<RestartInLongAgentResponse> RestartInLongAgent(RestartInLongAgentRequest req)
        {
             JsonResponseModel<RestartInLongAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartInLongAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartInLongAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启采集器
        /// </summary>
        /// <param name="req"><see cref="RestartInLongAgentRequest"/></param>
        /// <returns><see cref="RestartInLongAgentResponse"/></returns>
        public RestartInLongAgentResponse RestartInLongAgentSync(RestartInLongAgentRequest req)
        {
             JsonResponseModel<RestartInLongAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartInLongAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartInLongAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 继续集成任务
        /// </summary>
        /// <param name="req"><see cref="ResumeIntegrationTaskRequest"/></param>
        /// <returns><see cref="ResumeIntegrationTaskResponse"/></returns>
        public async Task<ResumeIntegrationTaskResponse> ResumeIntegrationTask(ResumeIntegrationTaskRequest req)
        {
             JsonResponseModel<ResumeIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 继续集成任务
        /// </summary>
        /// <param name="req"><see cref="ResumeIntegrationTaskRequest"/></param>
        /// <returns><see cref="ResumeIntegrationTaskResponse"/></returns>
        public ResumeIntegrationTaskResponse ResumeIntegrationTaskSync(ResumeIntegrationTaskRequest req)
        {
             JsonResponseModel<ResumeIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 抢占锁定集成任务
        /// </summary>
        /// <param name="req"><see cref="RobAndLockIntegrationTaskRequest"/></param>
        /// <returns><see cref="RobAndLockIntegrationTaskResponse"/></returns>
        public async Task<RobAndLockIntegrationTaskResponse> RobAndLockIntegrationTask(RobAndLockIntegrationTaskRequest req)
        {
             JsonResponseModel<RobAndLockIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RobAndLockIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RobAndLockIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 抢占锁定集成任务
        /// </summary>
        /// <param name="req"><see cref="RobAndLockIntegrationTaskRequest"/></param>
        /// <returns><see cref="RobAndLockIntegrationTaskResponse"/></returns>
        public RobAndLockIntegrationTaskResponse RobAndLockIntegrationTaskSync(RobAndLockIntegrationTaskRequest req)
        {
             JsonResponseModel<RobAndLockIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RobAndLockIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RobAndLockIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 运行任务
        /// </summary>
        /// <param name="req"><see cref="RunTaskRequest"/></param>
        /// <returns><see cref="RunTaskResponse"/></returns>
        public async Task<RunTaskResponse> RunTask(RunTaskRequest req)
        {
             JsonResponseModel<RunTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 运行任务
        /// </summary>
        /// <param name="req"><see cref="RunTaskRequest"/></param>
        /// <returns><see cref="RunTaskResponse"/></returns>
        public RunTaskResponse RunTaskSync(RunTaskRequest req)
        {
             JsonResponseModel<RunTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 保存用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="SaveCustomFunctionRequest"/></param>
        /// <returns><see cref="SaveCustomFunctionResponse"/></returns>
        public async Task<SaveCustomFunctionResponse> SaveCustomFunction(SaveCustomFunctionRequest req)
        {
             JsonResponseModel<SaveCustomFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SaveCustomFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SaveCustomFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 保存用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="SaveCustomFunctionRequest"/></param>
        /// <returns><see cref="SaveCustomFunctionResponse"/></returns>
        public SaveCustomFunctionResponse SaveCustomFunctionSync(SaveCustomFunctionRequest req)
        {
             JsonResponseModel<SaveCustomFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SaveCustomFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SaveCustomFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 设置任务告警，新建/更新告警信息（最新）
        /// </summary>
        /// <param name="req"><see cref="SetTaskAlarmNewRequest"/></param>
        /// <returns><see cref="SetTaskAlarmNewResponse"/></returns>
        public async Task<SetTaskAlarmNewResponse> SetTaskAlarmNew(SetTaskAlarmNewRequest req)
        {
             JsonResponseModel<SetTaskAlarmNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetTaskAlarmNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTaskAlarmNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 设置任务告警，新建/更新告警信息（最新）
        /// </summary>
        /// <param name="req"><see cref="SetTaskAlarmNewRequest"/></param>
        /// <returns><see cref="SetTaskAlarmNewResponse"/></returns>
        public SetTaskAlarmNewResponse SetTaskAlarmNewSync(SetTaskAlarmNewRequest req)
        {
             JsonResponseModel<SetTaskAlarmNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetTaskAlarmNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTaskAlarmNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动集成任务
        /// </summary>
        /// <param name="req"><see cref="StartIntegrationTaskRequest"/></param>
        /// <returns><see cref="StartIntegrationTaskResponse"/></returns>
        public async Task<StartIntegrationTaskResponse> StartIntegrationTask(StartIntegrationTaskRequest req)
        {
             JsonResponseModel<StartIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动集成任务
        /// </summary>
        /// <param name="req"><see cref="StartIntegrationTaskRequest"/></param>
        /// <returns><see cref="StartIntegrationTaskResponse"/></returns>
        public StartIntegrationTaskResponse StartIntegrationTaskSync(StartIntegrationTaskRequest req)
        {
             JsonResponseModel<StartIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止集成任务
        /// </summary>
        /// <param name="req"><see cref="StopIntegrationTaskRequest"/></param>
        /// <returns><see cref="StopIntegrationTaskResponse"/></returns>
        public async Task<StopIntegrationTaskResponse> StopIntegrationTask(StopIntegrationTaskRequest req)
        {
             JsonResponseModel<StopIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止集成任务
        /// </summary>
        /// <param name="req"><see cref="StopIntegrationTaskRequest"/></param>
        /// <returns><see cref="StopIntegrationTaskResponse"/></returns>
        public StopIntegrationTaskResponse StopIntegrationTaskSync(StopIntegrationTaskRequest req)
        {
             JsonResponseModel<StopIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交自定义函数
        /// </summary>
        /// <param name="req"><see cref="SubmitCustomFunctionRequest"/></param>
        /// <returns><see cref="SubmitCustomFunctionResponse"/></returns>
        public async Task<SubmitCustomFunctionResponse> SubmitCustomFunction(SubmitCustomFunctionRequest req)
        {
             JsonResponseModel<SubmitCustomFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitCustomFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitCustomFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交自定义函数
        /// </summary>
        /// <param name="req"><see cref="SubmitCustomFunctionRequest"/></param>
        /// <returns><see cref="SubmitCustomFunctionResponse"/></returns>
        public SubmitCustomFunctionResponse SubmitCustomFunctionSync(SubmitCustomFunctionRequest req)
        {
             JsonResponseModel<SubmitCustomFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SubmitCustomFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitCustomFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 提交任务
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public async Task<SubmitTaskResponse> SubmitTask(SubmitTaskRequest req)
        {
             JsonResponseModel<SubmitTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 提交任务
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public SubmitTaskResponse SubmitTaskSync(SubmitTaskRequest req)
        {
             JsonResponseModel<SubmitTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SubmitTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 提交工作流
        /// </summary>
        /// <param name="req"><see cref="SubmitWorkflowRequest"/></param>
        /// <returns><see cref="SubmitWorkflowResponse"/></returns>
        public async Task<SubmitWorkflowResponse> SubmitWorkflow(SubmitWorkflowRequest req)
        {
             JsonResponseModel<SubmitWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 提交工作流
        /// </summary>
        /// <param name="req"><see cref="SubmitWorkflowRequest"/></param>
        /// <returns><see cref="SubmitWorkflowResponse"/></returns>
        public SubmitWorkflowResponse SubmitWorkflowSync(SubmitWorkflowRequest req)
        {
             JsonResponseModel<SubmitWorkflowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SubmitWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停集成任务
        /// </summary>
        /// <param name="req"><see cref="SuspendIntegrationTaskRequest"/></param>
        /// <returns><see cref="SuspendIntegrationTaskResponse"/></returns>
        public async Task<SuspendIntegrationTaskResponse> SuspendIntegrationTask(SuspendIntegrationTaskRequest req)
        {
             JsonResponseModel<SuspendIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SuspendIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SuspendIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停集成任务
        /// </summary>
        /// <param name="req"><see cref="SuspendIntegrationTaskRequest"/></param>
        /// <returns><see cref="SuspendIntegrationTaskResponse"/></returns>
        public SuspendIntegrationTaskResponse SuspendIntegrationTaskSync(SuspendIntegrationTaskRequest req)
        {
             JsonResponseModel<SuspendIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SuspendIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SuspendIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Inlong manager日志
        /// </summary>
        /// <param name="req"><see cref="TaskLogRequest"/></param>
        /// <returns><see cref="TaskLogResponse"/></returns>
        public async Task<TaskLogResponse> TaskLog(TaskLogRequest req)
        {
             JsonResponseModel<TaskLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TaskLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TaskLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Inlong manager日志
        /// </summary>
        /// <param name="req"><see cref="TaskLogRequest"/></param>
        /// <returns><see cref="TaskLogResponse"/></returns>
        public TaskLogResponse TaskLogSync(TaskLogRequest req)
        {
             JsonResponseModel<TaskLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TaskLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TaskLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 触发事件
        /// </summary>
        /// <param name="req"><see cref="TriggerEventRequest"/></param>
        /// <returns><see cref="TriggerEventResponse"/></returns>
        public async Task<TriggerEventResponse> TriggerEvent(TriggerEventRequest req)
        {
             JsonResponseModel<TriggerEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TriggerEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TriggerEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 触发事件
        /// </summary>
        /// <param name="req"><see cref="TriggerEventRequest"/></param>
        /// <returns><see cref="TriggerEventResponse"/></returns>
        public TriggerEventResponse TriggerEventSync(TriggerEventRequest req)
        {
             JsonResponseModel<TriggerEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TriggerEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TriggerEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解锁集成任务
        /// </summary>
        /// <param name="req"><see cref="UnlockIntegrationTaskRequest"/></param>
        /// <returns><see cref="UnlockIntegrationTaskResponse"/></returns>
        public async Task<UnlockIntegrationTaskResponse> UnlockIntegrationTask(UnlockIntegrationTaskRequest req)
        {
             JsonResponseModel<UnlockIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnlockIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnlockIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解锁集成任务
        /// </summary>
        /// <param name="req"><see cref="UnlockIntegrationTaskRequest"/></param>
        /// <returns><see cref="UnlockIntegrationTaskResponse"/></returns>
        public UnlockIntegrationTaskResponse UnlockIntegrationTaskSync(UnlockIntegrationTaskRequest req)
        {
             JsonResponseModel<UnlockIntegrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnlockIntegrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnlockIntegrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新采集器
        /// </summary>
        /// <param name="req"><see cref="UpdateInLongAgentRequest"/></param>
        /// <returns><see cref="UpdateInLongAgentResponse"/></returns>
        public async Task<UpdateInLongAgentResponse> UpdateInLongAgent(UpdateInLongAgentRequest req)
        {
             JsonResponseModel<UpdateInLongAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateInLongAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateInLongAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新采集器
        /// </summary>
        /// <param name="req"><see cref="UpdateInLongAgentRequest"/></param>
        /// <returns><see cref="UpdateInLongAgentResponse"/></returns>
        public UpdateInLongAgentResponse UpdateInLongAgentSync(UpdateInLongAgentRequest req)
        {
             JsonResponseModel<UpdateInLongAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateInLongAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateInLongAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
