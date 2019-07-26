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

namespace TencentCloud.Tiia.V20190529
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tiia.V20190529.Models;

   public class TiiaClient : AbstractClient{

       private const string endpoint = "tiia.tencentcloudapi.com";
       private const string version = "2019-05-29";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public TiiaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public TiiaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 传入一张图片，识别出图片中存在的物体，并返回物体的名称（分类）、置信度，一张图片会给出多个可能的标签。
        /// </summary>
        /// <param name="req">参考<see cref="DetectLabelRequest"/></param>
        /// <returns>参考<see cref="DetectLabelResponse"/>实例</returns>
        public async Task<DetectLabelResponse> DetectLabel(DetectLabelRequest req)
        {
             JsonResponseModel<DetectLabelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectLabel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectLabelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持识别图片中包含的商品，能够输出商品的品类名称、类别，还可以输出商品在图片中的位置。支持一张图片多个商品的识别。
        /// </summary>
        /// <param name="req">参考<see cref="DetectProductRequest"/></param>
        /// <returns>参考<see cref="DetectProductResponse"/>实例</returns>
        public async Task<DetectProductResponse> DetectProduct(DetectProductRequest req)
        {
             JsonResponseModel<DetectProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口提供多种维度的图像审核能力，支持色情和性感内容识别，政治人物和涉政敏感场景识别，以及暴恐人物、场景、旗帜标识等违禁内容的识别。
        /// </summary>
        /// <param name="req">参考<see cref="ImageModerationRequest"/></param>
        /// <returns>参考<see cref="ImageModerationResponse"/>实例</returns>
        public async Task<ImageModerationResponse> ImageModeration(ImageModerationRequest req)
        {
             JsonResponseModel<ImageModerationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImageModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯云车辆属性识别可对汽车车身及车辆属性进行检测与识别，目前支持11种车身颜色、20多种车型、300多种品牌、4000多种车系+年款的识别，同时支持对车标的位置进行检测。
        /// </summary>
        /// <param name="req">参考<see cref="RecognizeCarRequest"/></param>
        /// <returns>参考<see cref="RecognizeCarResponse"/>实例</returns>
        public async Task<RecognizeCarResponse> RecognizeCar(RecognizeCarRequest req)
        {
             JsonResponseModel<RecognizeCarResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecognizeCar");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeCarResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
