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

namespace TencentCloud.Goosefs.V20220519
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Goosefs.V20220519.Models;

   public class GoosefsClient : AbstractClient{

       private const string endpoint = "goosefs.tencentcloudapi.com";
       private const string version = "2022-05-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GoosefsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GoosefsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建数据流通任务,包括从将文件系统的数据上传到存储桶下, 以及从存储桶下载到文件系统里。
        /// </summary>
        /// <param name="req"><see cref="CreateDataRepositoryTaskRequest"/></param>
        /// <returns><see cref="CreateDataRepositoryTaskResponse"/></returns>
        public async Task<CreateDataRepositoryTaskResponse> CreateDataRepositoryTask(CreateDataRepositoryTaskRequest req)
        {
             JsonResponseModel<CreateDataRepositoryTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDataRepositoryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataRepositoryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建数据流通任务,包括从将文件系统的数据上传到存储桶下, 以及从存储桶下载到文件系统里。
        /// </summary>
        /// <param name="req"><see cref="CreateDataRepositoryTaskRequest"/></param>
        /// <returns><see cref="CreateDataRepositoryTaskResponse"/></returns>
        public CreateDataRepositoryTaskResponse CreateDataRepositoryTaskSync(CreateDataRepositoryTaskRequest req)
        {
             JsonResponseModel<CreateDataRepositoryTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDataRepositoryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataRepositoryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
