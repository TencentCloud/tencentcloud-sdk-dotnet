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
       private const string sdkVersion = "SDK_NET_3.0.1197";

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
        /// 上传正面全身模特照和服装平铺图，生成模特换装后的图片。
        /// 生成的换装图片分辨率和模特照分辨率一致。
        /// 模特换装默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="ChangeClothesRequest"/></param>
        /// <returns><see cref="ChangeClothesResponse"/></returns>
        public Task<ChangeClothesResponse> ChangeClothes(ChangeClothesRequest req)
        {
            return InternalRequestAsync<ChangeClothesResponse>(req, "ChangeClothes");
        }

        /// <summary>
        /// 上传正面全身模特照和服装平铺图，生成模特换装后的图片。
        /// 生成的换装图片分辨率和模特照分辨率一致。
        /// 模特换装默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="ChangeClothesRequest"/></param>
        /// <returns><see cref="ChangeClothesResponse"/></returns>
        public ChangeClothesResponse ChangeClothesSync(ChangeClothesRequest req)
        {
            return InternalRequestAsync<ChangeClothesResponse>(req, "ChangeClothes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 百变头像接口将根据输入的人像照片，生成风格百变的头像。
        /// 百变头像默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="GenerateAvatarRequest"/></param>
        /// <returns><see cref="GenerateAvatarResponse"/></returns>
        public Task<GenerateAvatarResponse> GenerateAvatar(GenerateAvatarRequest req)
        {
            return InternalRequestAsync<GenerateAvatarResponse>(req, "GenerateAvatar");
        }

        /// <summary>
        /// 百变头像接口将根据输入的人像照片，生成风格百变的头像。
        /// 百变头像默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="GenerateAvatarRequest"/></param>
        /// <returns><see cref="GenerateAvatarResponse"/></returns>
        public GenerateAvatarResponse GenerateAvatarSync(GenerateAvatarRequest req)
        {
            return InternalRequestAsync<GenerateAvatarResponse>(req, "GenerateAvatar")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 局部消除接口通过图像 mask 指定需要消除的人、物、文字等区域，在选定区域对图像内容进行消除与重绘补全。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务。
        /// </summary>
        /// <param name="req"><see cref="ImageInpaintingRemovalRequest"/></param>
        /// <returns><see cref="ImageInpaintingRemovalResponse"/></returns>
        public Task<ImageInpaintingRemovalResponse> ImageInpaintingRemoval(ImageInpaintingRemovalRequest req)
        {
            return InternalRequestAsync<ImageInpaintingRemovalResponse>(req, "ImageInpaintingRemoval");
        }

        /// <summary>
        /// 局部消除接口通过图像 mask 指定需要消除的人、物、文字等区域，在选定区域对图像内容进行消除与重绘补全。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务。
        /// </summary>
        /// <param name="req"><see cref="ImageInpaintingRemovalRequest"/></param>
        /// <returns><see cref="ImageInpaintingRemovalResponse"/></returns>
        public ImageInpaintingRemovalResponse ImageInpaintingRemovalSync(ImageInpaintingRemovalRequest req)
        {
            return InternalRequestAsync<ImageInpaintingRemovalResponse>(req, "ImageInpaintingRemoval")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 扩图接口支持对输入图像按指定宽高比实现智能扩图。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务。
        /// </summary>
        /// <param name="req"><see cref="ImageOutpaintingRequest"/></param>
        /// <returns><see cref="ImageOutpaintingResponse"/></returns>
        public Task<ImageOutpaintingResponse> ImageOutpainting(ImageOutpaintingRequest req)
        {
            return InternalRequestAsync<ImageOutpaintingResponse>(req, "ImageOutpainting");
        }

        /// <summary>
        /// 扩图接口支持对输入图像按指定宽高比实现智能扩图。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务。
        /// </summary>
        /// <param name="req"><see cref="ImageOutpaintingRequest"/></param>
        /// <returns><see cref="ImageOutpaintingResponse"/></returns>
        public ImageOutpaintingResponse ImageOutpaintingSync(ImageOutpaintingRequest req)
        {
            return InternalRequestAsync<ImageOutpaintingResponse>(req, "ImageOutpainting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 图像风格化（图生图）接口提供生成式的图生图风格转化能力，将根据输入的图像及文本描述，智能生成风格转化后的图像。建议避免输入人像过小、姿势复杂、人数较多的人像图片。
        /// 图像风格化（图生图）默认提供3个并发任务数，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="ImageToImageRequest"/></param>
        /// <returns><see cref="ImageToImageResponse"/></returns>
        public Task<ImageToImageResponse> ImageToImage(ImageToImageRequest req)
        {
            return InternalRequestAsync<ImageToImageResponse>(req, "ImageToImage");
        }

        /// <summary>
        /// 图像风格化（图生图）接口提供生成式的图生图风格转化能力，将根据输入的图像及文本描述，智能生成风格转化后的图像。建议避免输入人像过小、姿势复杂、人数较多的人像图片。
        /// 图像风格化（图生图）默认提供3个并发任务数，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="ImageToImageRequest"/></param>
        /// <returns><see cref="ImageToImageResponse"/></returns>
        public ImageToImageResponse ImageToImageSync(ImageToImageRequest req)
        {
            return InternalRequestAsync<ImageToImageResponse>(req, "ImageToImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// AI 写真分为上传训练图片、训练写真模型（可选跳过）、生成写真图片3个环节，需要依次调用对应接口。
        /// 生成图片分为提交任务和查询任务2个接口：
        /// 
        /// - 提交生成写真图片任务：选择风格模板，提交一个生成写真图片异步任务，根据写真模型 ID 生成写真图片，获得任务 ID。
        /// - 查询生成写真图片任务：根据任务 ID 查询生成图片任务的处理状态、处理结果。
        /// 
        /// 每个写真模型自训练完成起1年内有效，有效期内可使用写真模型 ID 生成图片，期满后需要重新训练。
        /// </summary>
        /// <param name="req"><see cref="QueryDrawPortraitJobRequest"/></param>
        /// <returns><see cref="QueryDrawPortraitJobResponse"/></returns>
        public Task<QueryDrawPortraitJobResponse> QueryDrawPortraitJob(QueryDrawPortraitJobRequest req)
        {
            return InternalRequestAsync<QueryDrawPortraitJobResponse>(req, "QueryDrawPortraitJob");
        }

        /// <summary>
        /// AI 写真分为上传训练图片、训练写真模型（可选跳过）、生成写真图片3个环节，需要依次调用对应接口。
        /// 生成图片分为提交任务和查询任务2个接口：
        /// 
        /// - 提交生成写真图片任务：选择风格模板，提交一个生成写真图片异步任务，根据写真模型 ID 生成写真图片，获得任务 ID。
        /// - 查询生成写真图片任务：根据任务 ID 查询生成图片任务的处理状态、处理结果。
        /// 
        /// 每个写真模型自训练完成起1年内有效，有效期内可使用写真模型 ID 生成图片，期满后需要重新训练。
        /// </summary>
        /// <param name="req"><see cref="QueryDrawPortraitJobRequest"/></param>
        /// <returns><see cref="QueryDrawPortraitJobResponse"/></returns>
        public QueryDrawPortraitJobResponse QueryDrawPortraitJobSync(QueryDrawPortraitJobRequest req)
        {
            return InternalRequestAsync<QueryDrawPortraitJobResponse>(req, "QueryDrawPortraitJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// AI 美照接口将根据模板为用户生成精美照片。分为提交任务和查询任务2个接口。
        /// - 提交任务：提交一个美照生成异步任务，获得任务 ID。
        /// - 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 
        /// AI 美照默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryGlamPicJobRequest"/></param>
        /// <returns><see cref="QueryGlamPicJobResponse"/></returns>
        public Task<QueryGlamPicJobResponse> QueryGlamPicJob(QueryGlamPicJobRequest req)
        {
            return InternalRequestAsync<QueryGlamPicJobResponse>(req, "QueryGlamPicJob");
        }

        /// <summary>
        /// AI 美照接口将根据模板为用户生成精美照片。分为提交任务和查询任务2个接口。
        /// - 提交任务：提交一个美照生成异步任务，获得任务 ID。
        /// - 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 
        /// AI 美照默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryGlamPicJobRequest"/></param>
        /// <returns><see cref="QueryGlamPicJobResponse"/></returns>
        public QueryGlamPicJobResponse QueryGlamPicJobSync(QueryGlamPicJobRequest req)
        {
            return InternalRequestAsync<QueryGlamPicJobResponse>(req, "QueryGlamPicJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 表情动图生成接口将静态照片制作成动态的表情包。分为提交任务和查询任务2个接口。
        /// - 提交任务：提交一个表情动图生成异步任务，获得任务 ID。
        /// - 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 
        /// 表情动图生成默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryMemeJobRequest"/></param>
        /// <returns><see cref="QueryMemeJobResponse"/></returns>
        public Task<QueryMemeJobResponse> QueryMemeJob(QueryMemeJobRequest req)
        {
            return InternalRequestAsync<QueryMemeJobResponse>(req, "QueryMemeJob");
        }

        /// <summary>
        /// 表情动图生成接口将静态照片制作成动态的表情包。分为提交任务和查询任务2个接口。
        /// - 提交任务：提交一个表情动图生成异步任务，获得任务 ID。
        /// - 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 
        /// 表情动图生成默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryMemeJobRequest"/></param>
        /// <returns><see cref="QueryMemeJobResponse"/></returns>
        public QueryMemeJobResponse QueryMemeJobSync(QueryMemeJobRequest req)
        {
            return InternalRequestAsync<QueryMemeJobResponse>(req, "QueryMemeJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口已迁移至腾讯混元大模型-混元生图，即将停止此处维护，可切换至 [混元生图 API](https://cloud.tencent.com/document/product/1729/105970) 继续使用。
        /// 文生图（高级版）接口基于高级版文生图大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个文生图（高级版）异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。文生图（高级版）默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryTextToImageProJobRequest"/></param>
        /// <returns><see cref="QueryTextToImageProJobResponse"/></returns>
        public Task<QueryTextToImageProJobResponse> QueryTextToImageProJob(QueryTextToImageProJobRequest req)
        {
            return InternalRequestAsync<QueryTextToImageProJobResponse>(req, "QueryTextToImageProJob");
        }

        /// <summary>
        /// 本接口已迁移至腾讯混元大模型-混元生图，即将停止此处维护，可切换至 [混元生图 API](https://cloud.tencent.com/document/product/1729/105970) 继续使用。
        /// 文生图（高级版）接口基于高级版文生图大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个文生图（高级版）异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。文生图（高级版）默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryTextToImageProJobRequest"/></param>
        /// <returns><see cref="QueryTextToImageProJobResponse"/></returns>
        public QueryTextToImageProJobResponse QueryTextToImageProJobSync(QueryTextToImageProJobRequest req)
        {
            return InternalRequestAsync<QueryTextToImageProJobResponse>(req, "QueryTextToImageProJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// AI 写真分为上传训练图片、训练写真模型（可选跳过）、生成写真图片3个环节，需要依次调用对应接口。
        /// 如果选择免训练模式无需调用本接口。
        /// 训练模型分为提交任务和查询任务2个接口：
        /// 
        /// - 提交训练写真模型任务：完成上传图片后，提交一个训练写真模型异步任务，根据写真模型 ID 开始训练模型。
        /// - 查询训练写真模型任务：根据写真模型 ID 查询训练任务的处理状态、处理结果。
        /// 
        /// 每个写真模型自训练完成起1年内有效，有效期内可使用写真模型 ID 生成图片，期满后需要重新训练。
        /// </summary>
        /// <param name="req"><see cref="QueryTrainPortraitModelJobRequest"/></param>
        /// <returns><see cref="QueryTrainPortraitModelJobResponse"/></returns>
        public Task<QueryTrainPortraitModelJobResponse> QueryTrainPortraitModelJob(QueryTrainPortraitModelJobRequest req)
        {
            return InternalRequestAsync<QueryTrainPortraitModelJobResponse>(req, "QueryTrainPortraitModelJob");
        }

        /// <summary>
        /// AI 写真分为上传训练图片、训练写真模型（可选跳过）、生成写真图片3个环节，需要依次调用对应接口。
        /// 如果选择免训练模式无需调用本接口。
        /// 训练模型分为提交任务和查询任务2个接口：
        /// 
        /// - 提交训练写真模型任务：完成上传图片后，提交一个训练写真模型异步任务，根据写真模型 ID 开始训练模型。
        /// - 查询训练写真模型任务：根据写真模型 ID 查询训练任务的处理状态、处理结果。
        /// 
        /// 每个写真模型自训练完成起1年内有效，有效期内可使用写真模型 ID 生成图片，期满后需要重新训练。
        /// </summary>
        /// <param name="req"><see cref="QueryTrainPortraitModelJobRequest"/></param>
        /// <returns><see cref="QueryTrainPortraitModelJobResponse"/></returns>
        public QueryTrainPortraitModelJobResponse QueryTrainPortraitModelJobSync(QueryTrainPortraitModelJobRequest req)
        {
            return InternalRequestAsync<QueryTrainPortraitModelJobResponse>(req, "QueryTrainPortraitModelJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将图像变清晰，增强图像细节。变清晰后的图片将保持原图比例，长边为2048。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务。
        /// </summary>
        /// <param name="req"><see cref="RefineImageRequest"/></param>
        /// <returns><see cref="RefineImageResponse"/></returns>
        public Task<RefineImageResponse> RefineImage(RefineImageRequest req)
        {
            return InternalRequestAsync<RefineImageResponse>(req, "RefineImage");
        }

        /// <summary>
        /// 将图像变清晰，增强图像细节。变清晰后的图片将保持原图比例，长边为2048。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务。
        /// </summary>
        /// <param name="req"><see cref="RefineImageRequest"/></param>
        /// <returns><see cref="RefineImageResponse"/></returns>
        public RefineImageResponse RefineImageSync(RefineImageRequest req)
        {
            return InternalRequestAsync<RefineImageResponse>(req, "RefineImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 商品背景生成接口根据指定的背景描述 Prompt，将商品图中的原背景替换为自定义的新背景并保留商品主体形象，实现商品背景的自由生成与更换。
        /// 
        /// 商品背景生成默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="ReplaceBackgroundRequest"/></param>
        /// <returns><see cref="ReplaceBackgroundResponse"/></returns>
        public Task<ReplaceBackgroundResponse> ReplaceBackground(ReplaceBackgroundRequest req)
        {
            return InternalRequestAsync<ReplaceBackgroundResponse>(req, "ReplaceBackground");
        }

        /// <summary>
        /// 商品背景生成接口根据指定的背景描述 Prompt，将商品图中的原背景替换为自定义的新背景并保留商品主体形象，实现商品背景的自由生成与更换。
        /// 
        /// 商品背景生成默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="ReplaceBackgroundRequest"/></param>
        /// <returns><see cref="ReplaceBackgroundResponse"/></returns>
        public ReplaceBackgroundResponse ReplaceBackgroundSync(ReplaceBackgroundRequest req)
        {
            return InternalRequestAsync<ReplaceBackgroundResponse>(req, "ReplaceBackground")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 线稿生图接口支持上传一张黑白线稿图，按照指定的主体对象以及样式、颜色、材质、风格等的文本描述prompt ，对线稿图进行色彩填充与细节描绘，得到一张完整绘制的图像。生成图分辨率默认为1024:1024。
        /// 线稿生图默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SketchToImageRequest"/></param>
        /// <returns><see cref="SketchToImageResponse"/></returns>
        public Task<SketchToImageResponse> SketchToImage(SketchToImageRequest req)
        {
            return InternalRequestAsync<SketchToImageResponse>(req, "SketchToImage");
        }

        /// <summary>
        /// 线稿生图接口支持上传一张黑白线稿图，按照指定的主体对象以及样式、颜色、材质、风格等的文本描述prompt ，对线稿图进行色彩填充与细节描绘，得到一张完整绘制的图像。生成图分辨率默认为1024:1024。
        /// 线稿生图默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SketchToImageRequest"/></param>
        /// <returns><see cref="SketchToImageResponse"/></returns>
        public SketchToImageResponse SketchToImageSync(SketchToImageRequest req)
        {
            return InternalRequestAsync<SketchToImageResponse>(req, "SketchToImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// AI 写真分为上传训练图片、训练写真模型（可选跳过）、生成写真图片3个环节，需要依次调用对应接口。
        /// 生成图片分为提交任务和查询任务2个接口：
        /// 
        /// - 提交生成写真图片任务：选择风格模板，提交一个生成写真图片异步任务，根据写真模型 ID 生成写真图片，获得任务 ID。
        /// - 查询生成写真图片任务：根据任务 ID 查询生成图片任务的处理状态、处理结果。
        /// 
        /// 每个写真模型自训练完成起1年内有效，有效期内可使用写真模型 ID 生成图片，期满后需要重新训练。
        /// 提交生成写真图片任务默认提供1个并发。
        /// </summary>
        /// <param name="req"><see cref="SubmitDrawPortraitJobRequest"/></param>
        /// <returns><see cref="SubmitDrawPortraitJobResponse"/></returns>
        public Task<SubmitDrawPortraitJobResponse> SubmitDrawPortraitJob(SubmitDrawPortraitJobRequest req)
        {
            return InternalRequestAsync<SubmitDrawPortraitJobResponse>(req, "SubmitDrawPortraitJob");
        }

        /// <summary>
        /// AI 写真分为上传训练图片、训练写真模型（可选跳过）、生成写真图片3个环节，需要依次调用对应接口。
        /// 生成图片分为提交任务和查询任务2个接口：
        /// 
        /// - 提交生成写真图片任务：选择风格模板，提交一个生成写真图片异步任务，根据写真模型 ID 生成写真图片，获得任务 ID。
        /// - 查询生成写真图片任务：根据任务 ID 查询生成图片任务的处理状态、处理结果。
        /// 
        /// 每个写真模型自训练完成起1年内有效，有效期内可使用写真模型 ID 生成图片，期满后需要重新训练。
        /// 提交生成写真图片任务默认提供1个并发。
        /// </summary>
        /// <param name="req"><see cref="SubmitDrawPortraitJobRequest"/></param>
        /// <returns><see cref="SubmitDrawPortraitJobResponse"/></returns>
        public SubmitDrawPortraitJobResponse SubmitDrawPortraitJobSync(SubmitDrawPortraitJobRequest req)
        {
            return InternalRequestAsync<SubmitDrawPortraitJobResponse>(req, "SubmitDrawPortraitJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// AI 美照接口将根据模板为用户生成精美照片。分为提交任务和查询任务2个接口。
        /// - 提交任务：提交一个美照生成异步任务，获得任务 ID。
        /// - 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 
        /// AI 美照默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitGlamPicJobRequest"/></param>
        /// <returns><see cref="SubmitGlamPicJobResponse"/></returns>
        public Task<SubmitGlamPicJobResponse> SubmitGlamPicJob(SubmitGlamPicJobRequest req)
        {
            return InternalRequestAsync<SubmitGlamPicJobResponse>(req, "SubmitGlamPicJob");
        }

        /// <summary>
        /// AI 美照接口将根据模板为用户生成精美照片。分为提交任务和查询任务2个接口。
        /// - 提交任务：提交一个美照生成异步任务，获得任务 ID。
        /// - 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 
        /// AI 美照默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitGlamPicJobRequest"/></param>
        /// <returns><see cref="SubmitGlamPicJobResponse"/></returns>
        public SubmitGlamPicJobResponse SubmitGlamPicJobSync(SubmitGlamPicJobRequest req)
        {
            return InternalRequestAsync<SubmitGlamPicJobResponse>(req, "SubmitGlamPicJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 表情动图生成接口将静态照片制作成动态的表情包。分为提交任务和查询任务2个接口。
        /// 
        /// - 提交任务：提交一个表情动图生成异步任务，获得任务 ID。
        /// - 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 
        /// 表情动图生成默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitMemeJobRequest"/></param>
        /// <returns><see cref="SubmitMemeJobResponse"/></returns>
        public Task<SubmitMemeJobResponse> SubmitMemeJob(SubmitMemeJobRequest req)
        {
            return InternalRequestAsync<SubmitMemeJobResponse>(req, "SubmitMemeJob");
        }

        /// <summary>
        /// 表情动图生成接口将静态照片制作成动态的表情包。分为提交任务和查询任务2个接口。
        /// 
        /// - 提交任务：提交一个表情动图生成异步任务，获得任务 ID。
        /// - 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 
        /// 表情动图生成默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitMemeJobRequest"/></param>
        /// <returns><see cref="SubmitMemeJobResponse"/></returns>
        public SubmitMemeJobResponse SubmitMemeJobSync(SubmitMemeJobRequest req)
        {
            return InternalRequestAsync<SubmitMemeJobResponse>(req, "SubmitMemeJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口已迁移至腾讯混元大模型-混元生图，即将停止此处维护，可切换至 [混元生图 API](https://cloud.tencent.com/document/product/1729/105969) 继续使用。
        /// 文生图（高级版）接口基于高级版文生图大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个文生图（高级版）异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。文生图（高级版）默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitTextToImageProJobRequest"/></param>
        /// <returns><see cref="SubmitTextToImageProJobResponse"/></returns>
        public Task<SubmitTextToImageProJobResponse> SubmitTextToImageProJob(SubmitTextToImageProJobRequest req)
        {
            return InternalRequestAsync<SubmitTextToImageProJobResponse>(req, "SubmitTextToImageProJob");
        }

        /// <summary>
        /// 本接口已迁移至腾讯混元大模型-混元生图，即将停止此处维护，可切换至 [混元生图 API](https://cloud.tencent.com/document/product/1729/105969) 继续使用。
        /// 文生图（高级版）接口基于高级版文生图大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个文生图（高级版）异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。文生图（高级版）默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitTextToImageProJobRequest"/></param>
        /// <returns><see cref="SubmitTextToImageProJobResponse"/></returns>
        public SubmitTextToImageProJobResponse SubmitTextToImageProJobSync(SubmitTextToImageProJobRequest req)
        {
            return InternalRequestAsync<SubmitTextToImageProJobResponse>(req, "SubmitTextToImageProJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// AI 写真分为上传训练图片、训练写真模型（可选跳过）、生成写真图片3个环节，需要依次调用对应接口。
        /// 如果选择免训练模式无需调用本接口。
        /// 训练模型分为提交任务和查询任务2个接口：
        /// - 提交训练写真模型任务：完成上传图片后，提交一个训练写真模型异步任务，根据写真模型 ID 开始训练模型。
        /// - 查询训练写真模型任务：根据写真模型 ID 查询训练任务的处理状态、处理结果。
        /// 
        /// 每个写真模型自训练完成起1年内有效，有效期内可使用写真模型 ID 生成图片，期满后需要重新训练。
        /// 提交训练写真模型任务按并发计费，无默认并发额度。
        /// </summary>
        /// <param name="req"><see cref="SubmitTrainPortraitModelJobRequest"/></param>
        /// <returns><see cref="SubmitTrainPortraitModelJobResponse"/></returns>
        public Task<SubmitTrainPortraitModelJobResponse> SubmitTrainPortraitModelJob(SubmitTrainPortraitModelJobRequest req)
        {
            return InternalRequestAsync<SubmitTrainPortraitModelJobResponse>(req, "SubmitTrainPortraitModelJob");
        }

        /// <summary>
        /// AI 写真分为上传训练图片、训练写真模型（可选跳过）、生成写真图片3个环节，需要依次调用对应接口。
        /// 如果选择免训练模式无需调用本接口。
        /// 训练模型分为提交任务和查询任务2个接口：
        /// - 提交训练写真模型任务：完成上传图片后，提交一个训练写真模型异步任务，根据写真模型 ID 开始训练模型。
        /// - 查询训练写真模型任务：根据写真模型 ID 查询训练任务的处理状态、处理结果。
        /// 
        /// 每个写真模型自训练完成起1年内有效，有效期内可使用写真模型 ID 生成图片，期满后需要重新训练。
        /// 提交训练写真模型任务按并发计费，无默认并发额度。
        /// </summary>
        /// <param name="req"><see cref="SubmitTrainPortraitModelJobRequest"/></param>
        /// <returns><see cref="SubmitTrainPortraitModelJobResponse"/></returns>
        public SubmitTrainPortraitModelJobResponse SubmitTrainPortraitModelJobSync(SubmitTrainPortraitModelJobRequest req)
        {
            return InternalRequestAsync<SubmitTrainPortraitModelJobResponse>(req, "SubmitTrainPortraitModelJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **本接口已迁移至腾讯混元大模型-文生图轻量版，即将停止此处维护，可切换至 [文生图轻量版 API](https://cloud.tencent.com/document/product/1729/108738) 继续使用。**
        /// 
        /// 智能文生图接口基于文生图（标准版）模型，将根据输入的文本描述，智能生成与之相关的结果图。
        /// 
        /// 智能文生图默认提供3个并发任务数，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="TextToImageRequest"/></param>
        /// <returns><see cref="TextToImageResponse"/></returns>
        public Task<TextToImageResponse> TextToImage(TextToImageRequest req)
        {
            return InternalRequestAsync<TextToImageResponse>(req, "TextToImage");
        }

        /// <summary>
        /// **本接口已迁移至腾讯混元大模型-文生图轻量版，即将停止此处维护，可切换至 [文生图轻量版 API](https://cloud.tencent.com/document/product/1729/108738) 继续使用。**
        /// 
        /// 智能文生图接口基于文生图（标准版）模型，将根据输入的文本描述，智能生成与之相关的结果图。
        /// 
        /// 智能文生图默认提供3个并发任务数，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="TextToImageRequest"/></param>
        /// <returns><see cref="TextToImageResponse"/></returns>
        public TextToImageResponse TextToImageSync(TextToImageRequest req)
        {
            return InternalRequestAsync<TextToImageResponse>(req, "TextToImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// AI 写真分为上传训练图片、训练写真模型（可选跳过）、生成写真图片3个环节，需要依次调用对应接口。
        /// 本接口用于上传人像图片并指定对应的写真模型 ID。上传的图片要求是同一个人，建议上传单人、正脸、脸部区域占比较大、脸部清晰无遮挡、无大角度偏转、无夸张表情的图片。
        /// 可选模式：
        /// - 常规训练模式：上传20 - 25张图片用于模型训练，完成训练后可生成写真图片。
        /// - 快速训练模式：仅需上传1张图片用于模型训练，训练速度更快，完成训练后可生成写真图片。
        /// - 免训练模式：仅需上传1张图片，跳过训练环节，直接生成写真图片。
        /// 
        /// 上传写真训练图片默认提供1个并发。
        /// </summary>
        /// <param name="req"><see cref="UploadTrainPortraitImagesRequest"/></param>
        /// <returns><see cref="UploadTrainPortraitImagesResponse"/></returns>
        public Task<UploadTrainPortraitImagesResponse> UploadTrainPortraitImages(UploadTrainPortraitImagesRequest req)
        {
            return InternalRequestAsync<UploadTrainPortraitImagesResponse>(req, "UploadTrainPortraitImages");
        }

        /// <summary>
        /// AI 写真分为上传训练图片、训练写真模型（可选跳过）、生成写真图片3个环节，需要依次调用对应接口。
        /// 本接口用于上传人像图片并指定对应的写真模型 ID。上传的图片要求是同一个人，建议上传单人、正脸、脸部区域占比较大、脸部清晰无遮挡、无大角度偏转、无夸张表情的图片。
        /// 可选模式：
        /// - 常规训练模式：上传20 - 25张图片用于模型训练，完成训练后可生成写真图片。
        /// - 快速训练模式：仅需上传1张图片用于模型训练，训练速度更快，完成训练后可生成写真图片。
        /// - 免训练模式：仅需上传1张图片，跳过训练环节，直接生成写真图片。
        /// 
        /// 上传写真训练图片默认提供1个并发。
        /// </summary>
        /// <param name="req"><see cref="UploadTrainPortraitImagesRequest"/></param>
        /// <returns><see cref="UploadTrainPortraitImagesResponse"/></returns>
        public UploadTrainPortraitImagesResponse UploadTrainPortraitImagesSync(UploadTrainPortraitImagesRequest req)
        {
            return InternalRequestAsync<UploadTrainPortraitImagesResponse>(req, "UploadTrainPortraitImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
