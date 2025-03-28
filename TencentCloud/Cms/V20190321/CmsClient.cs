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

namespace TencentCloud.Cms.V20190321
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cms.V20190321.Models;

   public class CmsClient : AbstractClient{

       private const string endpoint = "cms.tencentcloudapi.com";
       private const string version = "2019-03-21";
       private const string sdkVersion = "SDK_NET_3.0.1211";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建关键词接口
        /// </summary>
        /// <param name="req"><see cref="CreateKeywordsSamplesRequest"/></param>
        /// <returns><see cref="CreateKeywordsSamplesResponse"/></returns>
        public Task<CreateKeywordsSamplesResponse> CreateKeywordsSamples(CreateKeywordsSamplesRequest req)
        {
            return InternalRequestAsync<CreateKeywordsSamplesResponse>(req, "CreateKeywordsSamples");
        }

        /// <summary>
        /// 创建关键词接口
        /// </summary>
        /// <param name="req"><see cref="CreateKeywordsSamplesRequest"/></param>
        /// <returns><see cref="CreateKeywordsSamplesResponse"/></returns>
        public CreateKeywordsSamplesResponse CreateKeywordsSamplesSync(CreateKeywordsSamplesRequest req)
        {
            return InternalRequestAsync<CreateKeywordsSamplesResponse>(req, "CreateKeywordsSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除关键词接口
        /// </summary>
        /// <param name="req"><see cref="DeleteLibSamplesRequest"/></param>
        /// <returns><see cref="DeleteLibSamplesResponse"/></returns>
        public Task<DeleteLibSamplesResponse> DeleteLibSamples(DeleteLibSamplesRequest req)
        {
            return InternalRequestAsync<DeleteLibSamplesResponse>(req, "DeleteLibSamples");
        }

        /// <summary>
        /// 删除关键词接口
        /// </summary>
        /// <param name="req"><see cref="DeleteLibSamplesRequest"/></param>
        /// <returns><see cref="DeleteLibSamplesResponse"/></returns>
        public DeleteLibSamplesResponse DeleteLibSamplesSync(DeleteLibSamplesRequest req)
        {
            return InternalRequestAsync<DeleteLibSamplesResponse>(req, "DeleteLibSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户词库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeKeywordsLibsRequest"/></param>
        /// <returns><see cref="DescribeKeywordsLibsResponse"/></returns>
        public Task<DescribeKeywordsLibsResponse> DescribeKeywordsLibs(DescribeKeywordsLibsRequest req)
        {
            return InternalRequestAsync<DescribeKeywordsLibsResponse>(req, "DescribeKeywordsLibs");
        }

        /// <summary>
        /// 获取用户词库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeKeywordsLibsRequest"/></param>
        /// <returns><see cref="DescribeKeywordsLibsResponse"/></returns>
        public DescribeKeywordsLibsResponse DescribeKeywordsLibsSync(DescribeKeywordsLibsRequest req)
        {
            return InternalRequestAsync<DescribeKeywordsLibsResponse>(req, "DescribeKeywordsLibs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取关键词接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLibSamplesRequest"/></param>
        /// <returns><see cref="DescribeLibSamplesResponse"/></returns>
        public Task<DescribeLibSamplesResponse> DescribeLibSamples(DescribeLibSamplesRequest req)
        {
            return InternalRequestAsync<DescribeLibSamplesResponse>(req, "DescribeLibSamples");
        }

        /// <summary>
        /// 获取关键词接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLibSamplesRequest"/></param>
        /// <returns><see cref="DescribeLibSamplesResponse"/></returns>
        public DescribeLibSamplesResponse DescribeLibSamplesSync(DescribeLibSamplesRequest req)
        {
            return InternalRequestAsync<DescribeLibSamplesResponse>(req, "DescribeLibSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 图片内容检测服务（Image Moderation, IM）能自动扫描图片，识别涉黄、涉恐、涉政、涉毒等有害内容，同时支持用户配置图片黑名单，打击自定义的违规图片。
        /// </summary>
        /// <param name="req"><see cref="ImageModerationRequest"/></param>
        /// <returns><see cref="ImageModerationResponse"/></returns>
        public Task<ImageModerationResponse> ImageModeration(ImageModerationRequest req)
        {
            return InternalRequestAsync<ImageModerationResponse>(req, "ImageModeration");
        }

        /// <summary>
        /// 图片内容检测服务（Image Moderation, IM）能自动扫描图片，识别涉黄、涉恐、涉政、涉毒等有害内容，同时支持用户配置图片黑名单，打击自定义的违规图片。
        /// </summary>
        /// <param name="req"><see cref="ImageModerationRequest"/></param>
        /// <returns><see cref="ImageModerationResponse"/></returns>
        public ImageModerationResponse ImageModerationSync(ImageModerationRequest req)
        {
            return InternalRequestAsync<ImageModerationResponse>(req, "ImageModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文本内容检测（Text Moderation）服务使用了深度学习技术，识别涉黄、涉政、涉恐等有害内容，同时支持用户配置词库，打击自定义的违规文本。
        /// </summary>
        /// <param name="req"><see cref="TextModerationRequest"/></param>
        /// <returns><see cref="TextModerationResponse"/></returns>
        public Task<TextModerationResponse> TextModeration(TextModerationRequest req)
        {
            return InternalRequestAsync<TextModerationResponse>(req, "TextModeration");
        }

        /// <summary>
        /// 文本内容检测（Text Moderation）服务使用了深度学习技术，识别涉黄、涉政、涉恐等有害内容，同时支持用户配置词库，打击自定义的违规文本。
        /// </summary>
        /// <param name="req"><see cref="TextModerationRequest"/></param>
        /// <returns><see cref="TextModerationResponse"/></returns>
        public TextModerationResponse TextModerationSync(TextModerationRequest req)
        {
            return InternalRequestAsync<TextModerationResponse>(req, "TextModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
