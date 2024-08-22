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

namespace TencentCloud.Tmt.V20180321
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tmt.V20180321.Models;

   public class TmtClient : AbstractClient{

       private const string endpoint = "tmt.tencentcloudapi.com";
       private const string version = "2018-03-21";
       private const string sdkVersion = "SDK_NET_3.0.1075";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TmtClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TmtClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 提交文档原文内容，输出任务ID， 支持原文为单一语种文档（如出现多语言文档，仅支持以选定的源语言相关内容翻译）,文件格式有pdf、docx、pptx、xlsx，支持的文本格式有txt、xml、html、markdown、properties。任务翻译数据可保存7天，7天后不再返回任务数据。请注意保存。
        /// </summary>
        /// <param name="req"><see cref="FileTranslateRequest"/></param>
        /// <returns><see cref="FileTranslateResponse"/></returns>
        public Task<FileTranslateResponse> FileTranslate(FileTranslateRequest req)
        {
            return InternalRequestAsync<FileTranslateResponse>(req, "FileTranslate");
        }

        /// <summary>
        /// 提交文档原文内容，输出任务ID， 支持原文为单一语种文档（如出现多语言文档，仅支持以选定的源语言相关内容翻译）,文件格式有pdf、docx、pptx、xlsx，支持的文本格式有txt、xml、html、markdown、properties。任务翻译数据可保存7天，7天后不再返回任务数据。请注意保存。
        /// </summary>
        /// <param name="req"><see cref="FileTranslateRequest"/></param>
        /// <returns><see cref="FileTranslateResponse"/></returns>
        public FileTranslateResponse FileTranslateSync(FileTranslateRequest req)
        {
            return InternalRequestAsync<FileTranslateResponse>(req, "FileTranslate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在调用文档翻译请求接口后，有回调和轮询两种方式获取识别结果。
        /// •当采用回调方式时，翻译完成后会将结果通过 POST 请求的形式通知到用户在请求时填写的回调 URL，具体请参见[文件翻译回调说明](https://cloud.tencent.com/document/product/551/91138)。
        /// • 当采用轮询方式时，需要主动提交任务ID来轮询识别结果，共有任务成功、等待、执行中和失败四种结果，具体信息请参见参数说明。
        /// </summary>
        /// <param name="req"><see cref="GetFileTranslateRequest"/></param>
        /// <returns><see cref="GetFileTranslateResponse"/></returns>
        public Task<GetFileTranslateResponse> GetFileTranslate(GetFileTranslateRequest req)
        {
            return InternalRequestAsync<GetFileTranslateResponse>(req, "GetFileTranslate");
        }

        /// <summary>
        /// 在调用文档翻译请求接口后，有回调和轮询两种方式获取识别结果。
        /// •当采用回调方式时，翻译完成后会将结果通过 POST 请求的形式通知到用户在请求时填写的回调 URL，具体请参见[文件翻译回调说明](https://cloud.tencent.com/document/product/551/91138)。
        /// • 当采用轮询方式时，需要主动提交任务ID来轮询识别结果，共有任务成功、等待、执行中和失败四种结果，具体信息请参见参数说明。
        /// </summary>
        /// <param name="req"><see cref="GetFileTranslateRequest"/></param>
        /// <returns><see cref="GetFileTranslateResponse"/></returns>
        public GetFileTranslateResponse GetFileTranslateSync(GetFileTranslateRequest req)
        {
            return InternalRequestAsync<GetFileTranslateResponse>(req, "GetFileTranslate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供13种语言的图片翻译服务，可自动识别图片中的文本内容并翻译成目标语言，识别后的文本按行翻译，后续会提供可按段落翻译的版本。<br />
        /// 提示：对于一般开发者，我们建议优先使用SDK接入简化开发。SDK使用介绍请直接查看 5. 开发者资源 部分。
        /// </summary>
        /// <param name="req"><see cref="ImageTranslateRequest"/></param>
        /// <returns><see cref="ImageTranslateResponse"/></returns>
        public Task<ImageTranslateResponse> ImageTranslate(ImageTranslateRequest req)
        {
            return InternalRequestAsync<ImageTranslateResponse>(req, "ImageTranslate");
        }

        /// <summary>
        /// 提供13种语言的图片翻译服务，可自动识别图片中的文本内容并翻译成目标语言，识别后的文本按行翻译，后续会提供可按段落翻译的版本。<br />
        /// 提示：对于一般开发者，我们建议优先使用SDK接入简化开发。SDK使用介绍请直接查看 5. 开发者资源 部分。
        /// </summary>
        /// <param name="req"><see cref="ImageTranslateRequest"/></param>
        /// <returns><see cref="ImageTranslateResponse"/></returns>
        public ImageTranslateResponse ImageTranslateSync(ImageTranslateRequest req)
        {
            return InternalRequestAsync<ImageTranslateResponse>(req, "ImageTranslate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可自动识别文本内容的语言种类，轻量高效，无需额外实现判断方式，使面向客户的服务体验更佳。 <br />
        /// 提示：对于一般开发者，我们建议优先使用SDK接入简化开发。SDK使用介绍请直接查看 5. 开发者资源 部分。
        /// </summary>
        /// <param name="req"><see cref="LanguageDetectRequest"/></param>
        /// <returns><see cref="LanguageDetectResponse"/></returns>
        public Task<LanguageDetectResponse> LanguageDetect(LanguageDetectRequest req)
        {
            return InternalRequestAsync<LanguageDetectResponse>(req, "LanguageDetect");
        }

        /// <summary>
        /// 可自动识别文本内容的语言种类，轻量高效，无需额外实现判断方式，使面向客户的服务体验更佳。 <br />
        /// 提示：对于一般开发者，我们建议优先使用SDK接入简化开发。SDK使用介绍请直接查看 5. 开发者资源 部分。
        /// </summary>
        /// <param name="req"><see cref="LanguageDetectRequest"/></param>
        /// <returns><see cref="LanguageDetectResponse"/></returns>
        public LanguageDetectResponse LanguageDetectSync(LanguageDetectRequest req)
        {
            return InternalRequestAsync<LanguageDetectResponse>(req, "LanguageDetect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口提供上传音频，将音频进行语音识别并翻译成文本的服务，目前开放中英互译的语音翻译服务。
        /// 待识别和翻译的音频文件可以是 pcm、mp3和speex 格式，pcm采样率要求16kHz、位深16bit、单声道，音频内语音清晰。<br/>
        /// 如果采用流式传输的方式，要求每个分片时长200ms~500ms；如果采用非流式的传输方式，要求音频时长不超过8s。注意最后一个分片的IsEnd参数设置为1。<br />
        /// 提示：对于一般开发者，我们建议优先使用SDK接入简化开发。SDK使用介绍请直接查看 5. 开发者资源部分。
        /// </summary>
        /// <param name="req"><see cref="SpeechTranslateRequest"/></param>
        /// <returns><see cref="SpeechTranslateResponse"/></returns>
        public Task<SpeechTranslateResponse> SpeechTranslate(SpeechTranslateRequest req)
        {
            return InternalRequestAsync<SpeechTranslateResponse>(req, "SpeechTranslate");
        }

        /// <summary>
        /// 本接口提供上传音频，将音频进行语音识别并翻译成文本的服务，目前开放中英互译的语音翻译服务。
        /// 待识别和翻译的音频文件可以是 pcm、mp3和speex 格式，pcm采样率要求16kHz、位深16bit、单声道，音频内语音清晰。<br/>
        /// 如果采用流式传输的方式，要求每个分片时长200ms~500ms；如果采用非流式的传输方式，要求音频时长不超过8s。注意最后一个分片的IsEnd参数设置为1。<br />
        /// 提示：对于一般开发者，我们建议优先使用SDK接入简化开发。SDK使用介绍请直接查看 5. 开发者资源部分。
        /// </summary>
        /// <param name="req"><see cref="SpeechTranslateRequest"/></param>
        /// <returns><see cref="SpeechTranslateResponse"/></returns>
        public SpeechTranslateResponse SpeechTranslateSync(SpeechTranslateRequest req)
        {
            return InternalRequestAsync<SpeechTranslateResponse>(req, "SpeechTranslate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯翻译为合作伙伴提供文本翻译、文档翻译、交互翻译、AI同传等多种机器翻译服务，具有toB多行业解决方案。作为WMT世界机器翻译大赛冠军，翻译准确度值得信赖，其中，交互翻译能力是业界领先技术；腾讯同传是AI同传业界标杆。<br />
        /// 提示：对于一般开发者，我们建议优先使用SDK接入简化开发。SDK使用介绍请直接查看 5. 开发者资源 部分。
        /// </summary>
        /// <param name="req"><see cref="TextTranslateRequest"/></param>
        /// <returns><see cref="TextTranslateResponse"/></returns>
        public Task<TextTranslateResponse> TextTranslate(TextTranslateRequest req)
        {
            return InternalRequestAsync<TextTranslateResponse>(req, "TextTranslate");
        }

        /// <summary>
        /// 腾讯翻译为合作伙伴提供文本翻译、文档翻译、交互翻译、AI同传等多种机器翻译服务，具有toB多行业解决方案。作为WMT世界机器翻译大赛冠军，翻译准确度值得信赖，其中，交互翻译能力是业界领先技术；腾讯同传是AI同传业界标杆。<br />
        /// 提示：对于一般开发者，我们建议优先使用SDK接入简化开发。SDK使用介绍请直接查看 5. 开发者资源 部分。
        /// </summary>
        /// <param name="req"><see cref="TextTranslateRequest"/></param>
        /// <returns><see cref="TextTranslateResponse"/></returns>
        public TextTranslateResponse TextTranslateSync(TextTranslateRequest req)
        {
            return InternalRequestAsync<TextTranslateResponse>(req, "TextTranslate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文本翻译的批量接口
        /// </summary>
        /// <param name="req"><see cref="TextTranslateBatchRequest"/></param>
        /// <returns><see cref="TextTranslateBatchResponse"/></returns>
        public Task<TextTranslateBatchResponse> TextTranslateBatch(TextTranslateBatchRequest req)
        {
            return InternalRequestAsync<TextTranslateBatchResponse>(req, "TextTranslateBatch");
        }

        /// <summary>
        /// 文本翻译的批量接口
        /// </summary>
        /// <param name="req"><see cref="TextTranslateBatchRequest"/></param>
        /// <returns><see cref="TextTranslateBatchResponse"/></returns>
        public TextTranslateBatchResponse TextTranslateBatchSync(TextTranslateBatchRequest req)
        {
            return InternalRequestAsync<TextTranslateBatchResponse>(req, "TextTranslateBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
