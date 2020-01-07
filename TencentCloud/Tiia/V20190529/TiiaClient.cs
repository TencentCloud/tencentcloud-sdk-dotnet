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
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TiiaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TiiaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 评估输入图片在视觉上的质量，从多个方面评估，并同时给出综合的、客观的清晰度评分，和主观的美观度评分。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="AssessQualityRequest"/></param>
        /// <returns><see cref="AssessQualityResponse"/></returns>
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
        /// AssessQuality接口的同步版本，评估输入图片在视觉上的质量，从多个方面评估，并同时给出综合的、客观的清晰度评分，和主观的美观度评分。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="AssessQualityRequest"/></param>
        /// <returns>参考<see cref="AssessQualityResponse"/>实例</returns>
        public AssessQualityResponse AssessQualitySync(AssessQualityRequest req)
        {
             JsonResponseModel<AssessQualityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssessQuality");
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
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="CropImageRequest"/></param>
        /// <returns><see cref="CropImageResponse"/></returns>
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
        /// CropImage接口的同步版本，根据输入的裁剪比例，智能判断一张图片的最佳裁剪区域，确保原图的主体区域不受影响。
        /// 
        /// 可以自动裁剪图片，适应不同平台、设备的展示要求，避免简单拉伸带来的变形。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="CropImageRequest"/></param>
        /// <returns>参考<see cref="CropImageResponse"/>实例</returns>
        public CropImageResponse CropImageSync(CropImageRequest req)
        {
             JsonResponseModel<CropImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CropImage");
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
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="DetectCelebrityRequest"/></param>
        /// <returns><see cref="DetectCelebrityResponse"/></returns>
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
        /// DetectCelebrity接口的同步版本，传入一张图片，可以识别图片中包含的人物是否为公众人物，如果是，输出人物的姓名、基本信息、脸部坐标。
        /// 
        /// 支持识别一张图片中存在的多个人脸，针对每个人脸，会给出与之最相似的公众人物。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="DetectCelebrityRequest"/></param>
        /// <returns>参考<see cref="DetectCelebrityResponse"/>实例</returns>
        public DetectCelebrityResponse DetectCelebritySync(DetectCelebrityRequest req)
        {
             JsonResponseModel<DetectCelebrityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectCelebrity");
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
        /// 通过恶心图片识别, 可以判断一张图片是否令人恶心, 同时给出它属于的潜在类别, 让您能够过滤掉使人不愉快的图片。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="DetectDisgustRequest"/></param>
        /// <returns><see cref="DetectDisgustResponse"/></returns>
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
        /// DetectDisgust接口的同步版本，输入一张图片，返回AI针对一张图片是否是恶心的一系列判断值。
        /// 
        /// 通过恶心图片识别, 可以判断一张图片是否令人恶心, 同时给出它属于的潜在类别, 让您能够过滤掉使人不愉快的图片。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="DetectDisgustRequest"/></param>
        /// <returns>参考<see cref="DetectDisgustResponse"/>实例</returns>
        public DetectDisgustResponse DetectDisgustSync(DetectDisgustRequest req)
        {
             JsonResponseModel<DetectDisgustResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectDisgust");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectDisgustResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 图像标签利用深度学习技术、海量训练数据，可以对图片进行智能分类、物体识别等。
        /// 
        /// 目前支持8个大类、六十多个子类、数千个标签。涵盖各种日常场景、动植物、物品、美食、卡证等。具体分类请见图像分析常见问题功能和限制部分（https://cloud.tencent.com/document/product/865/17629 ）
        /// 
        /// 图像标签提供三个版本供选择：
        /// 
        /// • 摄像头版：针对搜索、手机摄像头照片进行优化，涵盖大量卡证、日常物品、二维码条形码。
        /// 
        /// • 相册版：针对手机相册、网盘进行优化，去除相册和网盘中不常见的标签，针对相册常见图片类型（人像、日常活动、日常物品等）识别效果更好。
        /// 
        /// • 网络版：针对网络图片进行优化，涵盖标签更多，满足长尾识别需求。
        /// 
        /// 每个产品的图像类型都有独特性，建议在接入初期，对三个版本进行对比评估后选择合适的版本使用。
        /// 
        /// 为了方便使用、减少图片传输次数，图像标签包装成多合一接口，实际上是多个服务。
        /// 
        /// 图像标签按照服务的实际使用数量进行收费。例如一张图片同时调用相册版、摄像头版两个服务，那么此次调用按照两次计费。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="DetectLabelRequest"/></param>
        /// <returns><see cref="DetectLabelResponse"/></returns>
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
        /// DetectLabel接口的同步版本，图像标签利用深度学习技术、海量训练数据，可以对图片进行智能分类、物体识别等。
        /// 
        /// 目前支持8个大类、六十多个子类、数千个标签。涵盖各种日常场景、动植物、物品、美食、卡证等。具体分类请见图像分析常见问题功能和限制部分（https://cloud.tencent.com/document/product/865/17629 ）
        /// 
        /// 图像标签提供三个版本供选择：
        /// 
        /// • 摄像头版：针对搜索、手机摄像头照片进行优化，涵盖大量卡证、日常物品、二维码条形码。
        /// 
        /// • 相册版：针对手机相册、网盘进行优化，去除相册和网盘中不常见的标签，针对相册常见图片类型（人像、日常活动、日常物品等）识别效果更好。
        /// 
        /// • 网络版：针对网络图片进行优化，涵盖标签更多，满足长尾识别需求。
        /// 
        /// 每个产品的图像类型都有独特性，建议在接入初期，对三个版本进行对比评估后选择合适的版本使用。
        /// 
        /// 为了方便使用、减少图片传输次数，图像标签包装成多合一接口，实际上是多个服务。
        /// 
        /// 图像标签按照服务的实际使用数量进行收费。例如一张图片同时调用相册版、摄像头版两个服务，那么此次调用按照两次计费。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="DetectLabelRequest"/></param>
        /// <returns>参考<see cref="DetectLabelResponse"/>实例</returns>
        public DetectLabelResponse DetectLabelSync(DetectLabelRequest req)
        {
             JsonResponseModel<DetectLabelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectLabel");
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
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="DetectMisbehaviorRequest"/></param>
        /// <returns><see cref="DetectMisbehaviorResponse"/></returns>
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
        /// DetectMisbehavior接口的同步版本，可以识别输入的图片中是否包含不良行为，例如打架斗殴、赌博、抽烟等，可以应用于广告图、直播截图、短视频截图等审核，减少不良行为对平台内容质量的影响，维护健康向上的互联网环境。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="DetectMisbehaviorRequest"/></param>
        /// <returns>参考<see cref="DetectMisbehaviorResponse"/>实例</returns>
        public DetectMisbehaviorResponse DetectMisbehaviorSync(DetectMisbehaviorRequest req)
        {
             JsonResponseModel<DetectMisbehaviorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectMisbehavior");
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
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="DetectProductRequest"/></param>
        /// <returns><see cref="DetectProductResponse"/></returns>
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
        /// DetectProduct接口的同步版本，本接口支持识别图片中包含的商品，能够输出商品的品类名称、类别，还可以输出商品在图片中的位置。支持一张图片多个商品的识别。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="DetectProductRequest"/></param>
        /// <returns>参考<see cref="DetectProductResponse"/>实例</returns>
        public DetectProductResponse DetectProductSync(DetectProductRequest req)
        {
             JsonResponseModel<DetectProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectProduct");
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
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="EnhanceImageRequest"/></param>
        /// <returns><see cref="EnhanceImageResponse"/></returns>
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
        /// EnhanceImage接口的同步版本，传入一张图片，输出清晰度提升后的图片。
        /// 
        /// 可以消除图片有损压缩导致的噪声，和使用滤镜、拍摄失焦导致的模糊。让图片的边缘和细节更加清晰自然。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="EnhanceImageRequest"/></param>
        /// <returns>参考<see cref="EnhanceImageResponse"/>实例</returns>
        public EnhanceImageResponse EnhanceImageSync(EnhanceImageRequest req)
        {
             JsonResponseModel<EnhanceImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnhanceImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnhanceImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 图像审核包含鉴黄、政治敏感识别、暴恐识别、图文审核等服务。
        /// 
        /// • 鉴黄：识别图片中是否存在涉黄内容，将图片分为正常、性感、色情三类，并输出分类的置信度。
        /// 
        /// • 政治敏感识别：识别图片中是否存在政治人物、政治恶搞、著名政治事件照片等内容。
        /// 
        /// • 暴恐识别：识别图片中的暴力恐怖元素，例如武器、管制刀具、血腥、恐怖主义等。
        /// 
        /// • 图文审核：结合OCR、NLP和二维码识别算法，分析图片中的文字是否违规，或是否存在二维码等营销内容，并输出违规内容的类别（涉黄、涉政、谩骂、广告营销、暴恐等）。
        /// 
        /// 为了方便使用、减少图片传输次数，图像审核包装成多合一接口，实际上是多个服务。
        /// 
        /// 图像审核根据服务的调用次数收费。例如一张图片同时调用鉴黄、图文审核两个服务，那么此次调用按照两次计费。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="ImageModerationRequest"/></param>
        /// <returns><see cref="ImageModerationResponse"/></returns>
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
        /// ImageModeration接口的同步版本，图像审核包含鉴黄、政治敏感识别、暴恐识别、图文审核等服务。
        /// 
        /// • 鉴黄：识别图片中是否存在涉黄内容，将图片分为正常、性感、色情三类，并输出分类的置信度。
        /// 
        /// • 政治敏感识别：识别图片中是否存在政治人物、政治恶搞、著名政治事件照片等内容。
        /// 
        /// • 暴恐识别：识别图片中的暴力恐怖元素，例如武器、管制刀具、血腥、恐怖主义等。
        /// 
        /// • 图文审核：结合OCR、NLP和二维码识别算法，分析图片中的文字是否违规，或是否存在二维码等营销内容，并输出违规内容的类别（涉黄、涉政、谩骂、广告营销、暴恐等）。
        /// 
        /// 为了方便使用、减少图片传输次数，图像审核包装成多合一接口，实际上是多个服务。
        /// 
        /// 图像审核根据服务的调用次数收费。例如一张图片同时调用鉴黄、图文审核两个服务，那么此次调用按照两次计费。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="ImageModerationRequest"/></param>
        /// <returns>参考<see cref="ImageModerationResponse"/>实例</returns>
        public ImageModerationResponse ImageModerationSync(ImageModerationRequest req)
        {
             JsonResponseModel<ImageModerationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImageModeration");
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
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="RecognizeCarRequest"/></param>
        /// <returns><see cref="RecognizeCarResponse"/></returns>
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

        /// <summary>
        /// RecognizeCar接口的同步版本，腾讯云车辆属性识别可对汽车车身及车辆属性进行检测与识别，目前支持11种车身颜色、20多种车型、300多种品牌、4000多种车系+年款的识别，同时支持对车标的位置进行检测。
        /// >     
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="RecognizeCarRequest"/></param>
        /// <returns>参考<see cref="RecognizeCarResponse"/>实例</returns>
        public RecognizeCarResponse RecognizeCarSync(RecognizeCarRequest req)
        {
             JsonResponseModel<RecognizeCarResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecognizeCar");
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
