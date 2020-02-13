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

namespace TencentCloud.Ecc.V20181213
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ecc.V20181213.Models;

   public class EccClient : AbstractClient{

       private const string endpoint = "ecc.tencentcloudapi.com";
       private const string version = "2018-12-13";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EccClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EccClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// https://ecc.tencentcloudapi.com/?Action=CorrectMultiImage
        /// 多图像识别批改接口
        /// </summary>
        /// <param name="req"><see cref="CorrectMultiImageRequest"/></param>
        /// <returns><see cref="CorrectMultiImageResponse"/></returns>
        public async Task<CorrectMultiImageResponse> CorrectMultiImage(CorrectMultiImageRequest req)
        {
             JsonResponseModel<CorrectMultiImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CorrectMultiImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CorrectMultiImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 异步任务结果查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public async Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
             JsonResponseModel<DescribeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口请求域名： ecc.tencentcloudapi.com 
        /// 纯文本英语作文批改
        /// </summary>
        /// <param name="req"><see cref="ECCRequest"/></param>
        /// <returns><see cref="ECCResponse"/></returns>
        public async Task<ECCResponse> ECC(ECCRequest req)
        {
             JsonResponseModel<ECCResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ECC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ECCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// https://ecc.tencentcloudapi.com/?Action=EHOCR
        /// 图像识别批改接口
        /// </summary>
        /// <param name="req"><see cref="EHOCRRequest"/></param>
        /// <returns><see cref="EHOCRResponse"/></returns>
        public async Task<EHOCRResponse> EHOCR(EHOCRRequest req)
        {
             JsonResponseModel<EHOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EHOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EHOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
