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

namespace TencentCloud.Controlcenter.V20230110
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Controlcenter.V20230110.Models;

   public class ControlcenterClient : AbstractClient{

       private const string endpoint = "controlcenter.tencentcloudapi.com";
       private const string version = "2023-01-10";
       private const string sdkVersion = "SDK_NET_3.0.1233";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ControlcenterClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ControlcenterClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 批量对存量账号应用基线
        /// </summary>
        /// <param name="req"><see cref="BatchApplyAccountBaselinesRequest"/></param>
        /// <returns><see cref="BatchApplyAccountBaselinesResponse"/></returns>
        public Task<BatchApplyAccountBaselinesResponse> BatchApplyAccountBaselines(BatchApplyAccountBaselinesRequest req)
        {
            return InternalRequestAsync<BatchApplyAccountBaselinesResponse>(req, "BatchApplyAccountBaselines");
        }

        /// <summary>
        /// 批量对存量账号应用基线
        /// </summary>
        /// <param name="req"><see cref="BatchApplyAccountBaselinesRequest"/></param>
        /// <returns><see cref="BatchApplyAccountBaselinesResponse"/></returns>
        public BatchApplyAccountBaselinesResponse BatchApplyAccountBaselinesSync(BatchApplyAccountBaselinesRequest req)
        {
            return InternalRequestAsync<BatchApplyAccountBaselinesResponse>(req, "BatchApplyAccountBaselines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户基线配置数据
        /// </summary>
        /// <param name="req"><see cref="GetAccountFactoryBaselineRequest"/></param>
        /// <returns><see cref="GetAccountFactoryBaselineResponse"/></returns>
        public Task<GetAccountFactoryBaselineResponse> GetAccountFactoryBaseline(GetAccountFactoryBaselineRequest req)
        {
            return InternalRequestAsync<GetAccountFactoryBaselineResponse>(req, "GetAccountFactoryBaseline");
        }

        /// <summary>
        /// 获取用户基线配置数据
        /// </summary>
        /// <param name="req"><see cref="GetAccountFactoryBaselineRequest"/></param>
        /// <returns><see cref="GetAccountFactoryBaselineResponse"/></returns>
        public GetAccountFactoryBaselineResponse GetAccountFactoryBaselineSync(GetAccountFactoryBaselineRequest req)
        {
            return InternalRequestAsync<GetAccountFactoryBaselineResponse>(req, "GetAccountFactoryBaseline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账号工厂系统基线项
        /// </summary>
        /// <param name="req"><see cref="ListAccountFactoryBaselineItemsRequest"/></param>
        /// <returns><see cref="ListAccountFactoryBaselineItemsResponse"/></returns>
        public Task<ListAccountFactoryBaselineItemsResponse> ListAccountFactoryBaselineItems(ListAccountFactoryBaselineItemsRequest req)
        {
            return InternalRequestAsync<ListAccountFactoryBaselineItemsResponse>(req, "ListAccountFactoryBaselineItems");
        }

        /// <summary>
        /// 获取账号工厂系统基线项
        /// </summary>
        /// <param name="req"><see cref="ListAccountFactoryBaselineItemsRequest"/></param>
        /// <returns><see cref="ListAccountFactoryBaselineItemsResponse"/></returns>
        public ListAccountFactoryBaselineItemsResponse ListAccountFactoryBaselineItemsSync(ListAccountFactoryBaselineItemsRequest req)
        {
            return InternalRequestAsync<ListAccountFactoryBaselineItemsResponse>(req, "ListAccountFactoryBaselineItems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取某个基线项历史应用信息
        /// </summary>
        /// <param name="req"><see cref="ListDeployStepTasksRequest"/></param>
        /// <returns><see cref="ListDeployStepTasksResponse"/></returns>
        public Task<ListDeployStepTasksResponse> ListDeployStepTasks(ListDeployStepTasksRequest req)
        {
            return InternalRequestAsync<ListDeployStepTasksResponse>(req, "ListDeployStepTasks");
        }

        /// <summary>
        /// 获取某个基线项历史应用信息
        /// </summary>
        /// <param name="req"><see cref="ListDeployStepTasksRequest"/></param>
        /// <returns><see cref="ListDeployStepTasksResponse"/></returns>
        public ListDeployStepTasksResponse ListDeployStepTasksSync(ListDeployStepTasksRequest req)
        {
            return InternalRequestAsync<ListDeployStepTasksResponse>(req, "ListDeployStepTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新用户当前基线项配置，基线配置会覆盖更新为当前配置。新增基线项时需要将新增的基线配置加到现有配置，删除基线项时需要将删除的基线配置从现有配置移除，然后保存最新基线配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateAccountFactoryBaselineRequest"/></param>
        /// <returns><see cref="UpdateAccountFactoryBaselineResponse"/></returns>
        public Task<UpdateAccountFactoryBaselineResponse> UpdateAccountFactoryBaseline(UpdateAccountFactoryBaselineRequest req)
        {
            return InternalRequestAsync<UpdateAccountFactoryBaselineResponse>(req, "UpdateAccountFactoryBaseline");
        }

        /// <summary>
        /// 更新用户当前基线项配置，基线配置会覆盖更新为当前配置。新增基线项时需要将新增的基线配置加到现有配置，删除基线项时需要将删除的基线配置从现有配置移除，然后保存最新基线配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateAccountFactoryBaselineRequest"/></param>
        /// <returns><see cref="UpdateAccountFactoryBaselineResponse"/></returns>
        public UpdateAccountFactoryBaselineResponse UpdateAccountFactoryBaselineSync(UpdateAccountFactoryBaselineRequest req)
        {
            return InternalRequestAsync<UpdateAccountFactoryBaselineResponse>(req, "UpdateAccountFactoryBaseline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
