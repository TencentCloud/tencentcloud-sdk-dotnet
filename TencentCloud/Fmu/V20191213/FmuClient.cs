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

namespace TencentCloud.Fmu.V20191213
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Fmu.V20191213.Models;

   public class FmuClient : AbstractClient{

       private const string endpoint = "fmu.tencentcloudapi.com";
       private const string version = "2019-12-13";
       private const string sdkVersion = "SDK_NET_3.0.1158";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FmuClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public FmuClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 用户上传一张人脸图片（最多能处理一张图片中最大的五张人脸信息），精准定位五官，实现美肤、亮肤、祛痘等美颜功能。
        /// </summary>
        /// <param name="req"><see cref="BeautifyPicRequest"/></param>
        /// <returns><see cref="BeautifyPicResponse"/></returns>
        public Task<BeautifyPicResponse> BeautifyPic(BeautifyPicRequest req)
        {
            return InternalRequestAsync<BeautifyPicResponse>(req, "BeautifyPic");
        }

        /// <summary>
        /// 用户上传一张人脸图片（最多能处理一张图片中最大的五张人脸信息），精准定位五官，实现美肤、亮肤、祛痘等美颜功能。
        /// </summary>
        /// <param name="req"><see cref="BeautifyPicRequest"/></param>
        /// <returns><see cref="BeautifyPicResponse"/></returns>
        public BeautifyPicResponse BeautifyPicSync(BeautifyPicRequest req)
        {
            return InternalRequestAsync<BeautifyPicResponse>(req, "BeautifyPic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 产品不再维护，准备下线。
        /// 
        /// 视频美颜(此接口目前已下线)
        /// </summary>
        /// <param name="req"><see cref="BeautifyVideoRequest"/></param>
        /// <returns><see cref="BeautifyVideoResponse"/></returns>
        public Task<BeautifyVideoResponse> BeautifyVideo(BeautifyVideoRequest req)
        {
            return InternalRequestAsync<BeautifyVideoResponse>(req, "BeautifyVideo");
        }

        /// <summary>
        /// 产品不再维护，准备下线。
        /// 
        /// 视频美颜(此接口目前已下线)
        /// </summary>
        /// <param name="req"><see cref="BeautifyVideoRequest"/></param>
        /// <returns><see cref="BeautifyVideoResponse"/></returns>
        public BeautifyVideoResponse BeautifyVideoSync(BeautifyVideoRequest req)
        {
            return InternalRequestAsync<BeautifyVideoResponse>(req, "BeautifyVideo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 产品不再维护，准备下线。
        /// 
        /// 撤销视频美颜任务请求
        /// </summary>
        /// <param name="req"><see cref="CancelBeautifyVideoJobRequest"/></param>
        /// <returns><see cref="CancelBeautifyVideoJobResponse"/></returns>
        public Task<CancelBeautifyVideoJobResponse> CancelBeautifyVideoJob(CancelBeautifyVideoJobRequest req)
        {
            return InternalRequestAsync<CancelBeautifyVideoJobResponse>(req, "CancelBeautifyVideoJob");
        }

        /// <summary>
        /// 产品不再维护，准备下线。
        /// 
        /// 撤销视频美颜任务请求
        /// </summary>
        /// <param name="req"><see cref="CancelBeautifyVideoJobRequest"/></param>
        /// <returns><see cref="CancelBeautifyVideoJobResponse"/></returns>
        public CancelBeautifyVideoJobResponse CancelBeautifyVideoJobSync(CancelBeautifyVideoJobRequest req)
        {
            return InternalRequestAsync<CancelBeautifyVideoJobResponse>(req, "CancelBeautifyVideoJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在使用LUT素材的modelid实现试唇色前，您需要先上传 LUT 格式的cube文件注册唇色ID。查看 [LUT文件的使用说明](https://cloud.tencent.com/document/product/1172/41701)。
        /// 
        /// 注：您也可以直接使用 [试唇色接口](https://cloud.tencent.com/document/product/1172/40706)，通过输入RGBA模型数值的方式指定唇色，更简单易用。
        /// </summary>
        /// <param name="req"><see cref="CreateModelRequest"/></param>
        /// <returns><see cref="CreateModelResponse"/></returns>
        public Task<CreateModelResponse> CreateModel(CreateModelRequest req)
        {
            return InternalRequestAsync<CreateModelResponse>(req, "CreateModel");
        }

        /// <summary>
        /// 在使用LUT素材的modelid实现试唇色前，您需要先上传 LUT 格式的cube文件注册唇色ID。查看 [LUT文件的使用说明](https://cloud.tencent.com/document/product/1172/41701)。
        /// 
        /// 注：您也可以直接使用 [试唇色接口](https://cloud.tencent.com/document/product/1172/40706)，通过输入RGBA模型数值的方式指定唇色，更简单易用。
        /// </summary>
        /// <param name="req"><see cref="CreateModelRequest"/></param>
        /// <returns><see cref="CreateModelResponse"/></returns>
        public CreateModelResponse CreateModelSync(CreateModelRequest req)
        {
            return InternalRequestAsync<CreateModelResponse>(req, "CreateModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除已注册的唇色素材。
        /// </summary>
        /// <param name="req"><see cref="DeleteModelRequest"/></param>
        /// <returns><see cref="DeleteModelResponse"/></returns>
        public Task<DeleteModelResponse> DeleteModel(DeleteModelRequest req)
        {
            return InternalRequestAsync<DeleteModelResponse>(req, "DeleteModel");
        }

        /// <summary>
        /// 删除已注册的唇色素材。
        /// </summary>
        /// <param name="req"><see cref="DeleteModelRequest"/></param>
        /// <returns><see cref="DeleteModelResponse"/></returns>
        public DeleteModelResponse DeleteModelSync(DeleteModelRequest req)
        {
            return InternalRequestAsync<DeleteModelResponse>(req, "DeleteModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询已注册的唇色素材。
        /// </summary>
        /// <param name="req"><see cref="GetModelListRequest"/></param>
        /// <returns><see cref="GetModelListResponse"/></returns>
        public Task<GetModelListResponse> GetModelList(GetModelListRequest req)
        {
            return InternalRequestAsync<GetModelListResponse>(req, "GetModelList");
        }

        /// <summary>
        /// 查询已注册的唇色素材。
        /// </summary>
        /// <param name="req"><see cref="GetModelListRequest"/></param>
        /// <returns><see cref="GetModelListResponse"/></returns>
        public GetModelListResponse GetModelListSync(GetModelListRequest req)
        {
            return InternalRequestAsync<GetModelListResponse>(req, "GetModelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 产品不再维护，准备下线。
        /// 
        /// 查询视频美颜处理进度
        /// </summary>
        /// <param name="req"><see cref="QueryBeautifyVideoJobRequest"/></param>
        /// <returns><see cref="QueryBeautifyVideoJobResponse"/></returns>
        public Task<QueryBeautifyVideoJobResponse> QueryBeautifyVideoJob(QueryBeautifyVideoJobRequest req)
        {
            return InternalRequestAsync<QueryBeautifyVideoJobResponse>(req, "QueryBeautifyVideoJob");
        }

        /// <summary>
        /// 产品不再维护，准备下线。
        /// 
        /// 查询视频美颜处理进度
        /// </summary>
        /// <param name="req"><see cref="QueryBeautifyVideoJobRequest"/></param>
        /// <returns><see cref="QueryBeautifyVideoJobResponse"/></returns>
        public QueryBeautifyVideoJobResponse QueryBeautifyVideoJobSync(QueryBeautifyVideoJobRequest req)
        {
            return InternalRequestAsync<QueryBeautifyVideoJobResponse>(req, "QueryBeautifyVideoJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传一张照片，输出滤镜处理后的图片。
        /// </summary>
        /// <param name="req"><see cref="StyleImageRequest"/></param>
        /// <returns><see cref="StyleImageResponse"/></returns>
        public Task<StyleImageResponse> StyleImage(StyleImageRequest req)
        {
            return InternalRequestAsync<StyleImageResponse>(req, "StyleImage");
        }

        /// <summary>
        /// 上传一张照片，输出滤镜处理后的图片。
        /// </summary>
        /// <param name="req"><see cref="StyleImageRequest"/></param>
        /// <returns><see cref="StyleImageResponse"/></returns>
        public StyleImageResponse StyleImageSync(StyleImageRequest req)
        {
            return InternalRequestAsync<StyleImageResponse>(req, "StyleImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传一张照片，输出滤镜处理后的图片。
        /// </summary>
        /// <param name="req"><see cref="StyleImageProRequest"/></param>
        /// <returns><see cref="StyleImageProResponse"/></returns>
        public Task<StyleImageProResponse> StyleImagePro(StyleImageProRequest req)
        {
            return InternalRequestAsync<StyleImageProResponse>(req, "StyleImagePro");
        }

        /// <summary>
        /// 上传一张照片，输出滤镜处理后的图片。
        /// </summary>
        /// <param name="req"><see cref="StyleImageProRequest"/></param>
        /// <returns><see cref="StyleImageProResponse"/></returns>
        public StyleImageProResponse StyleImageProSync(StyleImageProRequest req)
        {
            return InternalRequestAsync<StyleImageProResponse>(req, "StyleImagePro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对图片中的人脸嘴唇进行着色，最多支持同时对一张图中的3张人脸进行试唇色。
        /// 
        /// 您可以通过事先注册在腾讯云的唇色素材（LUT文件）改变图片中的人脸唇色，也可以输入RGBA模型数值。
        /// 
        /// 为了更好的效果，建议您使用事先注册在腾讯云的唇色素材（LUT文件）。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="TryLipstickPicRequest"/></param>
        /// <returns><see cref="TryLipstickPicResponse"/></returns>
        public Task<TryLipstickPicResponse> TryLipstickPic(TryLipstickPicRequest req)
        {
            return InternalRequestAsync<TryLipstickPicResponse>(req, "TryLipstickPic");
        }

        /// <summary>
        /// 对图片中的人脸嘴唇进行着色，最多支持同时对一张图中的3张人脸进行试唇色。
        /// 
        /// 您可以通过事先注册在腾讯云的唇色素材（LUT文件）改变图片中的人脸唇色，也可以输入RGBA模型数值。
        /// 
        /// 为了更好的效果，建议您使用事先注册在腾讯云的唇色素材（LUT文件）。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="TryLipstickPicRequest"/></param>
        /// <returns><see cref="TryLipstickPicResponse"/></returns>
        public TryLipstickPicResponse TryLipstickPicSync(TryLipstickPicRequest req)
        {
            return InternalRequestAsync<TryLipstickPicResponse>(req, "TryLipstickPic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
