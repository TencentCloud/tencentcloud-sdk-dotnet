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
        /// 评估输入图片在视觉上的质量，从多个方面评估，并同时给出综合的、客观的清晰度评分，和主观的美观度评分。
        /// </summary>
        /// <param name="req">参考<see cref="AssessQualityRequest"/></param>
        /// <returns>参考<see cref="AssessQualityResponse"/>实例</returns>
        public async Task<AssessQualityResponse> AssessQuality(AssessQualityRequest req)
        {
             JsonResponseModel<AssessQualityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssessQuality");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssessQualityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据输入的裁剪比例，智能判断一张图片的最佳裁剪区域，确保原图的主体区域不受影响。
        /// 
        /// 可以自动裁剪图片，适应不同平台、设备的展示要求，避免简单拉伸带来的变形。
        /// </summary>
        /// <param name="req">参考<see cref="CropImageRequest"/></param>
        /// <returns>参考<see cref="CropImageResponse"/>实例</returns>
        public async Task<CropImageResponse> CropImage(CropImageRequest req)
        {
             JsonResponseModel<CropImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CropImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CropImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入一张图片，可以识别图片中包含的人物是否为公众人物，如果是，输出人物的姓名、基本信息、脸部坐标。
        /// 
        /// 支持识别一张图片中存在的多个人脸，针对每个人脸，会给出与之最相似的公众人物。
        /// </summary>
        /// <param name="req">参考<see cref="DetectCelebrityRequest"/></param>
        /// <returns>参考<see cref="DetectCelebrityResponse"/>实例</returns>
        public async Task<DetectCelebrityResponse> DetectCelebrity(DetectCelebrityRequest req)
        {
             JsonResponseModel<DetectCelebrityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectCelebrity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectCelebrityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 输入一张图片，返回AI针对一张图片是否是恶心的一系列判断值。
        /// 
        /// 通过恶心图片识别, 可以判断一张图片是否令人恶心, 同时给出它属于的潜在类别, 让您能够过滤掉使人不愉快的图片.
        /// </summary>
        /// <param name="req">参考<see cref="DetectDisgustRequest"/></param>
        /// <returns>参考<see cref="DetectDisgustResponse"/>实例</returns>
        public async Task<DetectDisgustResponse> DetectDisgust(DetectDisgustRequest req)
        {
             JsonResponseModel<DetectDisgustResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectDisgust");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectDisgustResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// 可以识别输入的图片中是否包含不良行为，例如打架斗殴、赌博、抽烟等，可以应用于广告图、直播截图、短视频截图等审核，减少不良行为对平台内容质量的影响，维护健康向上的互联网环境。
        /// </summary>
        /// <param name="req">参考<see cref="DetectMisbehaviorRequest"/></param>
        /// <returns>参考<see cref="DetectMisbehaviorResponse"/>实例</returns>
        public async Task<DetectMisbehaviorResponse> DetectMisbehavior(DetectMisbehaviorRequest req)
        {
             JsonResponseModel<DetectMisbehaviorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectMisbehavior");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectMisbehaviorResponse>>(strResp);
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
        /// 传入一张图片，输出清晰度提升后的图片。
        /// 
        /// 可以消除图片有损压缩导致的噪声，和使用滤镜、拍摄失焦导致的模糊。让图片的边缘和细节更加清晰自然。
        /// 
        /// </summary>
        /// <param name="req">参考<see cref="EnhanceImageRequest"/></param>
        /// <returns>参考<see cref="EnhanceImageResponse"/>实例</returns>
        public async Task<EnhanceImageResponse> EnhanceImage(EnhanceImageRequest req)
        {
             JsonResponseModel<EnhanceImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnhanceImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnhanceImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口提供多种维度的图像审核能力，支持色情和性感内容识别，政治人物和涉政敏感场景识别，暴恐人物、场景、旗帜标识等违禁内容的识别，以及图片中文字内容的识别。
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
