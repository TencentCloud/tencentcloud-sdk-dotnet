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

namespace TencentCloud.Aiart.V20221229
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Aiart.V20221229.Models;

   public class AiartClient : AbstractClient{

       private const string endpoint = "aiart.tencentcloudapi.com";
       private const string version = "2022-12-29";
       private const string sdkVersion = "SDK_NET_3.0.955";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AiartClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AiartClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 智能图生图接口将根据输入的图片及辅助描述文本，智能生成与之相关的结果图。
        /// 输入：单边分辨率小于2000、转成 Base64 字符串后小于 5MB 的图片，建议同时输入描述文本。
        /// 输出：对应风格及分辨率的 AI 生成图。
        /// 可支持的风格详见 [智能图生图风格列表](https://cloud.tencent.com/document/product/1668/86250)，请将列表中的“风格编号”传入 Styles 数组，建议选择一种风格。
        /// 
        /// 请求频率限制为1次/秒。
        /// </summary>
        /// <param name="req"><see cref="ImageToImageRequest"/></param>
        /// <returns><see cref="ImageToImageResponse"/></returns>
        public Task<ImageToImageResponse> ImageToImage(ImageToImageRequest req)
        {
            return InternalRequestAsync<ImageToImageResponse>(req, "ImageToImage");
        }

        /// <summary>
        /// 智能图生图接口将根据输入的图片及辅助描述文本，智能生成与之相关的结果图。
        /// 输入：单边分辨率小于2000、转成 Base64 字符串后小于 5MB 的图片，建议同时输入描述文本。
        /// 输出：对应风格及分辨率的 AI 生成图。
        /// 可支持的风格详见 [智能图生图风格列表](https://cloud.tencent.com/document/product/1668/86250)，请将列表中的“风格编号”传入 Styles 数组，建议选择一种风格。
        /// 
        /// 请求频率限制为1次/秒。
        /// </summary>
        /// <param name="req"><see cref="ImageToImageRequest"/></param>
        /// <returns><see cref="ImageToImageResponse"/></returns>
        public ImageToImageResponse ImageToImageSync(ImageToImageRequest req)
        {
            return InternalRequestAsync<ImageToImageResponse>(req, "ImageToImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能文生图接口将根据输入的描述文本，智能生成与之相关的结果图。
        /// 输入：256个字符以内的描述性文本，推荐使用中文。
        /// 输出：对应风格及分辨率的 AI 生成图。
        /// 可支持的风格详见 [智能文生图风格列表](https://cloud.tencent.com/document/product/1668/86249)，请将列表中的“风格编号”传入 Styles 数组，建议选择一种风格。
        /// 
        /// 请求频率限制为1次/秒。
        /// </summary>
        /// <param name="req"><see cref="TextToImageRequest"/></param>
        /// <returns><see cref="TextToImageResponse"/></returns>
        public Task<TextToImageResponse> TextToImage(TextToImageRequest req)
        {
            return InternalRequestAsync<TextToImageResponse>(req, "TextToImage");
        }

        /// <summary>
        /// 智能文生图接口将根据输入的描述文本，智能生成与之相关的结果图。
        /// 输入：256个字符以内的描述性文本，推荐使用中文。
        /// 输出：对应风格及分辨率的 AI 生成图。
        /// 可支持的风格详见 [智能文生图风格列表](https://cloud.tencent.com/document/product/1668/86249)，请将列表中的“风格编号”传入 Styles 数组，建议选择一种风格。
        /// 
        /// 请求频率限制为1次/秒。
        /// </summary>
        /// <param name="req"><see cref="TextToImageRequest"/></param>
        /// <returns><see cref="TextToImageResponse"/></returns>
        public TextToImageResponse TextToImageSync(TextToImageRequest req)
        {
            return InternalRequestAsync<TextToImageResponse>(req, "TextToImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
