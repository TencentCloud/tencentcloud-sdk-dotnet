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

namespace TencentCloud.Mrs.V20200910
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mrs.V20200910.Models;

   public class MrsClient : AbstractClient{

       private const string endpoint = "mrs.tencentcloudapi.com";
       private const string version = "2020-09-10";
       private const string sdkVersion = "SDK_NET_3.0.1152";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MrsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MrsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 药品说明书PDF文件结构化
        /// </summary>
        /// <param name="req"><see cref="DrugInstructionObjectRequest"/></param>
        /// <returns><see cref="DrugInstructionObjectResponse"/></returns>
        public Task<DrugInstructionObjectResponse> DrugInstructionObject(DrugInstructionObjectRequest req)
        {
            return InternalRequestAsync<DrugInstructionObjectResponse>(req, "DrugInstructionObject");
        }

        /// <summary>
        /// 药品说明书PDF文件结构化
        /// </summary>
        /// <param name="req"><see cref="DrugInstructionObjectRequest"/></param>
        /// <returns><see cref="DrugInstructionObjectResponse"/></returns>
        public DrugInstructionObjectResponse DrugInstructionObjectSync(DrugInstructionObjectRequest req)
        {
            return InternalRequestAsync<DrugInstructionObjectResponse>(req, "DrugInstructionObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 医疗报告图片脱敏接口
        /// </summary>
        /// <param name="req"><see cref="ImageMaskRequest"/></param>
        /// <returns><see cref="ImageMaskResponse"/></returns>
        public Task<ImageMaskResponse> ImageMask(ImageMaskRequest req)
        {
            return InternalRequestAsync<ImageMaskResponse>(req, "ImageMask");
        }

        /// <summary>
        /// 医疗报告图片脱敏接口
        /// </summary>
        /// <param name="req"><see cref="ImageMaskRequest"/></param>
        /// <returns><see cref="ImageMaskResponse"/></returns>
        public ImageMaskResponse ImageMaskSync(ImageMaskRequest req)
        {
            return InternalRequestAsync<ImageMaskResponse>(req, "ImageMask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 图片脱敏-异步接口
        /// </summary>
        /// <param name="req"><see cref="ImageMaskAsyncRequest"/></param>
        /// <returns><see cref="ImageMaskAsyncResponse"/></returns>
        public Task<ImageMaskAsyncResponse> ImageMaskAsync(ImageMaskAsyncRequest req)
        {
            return InternalRequestAsync<ImageMaskAsyncResponse>(req, "ImageMaskAsync");
        }

        /// <summary>
        /// 图片脱敏-异步接口
        /// </summary>
        /// <param name="req"><see cref="ImageMaskAsyncRequest"/></param>
        /// <returns><see cref="ImageMaskAsyncResponse"/></returns>
        public ImageMaskAsyncResponse ImageMaskAsyncSync(ImageMaskAsyncRequest req)
        {
            return InternalRequestAsync<ImageMaskAsyncResponse>(req, "ImageMaskAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 图片脱敏-异步获取结果接口
        /// </summary>
        /// <param name="req"><see cref="ImageMaskAsyncGetResultRequest"/></param>
        /// <returns><see cref="ImageMaskAsyncGetResultResponse"/></returns>
        public Task<ImageMaskAsyncGetResultResponse> ImageMaskAsyncGetResult(ImageMaskAsyncGetResultRequest req)
        {
            return InternalRequestAsync<ImageMaskAsyncGetResultResponse>(req, "ImageMaskAsyncGetResult");
        }

        /// <summary>
        /// 图片脱敏-异步获取结果接口
        /// </summary>
        /// <param name="req"><see cref="ImageMaskAsyncGetResultRequest"/></param>
        /// <returns><see cref="ImageMaskAsyncGetResultResponse"/></returns>
        public ImageMaskAsyncGetResultResponse ImageMaskAsyncGetResultSync(ImageMaskAsyncGetResultRequest req)
        {
            return InternalRequestAsync<ImageMaskAsyncGetResultResponse>(req, "ImageMaskAsyncGetResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 图片分类
        /// </summary>
        /// <param name="req"><see cref="ImageToClassRequest"/></param>
        /// <returns><see cref="ImageToClassResponse"/></returns>
        public Task<ImageToClassResponse> ImageToClass(ImageToClassRequest req)
        {
            return InternalRequestAsync<ImageToClassResponse>(req, "ImageToClass");
        }

        /// <summary>
        /// 图片分类
        /// </summary>
        /// <param name="req"><see cref="ImageToClassRequest"/></param>
        /// <returns><see cref="ImageToClassResponse"/></returns>
        public ImageToClassResponse ImageToClassSync(ImageToClassRequest req)
        {
            return InternalRequestAsync<ImageToClassResponse>(req, "ImageToClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 图片转结构化对象
        /// </summary>
        /// <param name="req"><see cref="ImageToObjectRequest"/></param>
        /// <returns><see cref="ImageToObjectResponse"/></returns>
        public Task<ImageToObjectResponse> ImageToObject(ImageToObjectRequest req)
        {
            return InternalRequestAsync<ImageToObjectResponse>(req, "ImageToObject");
        }

        /// <summary>
        /// 图片转结构化对象
        /// </summary>
        /// <param name="req"><see cref="ImageToObjectRequest"/></param>
        /// <returns><see cref="ImageToObjectResponse"/></returns>
        public ImageToObjectResponse ImageToObjectSync(ImageToObjectRequest req)
        {
            return InternalRequestAsync<ImageToObjectResponse>(req, "ImageToObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文本分类
        /// 
        /// 适用场景：经过腾讯医疗专用 OCR 从图片识别之后的文本，并且需要加上每个字符的坐标信息，才可以调用此接口。通过其它 OCR 识别的文本可能不适配。医院的 XML 格式文本也不适配，XML 文件需要经过特殊转换才能直接调用此接口。单次调用传入的文本不宜超过 2000 字。如有需要调用此接口，建议先咨询产品团队。
        /// </summary>
        /// <param name="req"><see cref="TextToClassRequest"/></param>
        /// <returns><see cref="TextToClassResponse"/></returns>
        public Task<TextToClassResponse> TextToClass(TextToClassRequest req)
        {
            return InternalRequestAsync<TextToClassResponse>(req, "TextToClass");
        }

        /// <summary>
        /// 文本分类
        /// 
        /// 适用场景：经过腾讯医疗专用 OCR 从图片识别之后的文本，并且需要加上每个字符的坐标信息，才可以调用此接口。通过其它 OCR 识别的文本可能不适配。医院的 XML 格式文本也不适配，XML 文件需要经过特殊转换才能直接调用此接口。单次调用传入的文本不宜超过 2000 字。如有需要调用此接口，建议先咨询产品团队。
        /// </summary>
        /// <param name="req"><see cref="TextToClassRequest"/></param>
        /// <returns><see cref="TextToClassResponse"/></returns>
        public TextToClassResponse TextToClassSync(TextToClassRequest req)
        {
            return InternalRequestAsync<TextToClassResponse>(req, "TextToClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文本转结构化对象。
        /// 
        /// 适用场景：经过腾讯医疗专用 OCR 从图片识别之后的文本，可以调用此接口。通过其它 OCR 识别的文本可能不适配。医院的 XML 格式文本也不适配，XML 文件需要经过特殊转换才能直接调用此接口。单次调用传入的文本不宜超过 2000 字。
        /// </summary>
        /// <param name="req"><see cref="TextToObjectRequest"/></param>
        /// <returns><see cref="TextToObjectResponse"/></returns>
        public Task<TextToObjectResponse> TextToObject(TextToObjectRequest req)
        {
            return InternalRequestAsync<TextToObjectResponse>(req, "TextToObject");
        }

        /// <summary>
        /// 文本转结构化对象。
        /// 
        /// 适用场景：经过腾讯医疗专用 OCR 从图片识别之后的文本，可以调用此接口。通过其它 OCR 识别的文本可能不适配。医院的 XML 格式文本也不适配，XML 文件需要经过特殊转换才能直接调用此接口。单次调用传入的文本不宜超过 2000 字。
        /// </summary>
        /// <param name="req"><see cref="TextToObjectRequest"/></param>
        /// <returns><see cref="TextToObjectResponse"/></returns>
        public TextToObjectResponse TextToObjectSync(TextToObjectRequest req)
        {
            return InternalRequestAsync<TextToObjectResponse>(req, "TextToObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将PDF格式的体检报告文件结构化，解析关键信息。
        /// 注意：该接口是按照体检报告 PDF 页面数量统计次数，不是按照 PDF 文件数量统计次数。通过该接口传入的报告必须是体检报告，非体检报告可能无法正确解析。
        /// </summary>
        /// <param name="req"><see cref="TurnPDFToObjectRequest"/></param>
        /// <returns><see cref="TurnPDFToObjectResponse"/></returns>
        public Task<TurnPDFToObjectResponse> TurnPDFToObject(TurnPDFToObjectRequest req)
        {
            return InternalRequestAsync<TurnPDFToObjectResponse>(req, "TurnPDFToObject");
        }

        /// <summary>
        /// 将PDF格式的体检报告文件结构化，解析关键信息。
        /// 注意：该接口是按照体检报告 PDF 页面数量统计次数，不是按照 PDF 文件数量统计次数。通过该接口传入的报告必须是体检报告，非体检报告可能无法正确解析。
        /// </summary>
        /// <param name="req"><see cref="TurnPDFToObjectRequest"/></param>
        /// <returns><see cref="TurnPDFToObjectResponse"/></returns>
        public TurnPDFToObjectResponse TurnPDFToObjectSync(TurnPDFToObjectRequest req)
        {
            return InternalRequestAsync<TurnPDFToObjectResponse>(req, "TurnPDFToObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 体检报告PDF文件结构化-异步接口
        /// </summary>
        /// <param name="req"><see cref="TurnPDFToObjectAsyncRequest"/></param>
        /// <returns><see cref="TurnPDFToObjectAsyncResponse"/></returns>
        public Task<TurnPDFToObjectAsyncResponse> TurnPDFToObjectAsync(TurnPDFToObjectAsyncRequest req)
        {
            return InternalRequestAsync<TurnPDFToObjectAsyncResponse>(req, "TurnPDFToObjectAsync");
        }

        /// <summary>
        /// 体检报告PDF文件结构化-异步接口
        /// </summary>
        /// <param name="req"><see cref="TurnPDFToObjectAsyncRequest"/></param>
        /// <returns><see cref="TurnPDFToObjectAsyncResponse"/></returns>
        public TurnPDFToObjectAsyncResponse TurnPDFToObjectAsyncSync(TurnPDFToObjectAsyncRequest req)
        {
            return InternalRequestAsync<TurnPDFToObjectAsyncResponse>(req, "TurnPDFToObjectAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 体检报告PDF文件结构化异步获取结果接口
        /// </summary>
        /// <param name="req"><see cref="TurnPDFToObjectAsyncGetResultRequest"/></param>
        /// <returns><see cref="TurnPDFToObjectAsyncGetResultResponse"/></returns>
        public Task<TurnPDFToObjectAsyncGetResultResponse> TurnPDFToObjectAsyncGetResult(TurnPDFToObjectAsyncGetResultRequest req)
        {
            return InternalRequestAsync<TurnPDFToObjectAsyncGetResultResponse>(req, "TurnPDFToObjectAsyncGetResult");
        }

        /// <summary>
        /// 体检报告PDF文件结构化异步获取结果接口
        /// </summary>
        /// <param name="req"><see cref="TurnPDFToObjectAsyncGetResultRequest"/></param>
        /// <returns><see cref="TurnPDFToObjectAsyncGetResultResponse"/></returns>
        public TurnPDFToObjectAsyncGetResultResponse TurnPDFToObjectAsyncGetResultSync(TurnPDFToObjectAsyncGetResultRequest req)
        {
            return InternalRequestAsync<TurnPDFToObjectAsyncGetResultResponse>(req, "TurnPDFToObjectAsyncGetResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
