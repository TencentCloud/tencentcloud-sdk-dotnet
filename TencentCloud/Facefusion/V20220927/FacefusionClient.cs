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

namespace TencentCloud.Facefusion.V20220927
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Facefusion.V20220927.Models;

   public class FacefusionClient : AbstractClient{

       private const string endpoint = "facefusion.tencentcloudapi.com";
       private const string version = "2022-09-27";
       private const string sdkVersion = "SDK_NET_3.0.1031";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FacefusionClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public FacefusionClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 通常通过腾讯云人脸融合的控制台可以查看到素材相关的参数数据，可以满足使用。本接口返回活动的素材数据，包括素材状态等。用于用户通过Api查看素材相关数据，方便使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaterialListRequest"/></param>
        /// <returns><see cref="DescribeMaterialListResponse"/></returns>
        public Task<DescribeMaterialListResponse> DescribeMaterialList(DescribeMaterialListRequest req)
        {
            return InternalRequestAsync<DescribeMaterialListResponse>(req, "DescribeMaterialList");
        }

        /// <summary>
        /// 通常通过腾讯云人脸融合的控制台可以查看到素材相关的参数数据，可以满足使用。本接口返回活动的素材数据，包括素材状态等。用于用户通过Api查看素材相关数据，方便使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaterialListRequest"/></param>
        /// <returns><see cref="DescribeMaterialListResponse"/></returns>
        public DescribeMaterialListResponse DescribeMaterialListSync(DescribeMaterialListRequest req)
        {
            return InternalRequestAsync<DescribeMaterialListResponse>(req, "DescribeMaterialList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于单脸、多脸、选脸融合，上传人脸图片，得到与素材模板融合后的人脸图片。支持为融合结果图添加标识。查看 <a href="https://cloud.tencent.com/document/product/670/38247" target="_blank">融合接入指引</a>。
        /// 
        /// 请求频率限制为20次/秒。
        /// >
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="FuseFaceRequest"/></param>
        /// <returns><see cref="FuseFaceResponse"/></returns>
        public Task<FuseFaceResponse> FuseFace(FuseFaceRequest req)
        {
            return InternalRequestAsync<FuseFaceResponse>(req, "FuseFace");
        }

        /// <summary>
        /// 本接口用于单脸、多脸、选脸融合，上传人脸图片，得到与素材模板融合后的人脸图片。支持为融合结果图添加标识。查看 <a href="https://cloud.tencent.com/document/product/670/38247" target="_blank">融合接入指引</a>。
        /// 
        /// 请求频率限制为20次/秒。
        /// >
        /// - 公共参数中的签名方式必须指定为V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="FuseFaceRequest"/></param>
        /// <returns><see cref="FuseFaceResponse"/></returns>
        public FuseFaceResponse FuseFaceSync(FuseFaceRequest req)
        {
            return InternalRequestAsync<FuseFaceResponse>(req, "FuseFace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 图片人脸融合（专业版）为同步接口，支持自定义美颜、人脸增强、牙齿增强、拉脸等参数，最高支持8K分辨率，有多个模型类型供选择。查看 <a href="https://cloud.tencent.com/document/product/670/38247" target="_blank">融合接入指引</a>。
        /// 请求频率限制为2次/秒。
        /// </summary>
        /// <param name="req"><see cref="FuseFaceUltraRequest"/></param>
        /// <returns><see cref="FuseFaceUltraResponse"/></returns>
        public Task<FuseFaceUltraResponse> FuseFaceUltra(FuseFaceUltraRequest req)
        {
            return InternalRequestAsync<FuseFaceUltraResponse>(req, "FuseFaceUltra");
        }

        /// <summary>
        /// 图片人脸融合（专业版）为同步接口，支持自定义美颜、人脸增强、牙齿增强、拉脸等参数，最高支持8K分辨率，有多个模型类型供选择。查看 <a href="https://cloud.tencent.com/document/product/670/38247" target="_blank">融合接入指引</a>。
        /// 请求频率限制为2次/秒。
        /// </summary>
        /// <param name="req"><see cref="FuseFaceUltraRequest"/></param>
        /// <returns><see cref="FuseFaceUltraResponse"/></returns>
        public FuseFaceUltraResponse FuseFaceUltraSync(FuseFaceUltraRequest req)
        {
            return InternalRequestAsync<FuseFaceUltraResponse>(req, "FuseFaceUltra")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
