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

namespace TencentCloud.Vod.V20180717
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vod.V20180717.Models;

   public class VodClient : AbstractClient{

       private const string endpoint = "vod.tencentcloudapi.com";
       private const string version = "2018-07-17";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public VodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public VodClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// * 该接口用于申请媒体文件（和封面文件）的上传，获取文件上传到腾讯云点播的元信息（包括上传路径、上传签名等），用于后续上传接口。
        /// * 上传流程请参考[服务端上传综述](https://cloud.tencent.com/document/product/266/9759#.E4.B8.8A.E4.BC.A0.E6.B5.81.E7.A8.8B)。
        /// </summary>
        /// <param name="req">参考<see cref="ApplyUploadRequest"/></param>
        /// <returns>参考<see cref="ApplyUploadResponse"/>实例</returns>
        public async Task<ApplyUploadResponse> ApplyUpload(ApplyUploadRequest req)
        {
             JsonResponseModel<ApplyUploadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于确认媒体文件（和封面文件）上传到腾讯云点播的结果，并存储媒体信息，返回文件的播放地址和文件 ID。
        /// </summary>
        /// <param name="req">参考<see cref="CommitUploadRequest"/></param>
        /// <returns>参考<see cref="CommitUploadResponse"/>实例</returns>
        public async Task<CommitUploadResponse> CommitUpload(CommitUploadRequest req)
        {
             JsonResponseModel<CommitUploadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CommitUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 用于对媒体进行分类管理；
        /// * 该接口不影响既有媒体的分类，如需修改媒体分类，请调用[修改媒体文件属性](http://139.199.214.26/document/product/266/18104?!preview&preview_docmenu=1&lang=cn&!document=1)接口。
        /// * 分类层次不可超过 4 层。
        /// * 每个分类的子类数量不可超过 500 个。
        /// </summary>
        /// <param name="req">参考<see cref="CreateClassRequest"/></param>
        /// <returns>参考<see cref="CreateClassResponse"/>实例</returns>
        public async Task<CreateClassResponse> CreateClass(CreateClassRequest req)
        {
             JsonResponseModel<CreateClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 仅当待删分类无子分类且无媒体关联情况下，可删除分类；
        /// * 否则，请先执行[删除媒体](http://139.199.214.26/document/product/266/18115?!preview&preview_docmenu=1&lang=cn&!document=1)及子分类，再删除该分类；
        /// </summary>
        /// <param name="req">参考<see cref="DeleteClassRequest"/></param>
        /// <returns>参考<see cref="DeleteClassResponse"/>实例</returns>
        public async Task<DeleteClassResponse> DeleteClass(DeleteClassRequest req)
        {
             JsonResponseModel<DeleteClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 删除媒体及其对应的视频处理文件（如转码视频、雪碧图、截图、微信发布视频等）；
        /// * 可单独删除指定 ID 的视频文件下的转码，或者微信发布文件；
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMediaRequest"/></param>
        /// <returns>参考<see cref="DeleteMediaResponse"/>实例</returns>
        public async Task<DeleteMediaResponse> DeleteMedia(DeleteMediaRequest req)
        {
             JsonResponseModel<DeleteMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 获得用户的所有分类信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAllClassRequest"/></param>
        /// <returns>参考<see cref="DescribeAllClassResponse"/>实例</returns>
        public async Task<DescribeAllClassResponse> DescribeAllClass(DescribeAllClassRequest req)
        {
             JsonResponseModel<DescribeAllClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口可以获取多个视频的多种信息，包括：
        ///     1. 基础信息（basicInfo）：包括视频名称、大小、时长、封面图片等。
        ///     2. 元信息（metaData）：包括视频流信息、音频流信息等。
        ///     3. 转码结果信息（transcodeInfo）：包括该视频转码生成的各种码率的视频的地址、规格、码率、分辨率等。
        ///     4. 转动图结果信息（animatedGraphicsInfo）：对视频转动图（如 gif）后，动图相关信息。
        ///     5. 采样截图信息（sampleSnapshotInfo）：对视频采样截图后，相关截图信息。
        ///     6. 雪碧图信息（imageSpriteInfo）：对视频截取雪碧图之后，雪碧图的相关信息。
        ///     7. 指定时间点截图信息（snapshotByTimeOffsetInfo）：对视频依照指定时间点截图后，各个截图的信息。
        ///     8. 视频打点信息（keyFrameDescInfo）：对视频设置的各个打点信息。
        /// 2. 可以指定回包只返回部分信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMediaInfosRequest"/></param>
        /// <returns>参考<see cref="DescribeMediaInfosResponse"/>实例</returns>
        public async Task<DescribeMediaInfosResponse> DescribeMediaInfos(DescribeMediaInfosRequest req)
        {
             JsonResponseModel<DescribeMediaInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改媒体分类属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyClassRequest"/></param>
        /// <returns>参考<see cref="ModifyClassResponse"/>实例</returns>
        public async Task<ModifyClassResponse> ModifyClass(ModifyClassRequest req)
        {
             JsonResponseModel<ModifyClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改媒体文件的属性，包括分类、名称、描述、标签、过期时间、打点信息、视频封面等。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyMediaInfoRequest"/></param>
        /// <returns>参考<see cref="ModifyMediaInfoResponse"/>实例</returns>
        public async Task<ModifyMediaInfoResponse> ModifyMediaInfo(ModifyMediaInfoRequest req)
        {
             JsonResponseModel<ModifyMediaInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
