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

namespace TencentCloud.Aca.V20210323
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Aca.V20210323.Models;

   public class AcaClient : AbstractClient{

       private const string endpoint = "aca.tencentcloudapi.com";
       private const string version = "2021-03-23";
       private const string sdkVersion = "SDK_NET_3.0.1223";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AcaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AcaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 药品适应症接口
        /// </summary>
        /// <param name="req"><see cref="GetDrugIndicationsRequest"/></param>
        /// <returns><see cref="GetDrugIndicationsResponse"/></returns>
        public Task<GetDrugIndicationsResponse> GetDrugIndications(GetDrugIndicationsRequest req)
        {
            return InternalRequestAsync<GetDrugIndicationsResponse>(req, "GetDrugIndications");
        }

        /// <summary>
        /// 药品适应症接口
        /// </summary>
        /// <param name="req"><see cref="GetDrugIndicationsRequest"/></param>
        /// <returns><see cref="GetDrugIndicationsResponse"/></returns>
        public GetDrugIndicationsResponse GetDrugIndicationsSync(GetDrugIndicationsRequest req)
        {
            return InternalRequestAsync<GetDrugIndicationsResponse>(req, "GetDrugIndications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 登录获取token
        /// </summary>
        /// <param name="req"><see cref="LoginHisToolRequest"/></param>
        /// <returns><see cref="LoginHisToolResponse"/></returns>
        public Task<LoginHisToolResponse> LoginHisTool(LoginHisToolRequest req)
        {
            return InternalRequestAsync<LoginHisToolResponse>(req, "LoginHisTool");
        }

        /// <summary>
        /// 登录获取token
        /// </summary>
        /// <param name="req"><see cref="LoginHisToolRequest"/></param>
        /// <returns><see cref="LoginHisToolResponse"/></returns>
        public LoginHisToolResponse LoginHisToolSync(LoginHisToolRequest req)
        {
            return InternalRequestAsync<LoginHisToolResponse>(req, "LoginHisTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="req"><see cref="LoginOutHisToolRequest"/></param>
        /// <returns><see cref="LoginOutHisToolResponse"/></returns>
        public Task<LoginOutHisToolResponse> LoginOutHisTool(LoginOutHisToolRequest req)
        {
            return InternalRequestAsync<LoginOutHisToolResponse>(req, "LoginOutHisTool");
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="req"><see cref="LoginOutHisToolRequest"/></param>
        /// <returns><see cref="LoginOutHisToolResponse"/></returns>
        public LoginOutHisToolResponse LoginOutHisToolSync(LoginOutHisToolRequest req)
        {
            return InternalRequestAsync<LoginOutHisToolResponse>(req, "LoginOutHisTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能用药接口
        /// </summary>
        /// <param name="req"><see cref="SmartDrugInfoRequest"/></param>
        /// <returns><see cref="SmartDrugInfoResponse"/></returns>
        public Task<SmartDrugInfoResponse> SmartDrugInfo(SmartDrugInfoRequest req)
        {
            return InternalRequestAsync<SmartDrugInfoResponse>(req, "SmartDrugInfo");
        }

        /// <summary>
        /// 智能用药接口
        /// </summary>
        /// <param name="req"><see cref="SmartDrugInfoRequest"/></param>
        /// <returns><see cref="SmartDrugInfoResponse"/></returns>
        public SmartDrugInfoResponse SmartDrugInfoSync(SmartDrugInfoRequest req)
        {
            return InternalRequestAsync<SmartDrugInfoResponse>(req, "SmartDrugInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 辅诊智能预测接口
        /// </summary>
        /// <param name="req"><see cref="SmartPredictRequest"/></param>
        /// <returns><see cref="SmartPredictResponse"/></returns>
        public Task<SmartPredictResponse> SmartPredict(SmartPredictRequest req)
        {
            return InternalRequestAsync<SmartPredictResponse>(req, "SmartPredict");
        }

        /// <summary>
        /// 辅诊智能预测接口
        /// </summary>
        /// <param name="req"><see cref="SmartPredictRequest"/></param>
        /// <returns><see cref="SmartPredictResponse"/></returns>
        public SmartPredictResponse SmartPredictSync(SmartPredictRequest req)
        {
            return InternalRequestAsync<SmartPredictResponse>(req, "SmartPredict")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于院方科室管理，获取科室列表和状态、新增或修改科室信息、删除科室。
        /// </summary>
        /// <param name="req"><see cref="SyncDepartmentRequest"/></param>
        /// <returns><see cref="SyncDepartmentResponse"/></returns>
        public Task<SyncDepartmentResponse> SyncDepartment(SyncDepartmentRequest req)
        {
            return InternalRequestAsync<SyncDepartmentResponse>(req, "SyncDepartment");
        }

        /// <summary>
        /// 用于院方科室管理，获取科室列表和状态、新增或修改科室信息、删除科室。
        /// </summary>
        /// <param name="req"><see cref="SyncDepartmentRequest"/></param>
        /// <returns><see cref="SyncDepartmentResponse"/></returns>
        public SyncDepartmentResponse SyncDepartmentSync(SyncDepartmentRequest req)
        {
            return InternalRequestAsync<SyncDepartmentResponse>(req, "SyncDepartment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同步标准字典，如给药频次、给药途径、科室、诊断等
        /// </summary>
        /// <param name="req"><see cref="SyncStandardDictRequest"/></param>
        /// <returns><see cref="SyncStandardDictResponse"/></returns>
        public Task<SyncStandardDictResponse> SyncStandardDict(SyncStandardDictRequest req)
        {
            return InternalRequestAsync<SyncStandardDictResponse>(req, "SyncStandardDict");
        }

        /// <summary>
        /// 同步标准字典，如给药频次、给药途径、科室、诊断等
        /// </summary>
        /// <param name="req"><see cref="SyncStandardDictRequest"/></param>
        /// <returns><see cref="SyncStandardDictResponse"/></returns>
        public SyncStandardDictResponse SyncStandardDictSync(SyncStandardDictRequest req)
        {
            return InternalRequestAsync<SyncStandardDictResponse>(req, "SyncStandardDict")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 药品同步，一次同步数据不要超过500个
        /// </summary>
        /// <param name="req"><see cref="UploadDrugsRequest"/></param>
        /// <returns><see cref="UploadDrugsResponse"/></returns>
        public Task<UploadDrugsResponse> UploadDrugs(UploadDrugsRequest req)
        {
            return InternalRequestAsync<UploadDrugsResponse>(req, "UploadDrugs");
        }

        /// <summary>
        /// 药品同步，一次同步数据不要超过500个
        /// </summary>
        /// <param name="req"><see cref="UploadDrugsRequest"/></param>
        /// <returns><see cref="UploadDrugsResponse"/></returns>
        public UploadDrugsResponse UploadDrugsSync(UploadDrugsRequest req)
        {
            return InternalRequestAsync<UploadDrugsResponse>(req, "UploadDrugs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
