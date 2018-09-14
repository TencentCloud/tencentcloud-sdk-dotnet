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

namespace TencentCloud.Bm.V20180423
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bm.V20180423.Models;

   public class BmClient : AbstractClient{

       private const string endpoint = "bm.tencentcloudapi.com";
       private const string version = "2018-04-23";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public BmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public BmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 维修任务配置获取
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRepairTaskConstantRequest"/></param>
        /// <returns>参考<see cref="DescribeRepairTaskConstantResponse"/>实例</returns>
        public async Task<DescribeRepairTaskConstantResponse> DescribeRepairTaskConstant(DescribeRepairTaskConstantRequest req)
        {
             JsonResponseModel<DescribeRepairTaskConstantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRepairTaskConstant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepairTaskConstantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户维修任务列表及详细信息<br>
        /// <br>
        /// TaskStatus（任务状态ID）与状态中文名的对应关系如下：<br>
        /// 1：未授权<br>
        /// 2：处理中<br>
        /// 3：待确认<br>
        /// 4：未授权-暂不处理<br>
        /// 5：已恢复<br>
        /// 6：待确认-未恢复<br>
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskInfoResponse"/>实例</returns>
        public async Task<DescribeTaskInfoResponse> DescribeTaskInfo(DescribeTaskInfoRequest req)
        {
             JsonResponseModel<DescribeTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取维修任务操作日志
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskOperationLogRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskOperationLogResponse"/>实例</returns>
        public async Task<DescribeTaskOperationLogResponse> DescribeTaskOperationLog(DescribeTaskOperationLogRequest req)
        {
             JsonResponseModel<DescribeTaskOperationLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskOperationLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskOperationLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于操作维修任务<br>
        /// 入参TaskId为维修任务ID<br>
        /// 入参Operate表示对维修任务的操作，支持如下取值：<br>
        /// AuthorizeRepair（授权维修）<br>
        /// Ignore（暂不提醒）<br>
        /// ConfirmRecovered（维修完成后，确认故障恢复）<br>
        /// ConfirmUnRecovered（维修完成后，确认故障未恢复）<br>
        /// <br>
        /// 操作约束（当前任务状态(TaskStatus)->对应可执行的操作）：<br>
        /// 未授权(1)->授权维修；暂不处理<br>
        /// 暂不处理(4)->授权维修<br>
        /// 待确认(3)->确认故障恢复；确认故障未恢复<br>
        /// 未恢复(6)->确认故障恢复<br>
        /// <br>
        /// 对于Ping不可达故障的任务，还允许：<br>
        /// 未授权->确认故障恢复<br>
        /// 暂不处理->确认故障恢复<br>
        /// <br>
        /// 处理中与已恢复状态的任务不允许进行操作。<br>
        /// <br>
        /// 详细信息请访问：https://cloud.tencent.com/document/product/386/18190
        /// </summary>
        /// <param name="req">参考<see cref="RepairTaskControlRequest"/></param>
        /// <returns>参考<see cref="RepairTaskControlResponse"/>实例</returns>
        public async Task<RepairTaskControlResponse> RepairTaskControl(RepairTaskControlRequest req)
        {
             JsonResponseModel<RepairTaskControlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RepairTaskControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RepairTaskControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
