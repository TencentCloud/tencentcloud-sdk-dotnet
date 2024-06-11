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

namespace TencentCloud.Ft.V20200304
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ft.V20200304.Models;

   public class FtClient : AbstractClient{

       private const string endpoint = "ft.tencentcloudapi.com";
       private const string version = "2020-03-04";
       private const string sdkVersion = "SDK_NET_3.0.1024";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FtClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public FtClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 撤销人像渐变任务请求
        /// </summary>
        /// <param name="req"><see cref="CancelFaceMorphJobRequest"/></param>
        /// <returns><see cref="CancelFaceMorphJobResponse"/></returns>
        public Task<CancelFaceMorphJobResponse> CancelFaceMorphJob(CancelFaceMorphJobRequest req)
        {
            return InternalRequestAsync<CancelFaceMorphJobResponse>(req, "CancelFaceMorphJob");
        }

        /// <summary>
        /// 撤销人像渐变任务请求
        /// </summary>
        /// <param name="req"><see cref="CancelFaceMorphJobRequest"/></param>
        /// <returns><see cref="CancelFaceMorphJobResponse"/></returns>
        public CancelFaceMorphJobResponse CancelFaceMorphJobSync(CancelFaceMorphJobRequest req)
        {
            return InternalRequestAsync<CancelFaceMorphJobResponse>(req, "CancelFaceMorphJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户上传一张人脸图片，基于人脸编辑与生成算法，输出一张人脸变老或变年轻的图片，支持实现人脸不同年龄的变化。
        /// </summary>
        /// <param name="req"><see cref="ChangeAgePicRequest"/></param>
        /// <returns><see cref="ChangeAgePicResponse"/></returns>
        public Task<ChangeAgePicResponse> ChangeAgePic(ChangeAgePicRequest req)
        {
            return InternalRequestAsync<ChangeAgePicResponse>(req, "ChangeAgePic");
        }

        /// <summary>
        /// 用户上传一张人脸图片，基于人脸编辑与生成算法，输出一张人脸变老或变年轻的图片，支持实现人脸不同年龄的变化。
        /// </summary>
        /// <param name="req"><see cref="ChangeAgePicRequest"/></param>
        /// <returns><see cref="ChangeAgePicResponse"/></returns>
        public ChangeAgePicResponse ChangeAgePicSync(ChangeAgePicRequest req)
        {
            return InternalRequestAsync<ChangeAgePicResponse>(req, "ChangeAgePic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 输入一张人脸照片，生成个性化的二次元动漫形象，可用于打造个性头像、趣味活动、特效类应用等场景，提升社交娱乐的体验。
        /// </summary>
        /// <param name="req"><see cref="FaceCartoonPicRequest"/></param>
        /// <returns><see cref="FaceCartoonPicResponse"/></returns>
        public Task<FaceCartoonPicResponse> FaceCartoonPic(FaceCartoonPicRequest req)
        {
            return InternalRequestAsync<FaceCartoonPicResponse>(req, "FaceCartoonPic");
        }

        /// <summary>
        /// 输入一张人脸照片，生成个性化的二次元动漫形象，可用于打造个性头像、趣味活动、特效类应用等场景，提升社交娱乐的体验。
        /// </summary>
        /// <param name="req"><see cref="FaceCartoonPicRequest"/></param>
        /// <returns><see cref="FaceCartoonPicResponse"/></returns>
        public FaceCartoonPicResponse FaceCartoonPicSync(FaceCartoonPicRequest req)
        {
            return InternalRequestAsync<FaceCartoonPicResponse>(req, "FaceCartoonPic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 输入2-5张人脸照片，生成一段以人脸为焦点的渐变视频或GIF图，支持自定义图片播放速度、视频每秒传输帧数，可用于短视频、表情包、创意H5等应用场景，丰富静态图片的玩法。
        /// </summary>
        /// <param name="req"><see cref="MorphFaceRequest"/></param>
        /// <returns><see cref="MorphFaceResponse"/></returns>
        public Task<MorphFaceResponse> MorphFace(MorphFaceRequest req)
        {
            return InternalRequestAsync<MorphFaceResponse>(req, "MorphFace");
        }

        /// <summary>
        /// 输入2-5张人脸照片，生成一段以人脸为焦点的渐变视频或GIF图，支持自定义图片播放速度、视频每秒传输帧数，可用于短视频、表情包、创意H5等应用场景，丰富静态图片的玩法。
        /// </summary>
        /// <param name="req"><see cref="MorphFaceRequest"/></param>
        /// <returns><see cref="MorphFaceResponse"/></returns>
        public MorphFaceResponse MorphFaceSync(MorphFaceRequest req)
        {
            return InternalRequestAsync<MorphFaceResponse>(req, "MorphFace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询人像渐变处理进度
        /// </summary>
        /// <param name="req"><see cref="QueryFaceMorphJobRequest"/></param>
        /// <returns><see cref="QueryFaceMorphJobResponse"/></returns>
        public Task<QueryFaceMorphJobResponse> QueryFaceMorphJob(QueryFaceMorphJobRequest req)
        {
            return InternalRequestAsync<QueryFaceMorphJobResponse>(req, "QueryFaceMorphJob");
        }

        /// <summary>
        /// 查询人像渐变处理进度
        /// </summary>
        /// <param name="req"><see cref="QueryFaceMorphJobRequest"/></param>
        /// <returns><see cref="QueryFaceMorphJobResponse"/></returns>
        public QueryFaceMorphJobResponse QueryFaceMorphJobSync(QueryFaceMorphJobRequest req)
        {
            return InternalRequestAsync<QueryFaceMorphJobResponse>(req, "QueryFaceMorphJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户上传一张人脸图片，基于人脸编辑与生成算法，输出一张人脸性别转换的图片。男变女可实现美颜、淡妆、加刘海和长发的效果；女变男可实现加胡须、变短发的效果。 
        /// </summary>
        /// <param name="req"><see cref="SwapGenderPicRequest"/></param>
        /// <returns><see cref="SwapGenderPicResponse"/></returns>
        public Task<SwapGenderPicResponse> SwapGenderPic(SwapGenderPicRequest req)
        {
            return InternalRequestAsync<SwapGenderPicResponse>(req, "SwapGenderPic");
        }

        /// <summary>
        /// 用户上传一张人脸图片，基于人脸编辑与生成算法，输出一张人脸性别转换的图片。男变女可实现美颜、淡妆、加刘海和长发的效果；女变男可实现加胡须、变短发的效果。 
        /// </summary>
        /// <param name="req"><see cref="SwapGenderPicRequest"/></param>
        /// <returns><see cref="SwapGenderPicResponse"/></returns>
        public SwapGenderPicResponse SwapGenderPicSync(SwapGenderPicRequest req)
        {
            return InternalRequestAsync<SwapGenderPicResponse>(req, "SwapGenderPic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
