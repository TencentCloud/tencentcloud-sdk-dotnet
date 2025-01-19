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

namespace TencentCloud.Bda.V20200324
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bda.V20200324.Models;

   public class BdaClient : AbstractClient{

       private const string endpoint = "bda.tencentcloudapi.com";
       private const string version = "2020-03-24";
       private const string sdkVersion = "SDK_NET_3.0.1167";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BdaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BdaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 用于创建一个空的人体库，如果人体库已存在返回错误。
        /// 
        /// 1个APPID下最多有2000W个人体动作轨迹（Trace），最多1W个人体库（Group）。
        /// 
        /// 单个人体库（Group）最多10W个人体动作轨迹（Trace）。
        /// 
        /// 单个人员（Person）最多添加 5 个人体动作轨迹（Trace）。
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupResponse>(req, "CreateGroup");
        }

        /// <summary>
        /// 用于创建一个空的人体库，如果人体库已存在返回错误。
        /// 
        /// 1个APPID下最多有2000W个人体动作轨迹（Trace），最多1W个人体库（Group）。
        /// 
        /// 单个人体库（Group）最多10W个人体动作轨迹（Trace）。
        /// 
        /// 单个人员（Person）最多添加 5 个人体动作轨迹（Trace）。
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public CreateGroupResponse CreateGroupSync(CreateGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupResponse>(req, "CreateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建人员，添加对应人员的人体动作轨迹信息。
        /// 
        /// 请注意：
        /// - 我们希望您的输入为 严格符合动作轨迹图片 要求的图片。如果您输入的图片不符合动作轨迹图片要求，会对最终效果产生较大负面影响。请您尽量保证一个Trace中的图片人体清晰、无遮挡、连贯；
        /// - 一个人体动作轨迹（Trace）可以包含1-5张人体图片。提供越多质量高的人体图片有助于提升最终识别结果；
        /// - 无论您在单个Trace中提供了多少张人体图片，我们都将生成一个对应的动作轨迹（Trace）信息。即，Trace仅和本次输入的图片序列相关，和图片的个数无关；
        /// - 输入的图片组中，若有部分图片输入不合法（如图片大小过大、分辨率过大、无法解码等），我们将舍弃这部分图片，确保合法图片被正确搜索。即，我们将尽可能保证请求成功，去除不合法的输入；
        /// - 构成人体动作轨迹单张图片大小不得超过2M，分辨率不得超过1920*1080。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonRequest"/></param>
        /// <returns><see cref="CreatePersonResponse"/></returns>
        public Task<CreatePersonResponse> CreatePerson(CreatePersonRequest req)
        {
            return InternalRequestAsync<CreatePersonResponse>(req, "CreatePerson");
        }

        /// <summary>
        /// 创建人员，添加对应人员的人体动作轨迹信息。
        /// 
        /// 请注意：
        /// - 我们希望您的输入为 严格符合动作轨迹图片 要求的图片。如果您输入的图片不符合动作轨迹图片要求，会对最终效果产生较大负面影响。请您尽量保证一个Trace中的图片人体清晰、无遮挡、连贯；
        /// - 一个人体动作轨迹（Trace）可以包含1-5张人体图片。提供越多质量高的人体图片有助于提升最终识别结果；
        /// - 无论您在单个Trace中提供了多少张人体图片，我们都将生成一个对应的动作轨迹（Trace）信息。即，Trace仅和本次输入的图片序列相关，和图片的个数无关；
        /// - 输入的图片组中，若有部分图片输入不合法（如图片大小过大、分辨率过大、无法解码等），我们将舍弃这部分图片，确保合法图片被正确搜索。即，我们将尽可能保证请求成功，去除不合法的输入；
        /// - 构成人体动作轨迹单张图片大小不得超过2M，分辨率不得超过1920*1080。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonRequest"/></param>
        /// <returns><see cref="CreatePersonResponse"/></returns>
        public CreatePersonResponse CreatePersonSync(CreatePersonRequest req)
        {
            return InternalRequestAsync<CreatePersonResponse>(req, "CreatePerson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为人像分割在线处理接口组中的提交任务接口，可以对提交的资源进行处理视频流/图片流识别视频作品中的人像区域，进行一键抠像、背景替换、人像虚化等后期处理。
        /// </summary>
        /// <param name="req"><see cref="CreateSegmentationTaskRequest"/></param>
        /// <returns><see cref="CreateSegmentationTaskResponse"/></returns>
        public Task<CreateSegmentationTaskResponse> CreateSegmentationTask(CreateSegmentationTaskRequest req)
        {
            return InternalRequestAsync<CreateSegmentationTaskResponse>(req, "CreateSegmentationTask");
        }

        /// <summary>
        /// 本接口为人像分割在线处理接口组中的提交任务接口，可以对提交的资源进行处理视频流/图片流识别视频作品中的人像区域，进行一键抠像、背景替换、人像虚化等后期处理。
        /// </summary>
        /// <param name="req"><see cref="CreateSegmentationTaskRequest"/></param>
        /// <returns><see cref="CreateSegmentationTaskResponse"/></returns>
        public CreateSegmentationTaskResponse CreateSegmentationTaskSync(CreateSegmentationTaskRequest req)
        {
            return InternalRequestAsync<CreateSegmentationTaskResponse>(req, "CreateSegmentationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将一个人体动作轨迹添加到一个人员中。一个人员最多允许包含 5 个人体动作轨迹。同一人的人体动作轨迹越多，搜索识别效果越好。
        /// 
        /// >请注意：
        /// - 我们希望您的输入为 严格符合动作轨迹图片 要求的图片。如果您输入的图片不符合动作轨迹图片要求，会对最终效果产生较大负面影响。请您尽量保证一个Trace中的图片人体清晰、无遮挡、连贯。
        /// - 一个人体动作轨迹（Trace）可以包含1-5张人体图片。提供越多质量高的人体图片有助于提升最终识别结果。
        /// - 无论您在单个Trace中提供了多少张人体图片，我们都将生成一个对应的动作轨迹（Trace）信息。即，Trace仅和本次输入的图片序列相关，和图片的个数无关。
        /// - 输入的图片组中，若有部分图片输入不合法（如图片大小过大、分辨率过大、无法解码等），我们将舍弃这部分图片，确保合法图片被正确搜索。即，我们将尽可能保证请求成功，去除不合法的输入；
        /// - 构成人体动作轨迹单张图片大小限制为2M，分辨率限制为1920*1080。
        /// </summary>
        /// <param name="req"><see cref="CreateTraceRequest"/></param>
        /// <returns><see cref="CreateTraceResponse"/></returns>
        public Task<CreateTraceResponse> CreateTrace(CreateTraceRequest req)
        {
            return InternalRequestAsync<CreateTraceResponse>(req, "CreateTrace");
        }

        /// <summary>
        /// 将一个人体动作轨迹添加到一个人员中。一个人员最多允许包含 5 个人体动作轨迹。同一人的人体动作轨迹越多，搜索识别效果越好。
        /// 
        /// >请注意：
        /// - 我们希望您的输入为 严格符合动作轨迹图片 要求的图片。如果您输入的图片不符合动作轨迹图片要求，会对最终效果产生较大负面影响。请您尽量保证一个Trace中的图片人体清晰、无遮挡、连贯。
        /// - 一个人体动作轨迹（Trace）可以包含1-5张人体图片。提供越多质量高的人体图片有助于提升最终识别结果。
        /// - 无论您在单个Trace中提供了多少张人体图片，我们都将生成一个对应的动作轨迹（Trace）信息。即，Trace仅和本次输入的图片序列相关，和图片的个数无关。
        /// - 输入的图片组中，若有部分图片输入不合法（如图片大小过大、分辨率过大、无法解码等），我们将舍弃这部分图片，确保合法图片被正确搜索。即，我们将尽可能保证请求成功，去除不合法的输入；
        /// - 构成人体动作轨迹单张图片大小限制为2M，分辨率限制为1920*1080。
        /// </summary>
        /// <param name="req"><see cref="CreateTraceRequest"/></param>
        /// <returns><see cref="CreateTraceResponse"/></returns>
        public CreateTraceResponse CreateTraceSync(CreateTraceRequest req)
        {
            return InternalRequestAsync<CreateTraceResponse>(req, "CreateTrace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除该人体库及包含的所有的人员。
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup");
        }

        /// <summary>
        /// 删除该人体库及包含的所有的人员。
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除人员。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonRequest"/></param>
        /// <returns><see cref="DeletePersonResponse"/></returns>
        public Task<DeletePersonResponse> DeletePerson(DeletePersonRequest req)
        {
            return InternalRequestAsync<DeletePersonResponse>(req, "DeletePerson");
        }

        /// <summary>
        /// 删除人员。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonRequest"/></param>
        /// <returns><see cref="DeletePersonResponse"/></returns>
        public DeletePersonResponse DeletePersonSync(DeletePersonRequest req)
        {
            return InternalRequestAsync<DeletePersonResponse>(req, "DeletePerson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可以查看单条任务的处理情况，包括处理状态，处理结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeSegmentationTaskRequest"/></param>
        /// <returns><see cref="DescribeSegmentationTaskResponse"/></returns>
        public Task<DescribeSegmentationTaskResponse> DescribeSegmentationTask(DescribeSegmentationTaskRequest req)
        {
            return InternalRequestAsync<DescribeSegmentationTaskResponse>(req, "DescribeSegmentationTask");
        }

        /// <summary>
        /// 可以查看单条任务的处理情况，包括处理状态，处理结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeSegmentationTaskRequest"/></param>
        /// <returns><see cref="DescribeSegmentationTaskResponse"/></returns>
        public DescribeSegmentationTaskResponse DescribeSegmentationTaskSync(DescribeSegmentationTaskRequest req)
        {
            return InternalRequestAsync<DescribeSegmentationTaskResponse>(req, "DescribeSegmentationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检测给定图片中的人体（Body）的位置信息及属性信息。
        /// </summary>
        /// <param name="req"><see cref="DetectBodyRequest"/></param>
        /// <returns><see cref="DetectBodyResponse"/></returns>
        public Task<DetectBodyResponse> DetectBody(DetectBodyRequest req)
        {
            return InternalRequestAsync<DetectBodyResponse>(req, "DetectBody");
        }

        /// <summary>
        /// 检测给定图片中的人体（Body）的位置信息及属性信息。
        /// </summary>
        /// <param name="req"><see cref="DetectBodyRequest"/></param>
        /// <returns><see cref="DetectBodyResponse"/></returns>
        public DetectBodyResponse DetectBodySync(DetectBodyRequest req)
        {
            return InternalRequestAsync<DetectBodyResponse>(req, "DetectBody")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检测图片中人体的14个关键点。建议用于人体图像清晰、无遮挡的场景。支持一张图片中存在多个人体的识别。
        /// </summary>
        /// <param name="req"><see cref="DetectBodyJointsRequest"/></param>
        /// <returns><see cref="DetectBodyJointsResponse"/></returns>
        public Task<DetectBodyJointsResponse> DetectBodyJoints(DetectBodyJointsRequest req)
        {
            return InternalRequestAsync<DetectBodyJointsResponse>(req, "DetectBodyJoints");
        }

        /// <summary>
        /// 检测图片中人体的14个关键点。建议用于人体图像清晰、无遮挡的场景。支持一张图片中存在多个人体的识别。
        /// </summary>
        /// <param name="req"><see cref="DetectBodyJointsRequest"/></param>
        /// <returns><see cref="DetectBodyJointsResponse"/></returns>
        public DetectBodyJointsResponse DetectBodyJointsSync(DetectBodyJointsRequest req)
        {
            return InternalRequestAsync<DetectBodyJointsResponse>(req, "DetectBodyJoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取人体库列表。
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public Task<GetGroupListResponse> GetGroupList(GetGroupListRequest req)
        {
            return InternalRequestAsync<GetGroupListResponse>(req, "GetGroupList");
        }

        /// <summary>
        /// 获取人体库列表。
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public GetGroupListResponse GetGroupListSync(GetGroupListRequest req)
        {
            return InternalRequestAsync<GetGroupListResponse>(req, "GetGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定人体库中的人员列表。
        /// </summary>
        /// <param name="req"><see cref="GetPersonListRequest"/></param>
        /// <returns><see cref="GetPersonListResponse"/></returns>
        public Task<GetPersonListResponse> GetPersonList(GetPersonListRequest req)
        {
            return InternalRequestAsync<GetPersonListResponse>(req, "GetPersonList");
        }

        /// <summary>
        /// 获取指定人体库中的人员列表。
        /// </summary>
        /// <param name="req"><see cref="GetPersonListRequest"/></param>
        /// <returns><see cref="GetPersonListResponse"/></returns>
        public GetPersonListResponse GetPersonListSync(GetPersonListRequest req)
        {
            return InternalRequestAsync<GetPersonListResponse>(req, "GetPersonList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取人体库汇总信息。
        /// </summary>
        /// <param name="req"><see cref="GetSummaryInfoRequest"/></param>
        /// <returns><see cref="GetSummaryInfoResponse"/></returns>
        public Task<GetSummaryInfoResponse> GetSummaryInfo(GetSummaryInfoRequest req)
        {
            return InternalRequestAsync<GetSummaryInfoResponse>(req, "GetSummaryInfo");
        }

        /// <summary>
        /// 获取人体库汇总信息。
        /// </summary>
        /// <param name="req"><see cref="GetSummaryInfoRequest"/></param>
        /// <returns><see cref="GetSummaryInfoResponse"/></returns>
        public GetSummaryInfoResponse GetSummaryInfoSync(GetSummaryInfoRequest req)
        {
            return InternalRequestAsync<GetSummaryInfoResponse>(req, "GetSummaryInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改人体库名称、备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public Task<ModifyGroupResponse> ModifyGroup(ModifyGroupRequest req)
        {
            return InternalRequestAsync<ModifyGroupResponse>(req, "ModifyGroup");
        }

        /// <summary>
        /// 修改人体库名称、备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public ModifyGroupResponse ModifyGroupSync(ModifyGroupRequest req)
        {
            return InternalRequestAsync<ModifyGroupResponse>(req, "ModifyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改人员信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonInfoResponse"/></returns>
        public Task<ModifyPersonInfoResponse> ModifyPersonInfo(ModifyPersonInfoRequest req)
        {
            return InternalRequestAsync<ModifyPersonInfoResponse>(req, "ModifyPersonInfo");
        }

        /// <summary>
        /// 修改人员信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonInfoResponse"/></returns>
        public ModifyPersonInfoResponse ModifyPersonInfoSync(ModifyPersonInfoRequest req)
        {
            return InternalRequestAsync<ModifyPersonInfoResponse>(req, "ModifyPersonInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于对一组待识别的人体动作轨迹（Trace）图片，在人体库中识别出最相似的 TopK 人体，按照相似度从大到小排列。
        /// 
        /// 人体动作轨迹（Trace）图片要求：图片中当且仅包含一个人体。人体完整、无遮挡。
        /// 
        /// > 请注意：
        /// - 我们希望您的输入为严格符合动作轨迹图片要求的图片。如果您输入的图片不符合动作轨迹图片要求，会对最终效果产生较大负面影响；
        /// - 人体动作轨迹，是一个包含1-5张图片的图片序列。您可以输入1张图片作为动作轨迹，也可以输入多张。单个动作轨迹中包含越多符合质量的图片，搜索效果越好。
        /// - 构成人体动作轨迹单张图片大小不得超过2M，分辨率不得超过1920*1080。
        /// </summary>
        /// <param name="req"><see cref="SearchTraceRequest"/></param>
        /// <returns><see cref="SearchTraceResponse"/></returns>
        public Task<SearchTraceResponse> SearchTrace(SearchTraceRequest req)
        {
            return InternalRequestAsync<SearchTraceResponse>(req, "SearchTrace");
        }

        /// <summary>
        /// 本接口用于对一组待识别的人体动作轨迹（Trace）图片，在人体库中识别出最相似的 TopK 人体，按照相似度从大到小排列。
        /// 
        /// 人体动作轨迹（Trace）图片要求：图片中当且仅包含一个人体。人体完整、无遮挡。
        /// 
        /// > 请注意：
        /// - 我们希望您的输入为严格符合动作轨迹图片要求的图片。如果您输入的图片不符合动作轨迹图片要求，会对最终效果产生较大负面影响；
        /// - 人体动作轨迹，是一个包含1-5张图片的图片序列。您可以输入1张图片作为动作轨迹，也可以输入多张。单个动作轨迹中包含越多符合质量的图片，搜索效果越好。
        /// - 构成人体动作轨迹单张图片大小不得超过2M，分辨率不得超过1920*1080。
        /// </summary>
        /// <param name="req"><see cref="SearchTraceRequest"/></param>
        /// <returns><see cref="SearchTraceResponse"/></returns>
        public SearchTraceResponse SearchTraceSync(SearchTraceRequest req)
        {
            return InternalRequestAsync<SearchTraceResponse>(req, "SearchTrace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在前后景分割的基础上优化多分类分割，支持对头发、五官等的分割，既作为换发型、挂件等底层技术，也可用于抠人头、抠人脸等玩法
        /// </summary>
        /// <param name="req"><see cref="SegmentCustomizedPortraitPicRequest"/></param>
        /// <returns><see cref="SegmentCustomizedPortraitPicResponse"/></returns>
        public Task<SegmentCustomizedPortraitPicResponse> SegmentCustomizedPortraitPic(SegmentCustomizedPortraitPicRequest req)
        {
            return InternalRequestAsync<SegmentCustomizedPortraitPicResponse>(req, "SegmentCustomizedPortraitPic");
        }

        /// <summary>
        /// 在前后景分割的基础上优化多分类分割，支持对头发、五官等的分割，既作为换发型、挂件等底层技术，也可用于抠人头、抠人脸等玩法
        /// </summary>
        /// <param name="req"><see cref="SegmentCustomizedPortraitPicRequest"/></param>
        /// <returns><see cref="SegmentCustomizedPortraitPicResponse"/></returns>
        public SegmentCustomizedPortraitPicResponse SegmentCustomizedPortraitPicSync(SegmentCustomizedPortraitPicRequest req)
        {
            return InternalRequestAsync<SegmentCustomizedPortraitPicResponse>(req, "SegmentCustomizedPortraitPic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 即二分类人像分割，识别传入图片中人体的完整轮廓，进行抠像。
        /// </summary>
        /// <param name="req"><see cref="SegmentPortraitPicRequest"/></param>
        /// <returns><see cref="SegmentPortraitPicResponse"/></returns>
        public Task<SegmentPortraitPicResponse> SegmentPortraitPic(SegmentPortraitPicRequest req)
        {
            return InternalRequestAsync<SegmentPortraitPicResponse>(req, "SegmentPortraitPic");
        }

        /// <summary>
        /// 即二分类人像分割，识别传入图片中人体的完整轮廓，进行抠像。
        /// </summary>
        /// <param name="req"><see cref="SegmentPortraitPicRequest"/></param>
        /// <returns><see cref="SegmentPortraitPicResponse"/></returns>
        public SegmentPortraitPicResponse SegmentPortraitPicSync(SegmentPortraitPicRequest req)
        {
            return InternalRequestAsync<SegmentPortraitPicResponse>(req, "SegmentPortraitPic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 终止指定视频人像分割处理任务
        /// </summary>
        /// <param name="req"><see cref="TerminateSegmentationTaskRequest"/></param>
        /// <returns><see cref="TerminateSegmentationTaskResponse"/></returns>
        public Task<TerminateSegmentationTaskResponse> TerminateSegmentationTask(TerminateSegmentationTaskRequest req)
        {
            return InternalRequestAsync<TerminateSegmentationTaskResponse>(req, "TerminateSegmentationTask");
        }

        /// <summary>
        /// 终止指定视频人像分割处理任务
        /// </summary>
        /// <param name="req"><see cref="TerminateSegmentationTaskRequest"/></param>
        /// <returns><see cref="TerminateSegmentationTaskResponse"/></returns>
        public TerminateSegmentationTaskResponse TerminateSegmentationTaskSync(TerminateSegmentationTaskRequest req)
        {
            return InternalRequestAsync<TerminateSegmentationTaskResponse>(req, "TerminateSegmentationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
