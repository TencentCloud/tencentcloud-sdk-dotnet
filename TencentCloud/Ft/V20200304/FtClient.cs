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

namespace TencentCloud.Ft.V20200304
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ft.V20200304.Models;

   public class FtClient : AbstractClient{

       private const string endpoint = "ft.tencentcloudapi.com";
       private const string version = "2020-03-04";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FtClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public FtClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用户上传一张人脸图片，基于人脸编辑与生成算法，输出一张人脸变老或变年轻的图片，支持实现人脸不同年龄的变化。（目前暂只支持10岁，后续放开再通知） 
        /// </summary>
        /// <param name="req"><see cref="ChangeAgePicRequest"/></param>
        /// <returns><see cref="ChangeAgePicResponse"/></returns>
        public async Task<ChangeAgePicResponse> ChangeAgePic(ChangeAgePicRequest req)
        {
             JsonResponseModel<ChangeAgePicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeAgePic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeAgePicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户上传一张人脸图片，基于人脸编辑与生成算法，输出一张人脸变老或变年轻的图片，支持实现人脸不同年龄的变化。（目前暂只支持10岁，后续放开再通知） 
        /// </summary>
        /// <param name="req"><see cref="ChangeAgePicRequest"/></param>
        /// <returns><see cref="ChangeAgePicResponse"/></returns>
        public ChangeAgePicResponse ChangeAgePicSync(ChangeAgePicRequest req)
        {
             JsonResponseModel<ChangeAgePicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeAgePic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeAgePicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户上传一张人脸图片，基于人脸编辑与生成算法，输出一张人脸性别转换的图片。男变女可实现美颜、淡妆、加刘海和长发的效果；女变男可实现加胡须、变短发的效果。 
        /// </summary>
        /// <param name="req"><see cref="SwapGenderPicRequest"/></param>
        /// <returns><see cref="SwapGenderPicResponse"/></returns>
        public async Task<SwapGenderPicResponse> SwapGenderPic(SwapGenderPicRequest req)
        {
             JsonResponseModel<SwapGenderPicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwapGenderPic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwapGenderPicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户上传一张人脸图片，基于人脸编辑与生成算法，输出一张人脸性别转换的图片。男变女可实现美颜、淡妆、加刘海和长发的效果；女变男可实现加胡须、变短发的效果。 
        /// </summary>
        /// <param name="req"><see cref="SwapGenderPicRequest"/></param>
        /// <returns><see cref="SwapGenderPicResponse"/></returns>
        public SwapGenderPicResponse SwapGenderPicSync(SwapGenderPicRequest req)
        {
             JsonResponseModel<SwapGenderPicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwapGenderPic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwapGenderPicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
