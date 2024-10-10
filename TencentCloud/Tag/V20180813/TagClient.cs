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

namespace TencentCloud.Tag.V20180813
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tag.V20180813.Models;

   public class TagClient : AbstractClient{

       private const string endpoint = "tag.tencentcloudapi.com";
       private const string version = "2018-08-13";
       private const string sdkVersion = "SDK_NET_3.0.1103";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TagClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TagClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="req"><see cref="AddProjectRequest"/></param>
        /// <returns><see cref="AddProjectResponse"/></returns>
        public Task<AddProjectResponse> AddProject(AddProjectRequest req)
        {
            return InternalRequestAsync<AddProjectResponse>(req, "AddProject");
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="req"><see cref="AddProjectRequest"/></param>
        /// <returns><see cref="AddProjectResponse"/></returns>
        public AddProjectResponse AddProjectSync(AddProjectRequest req)
        {
            return InternalRequestAsync<AddProjectResponse>(req, "AddProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于给标签关联资源
        /// </summary>
        /// <param name="req"><see cref="AddResourceTagRequest"/></param>
        /// <returns><see cref="AddResourceTagResponse"/></returns>
        public Task<AddResourceTagResponse> AddResourceTag(AddResourceTagRequest req)
        {
            return InternalRequestAsync<AddResourceTagResponse>(req, "AddResourceTag");
        }

        /// <summary>
        /// 本接口用于给标签关联资源
        /// </summary>
        /// <param name="req"><see cref="AddResourceTagRequest"/></param>
        /// <returns><see cref="AddResourceTagResponse"/></returns>
        public AddResourceTagResponse AddResourceTagSync(AddResourceTagRequest req)
        {
            return InternalRequestAsync<AddResourceTagResponse>(req, "AddResourceTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 给多个资源关联某个标签
        /// </summary>
        /// <param name="req"><see cref="AttachResourcesTagRequest"/></param>
        /// <returns><see cref="AttachResourcesTagResponse"/></returns>
        public Task<AttachResourcesTagResponse> AttachResourcesTag(AttachResourcesTagRequest req)
        {
            return InternalRequestAsync<AttachResourcesTagResponse>(req, "AttachResourcesTag");
        }

        /// <summary>
        /// 给多个资源关联某个标签
        /// </summary>
        /// <param name="req"><see cref="AttachResourcesTagRequest"/></param>
        /// <returns><see cref="AttachResourcesTagResponse"/></returns>
        public AttachResourcesTagResponse AttachResourcesTagSync(AttachResourcesTagRequest req)
        {
            return InternalRequestAsync<AttachResourcesTagResponse>(req, "AttachResourcesTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建一对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="CreateTagRequest"/></param>
        /// <returns><see cref="CreateTagResponse"/></returns>
        public Task<CreateTagResponse> CreateTag(CreateTagRequest req)
        {
            return InternalRequestAsync<CreateTagResponse>(req, "CreateTag");
        }

        /// <summary>
        /// 本接口用于创建一对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="CreateTagRequest"/></param>
        /// <returns><see cref="CreateTagResponse"/></returns>
        public CreateTagResponse CreateTagSync(CreateTagRequest req)
        {
            return InternalRequestAsync<CreateTagResponse>(req, "CreateTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建多对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="CreateTagsRequest"/></param>
        /// <returns><see cref="CreateTagsResponse"/></returns>
        public Task<CreateTagsResponse> CreateTags(CreateTagsRequest req)
        {
            return InternalRequestAsync<CreateTagsResponse>(req, "CreateTags");
        }

        /// <summary>
        /// 本接口用于创建多对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="CreateTagsRequest"/></param>
        /// <returns><see cref="CreateTagsResponse"/></returns>
        public CreateTagsResponse CreateTagsSync(CreateTagsRequest req)
        {
            return InternalRequestAsync<CreateTagsResponse>(req, "CreateTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于解除标签和资源的关联关系
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceTagRequest"/></param>
        /// <returns><see cref="DeleteResourceTagResponse"/></returns>
        public Task<DeleteResourceTagResponse> DeleteResourceTag(DeleteResourceTagRequest req)
        {
            return InternalRequestAsync<DeleteResourceTagResponse>(req, "DeleteResourceTag");
        }

        /// <summary>
        /// 本接口用于解除标签和资源的关联关系
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceTagRequest"/></param>
        /// <returns><see cref="DeleteResourceTagResponse"/></returns>
        public DeleteResourceTagResponse DeleteResourceTagSync(DeleteResourceTagRequest req)
        {
            return InternalRequestAsync<DeleteResourceTagResponse>(req, "DeleteResourceTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除一对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRequest"/></param>
        /// <returns><see cref="DeleteTagResponse"/></returns>
        public Task<DeleteTagResponse> DeleteTag(DeleteTagRequest req)
        {
            return InternalRequestAsync<DeleteTagResponse>(req, "DeleteTag");
        }

        /// <summary>
        /// 本接口用于删除一对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRequest"/></param>
        /// <returns><see cref="DeleteTagResponse"/></returns>
        public DeleteTagResponse DeleteTagSync(DeleteTagRequest req)
        {
            return InternalRequestAsync<DeleteTagResponse>(req, "DeleteTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于批量删除标签键和标签值。
        /// </summary>
        /// <param name="req"><see cref="DeleteTagsRequest"/></param>
        /// <returns><see cref="DeleteTagsResponse"/></returns>
        public Task<DeleteTagsResponse> DeleteTags(DeleteTagsRequest req)
        {
            return InternalRequestAsync<DeleteTagsResponse>(req, "DeleteTags");
        }

        /// <summary>
        /// 本接口用于批量删除标签键和标签值。
        /// </summary>
        /// <param name="req"><see cref="DeleteTagsRequest"/></param>
        /// <returns><see cref="DeleteTagsResponse"/></returns>
        public DeleteTagsResponse DeleteTagsSync(DeleteTagsRequest req)
        {
            return InternalRequestAsync<DeleteTagsResponse>(req, "DeleteTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects");
        }

        /// <summary>
        /// 获取项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源关联标签
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsResponse"/></returns>
        public Task<DescribeResourceTagsResponse> DescribeResourceTags(DescribeResourceTagsRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsResponse>(req, "DescribeResourceTags");
        }

        /// <summary>
        /// 查询资源关联标签
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsResponse"/></returns>
        public DescribeResourceTagsResponse DescribeResourceTagsSync(DescribeResourceTagsRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsResponse>(req, "DescribeResourceTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于批量查询已有资源关联的标签键值对
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsResponse"/></returns>
        public Task<DescribeResourceTagsByResourceIdsResponse> DescribeResourceTagsByResourceIds(DescribeResourceTagsByResourceIdsRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsByResourceIdsResponse>(req, "DescribeResourceTagsByResourceIds");
        }

        /// <summary>
        /// 用于批量查询已有资源关联的标签键值对
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsResponse"/></returns>
        public DescribeResourceTagsByResourceIdsResponse DescribeResourceTagsByResourceIdsSync(DescribeResourceTagsByResourceIdsRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsByResourceIdsResponse>(req, "DescribeResourceTagsByResourceIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按顺序查看资源关联的标签
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsSeqRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsSeqResponse"/></returns>
        public Task<DescribeResourceTagsByResourceIdsSeqResponse> DescribeResourceTagsByResourceIdsSeq(DescribeResourceTagsByResourceIdsSeqRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsByResourceIdsSeqResponse>(req, "DescribeResourceTagsByResourceIdsSeq");
        }

        /// <summary>
        /// 按顺序查看资源关联的标签
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsSeqRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsSeqResponse"/></returns>
        public DescribeResourceTagsByResourceIdsSeqResponse DescribeResourceTagsByResourceIdsSeqSync(DescribeResourceTagsByResourceIdsSeqRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsByResourceIdsSeqResponse>(req, "DescribeResourceTagsByResourceIdsSeq")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据标签键获取资源标签
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByTagKeysRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByTagKeysResponse"/></returns>
        public Task<DescribeResourceTagsByTagKeysResponse> DescribeResourceTagsByTagKeys(DescribeResourceTagsByTagKeysRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsByTagKeysResponse>(req, "DescribeResourceTagsByTagKeys");
        }

        /// <summary>
        /// 根据标签键获取资源标签
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByTagKeysRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByTagKeysResponse"/></returns>
        public DescribeResourceTagsByTagKeysResponse DescribeResourceTagsByTagKeysSync(DescribeResourceTagsByTagKeysRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsByTagKeysResponse>(req, "DescribeResourceTagsByTagKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过标签查询资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsResponse"/></returns>
        public Task<DescribeResourcesByTagsResponse> DescribeResourcesByTags(DescribeResourcesByTagsRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByTagsResponse>(req, "DescribeResourcesByTags");
        }

        /// <summary>
        /// 通过标签查询资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsResponse"/></returns>
        public DescribeResourcesByTagsResponse DescribeResourcesByTagsSync(DescribeResourcesByTagsRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByTagsResponse>(req, "DescribeResourcesByTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过标签查询资源列表并集
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsUnionRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsUnionResponse"/></returns>
        public Task<DescribeResourcesByTagsUnionResponse> DescribeResourcesByTagsUnion(DescribeResourcesByTagsUnionRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByTagsUnionResponse>(req, "DescribeResourcesByTagsUnion");
        }

        /// <summary>
        /// 通过标签查询资源列表并集
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsUnionRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsUnionResponse"/></returns>
        public DescribeResourcesByTagsUnionResponse DescribeResourcesByTagsUnionSync(DescribeResourcesByTagsUnionRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByTagsUnionResponse>(req, "DescribeResourcesByTagsUnion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签键。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagKeysRequest"/></param>
        /// <returns><see cref="DescribeTagKeysResponse"/></returns>
        public Task<DescribeTagKeysResponse> DescribeTagKeys(DescribeTagKeysRequest req)
        {
            return InternalRequestAsync<DescribeTagKeysResponse>(req, "DescribeTagKeys");
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签键。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagKeysRequest"/></param>
        /// <returns><see cref="DescribeTagKeysResponse"/></returns>
        public DescribeTagKeysResponse DescribeTagKeysSync(DescribeTagKeysRequest req)
        {
            return InternalRequestAsync<DescribeTagKeysResponse>(req, "DescribeTagKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public Task<DescribeTagValuesResponse> DescribeTagValues(DescribeTagValuesRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesResponse>(req, "DescribeTagValues");
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public DescribeTagValuesResponse DescribeTagValuesSync(DescribeTagValuesRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesResponse>(req, "DescribeTagValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesSeqRequest"/></param>
        /// <returns><see cref="DescribeTagValuesSeqResponse"/></returns>
        public Task<DescribeTagValuesSeqResponse> DescribeTagValuesSeq(DescribeTagValuesSeqRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesSeqResponse>(req, "DescribeTagValuesSeq");
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesSeqRequest"/></param>
        /// <returns><see cref="DescribeTagValuesSeqResponse"/></returns>
        public DescribeTagValuesSeqResponse DescribeTagValuesSeqSync(DescribeTagValuesSeqRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesSeqResponse>(req, "DescribeTagValuesSeq")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询已建立的标签列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public Task<DescribeTagsResponse> DescribeTags(DescribeTagsRequest req)
        {
            return InternalRequestAsync<DescribeTagsResponse>(req, "DescribeTags");
        }

        /// <summary>
        /// 用于查询已建立的标签列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public DescribeTagsResponse DescribeTagsSync(DescribeTagsRequest req)
        {
            return InternalRequestAsync<DescribeTagsResponse>(req, "DescribeTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询已建立的标签列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsSeqRequest"/></param>
        /// <returns><see cref="DescribeTagsSeqResponse"/></returns>
        public Task<DescribeTagsSeqResponse> DescribeTagsSeq(DescribeTagsSeqRequest req)
        {
            return InternalRequestAsync<DescribeTagsSeqResponse>(req, "DescribeTagsSeq");
        }

        /// <summary>
        /// 用于查询已建立的标签列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsSeqRequest"/></param>
        /// <returns><see cref="DescribeTagsSeqResponse"/></returns>
        public DescribeTagsSeqResponse DescribeTagsSeqSync(DescribeTagsSeqRequest req)
        {
            return InternalRequestAsync<DescribeTagsSeqResponse>(req, "DescribeTagsSeq")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑多个资源关联的某个标签
        /// </summary>
        /// <param name="req"><see cref="DetachResourcesTagRequest"/></param>
        /// <returns><see cref="DetachResourcesTagResponse"/></returns>
        public Task<DetachResourcesTagResponse> DetachResourcesTag(DetachResourcesTagRequest req)
        {
            return InternalRequestAsync<DetachResourcesTagResponse>(req, "DetachResourcesTag");
        }

        /// <summary>
        /// 解绑多个资源关联的某个标签
        /// </summary>
        /// <param name="req"><see cref="DetachResourcesTagRequest"/></param>
        /// <returns><see cref="DetachResourcesTagResponse"/></returns>
        public DetachResourcesTagResponse DetachResourcesTagSync(DetachResourcesTagRequest req)
        {
            return InternalRequestAsync<DetachResourcesTagResponse>(req, "DetachResourcesTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询绑定了标签的资源列表。
        /// </summary>
        /// <param name="req"><see cref="GetResourcesRequest"/></param>
        /// <returns><see cref="GetResourcesResponse"/></returns>
        public Task<GetResourcesResponse> GetResources(GetResourcesRequest req)
        {
            return InternalRequestAsync<GetResourcesResponse>(req, "GetResources");
        }

        /// <summary>
        /// 查询绑定了标签的资源列表。
        /// </summary>
        /// <param name="req"><see cref="GetResourcesRequest"/></param>
        /// <returns><see cref="GetResourcesResponse"/></returns>
        public GetResourcesResponse GetResourcesSync(GetResourcesRequest req)
        {
            return InternalRequestAsync<GetResourcesResponse>(req, "GetResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询标签键列表。
        /// </summary>
        /// <param name="req"><see cref="GetTagKeysRequest"/></param>
        /// <returns><see cref="GetTagKeysResponse"/></returns>
        public Task<GetTagKeysResponse> GetTagKeys(GetTagKeysRequest req)
        {
            return InternalRequestAsync<GetTagKeysResponse>(req, "GetTagKeys");
        }

        /// <summary>
        /// 查询标签键列表。
        /// </summary>
        /// <param name="req"><see cref="GetTagKeysRequest"/></param>
        /// <returns><see cref="GetTagKeysResponse"/></returns>
        public GetTagKeysResponse GetTagKeysSync(GetTagKeysRequest req)
        {
            return InternalRequestAsync<GetTagKeysResponse>(req, "GetTagKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req"><see cref="GetTagValuesRequest"/></param>
        /// <returns><see cref="GetTagValuesResponse"/></returns>
        public Task<GetTagValuesResponse> GetTagValues(GetTagValuesRequest req)
        {
            return InternalRequestAsync<GetTagValuesResponse>(req, "GetTagValues");
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req"><see cref="GetTagValuesRequest"/></param>
        /// <returns><see cref="GetTagValuesResponse"/></returns>
        public GetTagValuesResponse GetTagValuesSync(GetTagValuesRequest req)
        {
            return InternalRequestAsync<GetTagValuesResponse>(req, "GetTagValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取已建立的标签列表。
        /// </summary>
        /// <param name="req"><see cref="GetTagsRequest"/></param>
        /// <returns><see cref="GetTagsResponse"/></returns>
        public Task<GetTagsResponse> GetTags(GetTagsRequest req)
        {
            return InternalRequestAsync<GetTagsResponse>(req, "GetTags");
        }

        /// <summary>
        /// 用于获取已建立的标签列表。
        /// </summary>
        /// <param name="req"><see cref="GetTagsRequest"/></param>
        /// <returns><see cref="GetTagsResponse"/></returns>
        public GetTagsResponse GetTagsSync(GetTagsRequest req)
        {
            return InternalRequestAsync<GetTagsResponse>(req, "GetTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改资源关联的所有标签
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public Task<ModifyResourceTagsResponse> ModifyResourceTags(ModifyResourceTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourceTagsResponse>(req, "ModifyResourceTags");
        }

        /// <summary>
        /// 本接口用于修改资源关联的所有标签
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public ModifyResourceTagsResponse ModifyResourceTagsSync(ModifyResourceTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourceTagsResponse>(req, "ModifyResourceTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改多个资源关联的某个标签键对应的标签值
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcesTagValueRequest"/></param>
        /// <returns><see cref="ModifyResourcesTagValueResponse"/></returns>
        public Task<ModifyResourcesTagValueResponse> ModifyResourcesTagValue(ModifyResourcesTagValueRequest req)
        {
            return InternalRequestAsync<ModifyResourcesTagValueResponse>(req, "ModifyResourcesTagValue");
        }

        /// <summary>
        /// 修改多个资源关联的某个标签键对应的标签值
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcesTagValueRequest"/></param>
        /// <returns><see cref="ModifyResourcesTagValueResponse"/></returns>
        public ModifyResourcesTagValueResponse ModifyResourcesTagValueSync(ModifyResourcesTagValueRequest req)
        {
            return InternalRequestAsync<ModifyResourcesTagValueResponse>(req, "ModifyResourcesTagValue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为指定的多个云产品的多个云资源统一创建并绑定标签。
        /// </summary>
        /// <param name="req"><see cref="TagResourcesRequest"/></param>
        /// <returns><see cref="TagResourcesResponse"/></returns>
        public Task<TagResourcesResponse> TagResources(TagResourcesRequest req)
        {
            return InternalRequestAsync<TagResourcesResponse>(req, "TagResources");
        }

        /// <summary>
        /// 为指定的多个云产品的多个云资源统一创建并绑定标签。
        /// </summary>
        /// <param name="req"><see cref="TagResourcesRequest"/></param>
        /// <returns><see cref="TagResourcesResponse"/></returns>
        public TagResourcesResponse TagResourcesSync(TagResourcesRequest req)
        {
            return InternalRequestAsync<TagResourcesResponse>(req, "TagResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 指定的多个云产品的多个云资源统一解绑标签。
        /// </summary>
        /// <param name="req"><see cref="UnTagResourcesRequest"/></param>
        /// <returns><see cref="UnTagResourcesResponse"/></returns>
        public Task<UnTagResourcesResponse> UnTagResources(UnTagResourcesRequest req)
        {
            return InternalRequestAsync<UnTagResourcesResponse>(req, "UnTagResources");
        }

        /// <summary>
        /// 指定的多个云产品的多个云资源统一解绑标签。
        /// </summary>
        /// <param name="req"><see cref="UnTagResourcesRequest"/></param>
        /// <returns><see cref="UnTagResourcesResponse"/></returns>
        public UnTagResourcesResponse UnTagResourcesSync(UnTagResourcesRequest req)
        {
            return InternalRequestAsync<UnTagResourcesResponse>(req, "UnTagResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="req"><see cref="UpdateProjectRequest"/></param>
        /// <returns><see cref="UpdateProjectResponse"/></returns>
        public Task<UpdateProjectResponse> UpdateProject(UpdateProjectRequest req)
        {
            return InternalRequestAsync<UpdateProjectResponse>(req, "UpdateProject");
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="req"><see cref="UpdateProjectRequest"/></param>
        /// <returns><see cref="UpdateProjectResponse"/></returns>
        public UpdateProjectResponse UpdateProjectSync(UpdateProjectRequest req)
        {
            return InternalRequestAsync<UpdateProjectResponse>(req, "UpdateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改资源已关联的标签值（标签键不变）
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceTagValueRequest"/></param>
        /// <returns><see cref="UpdateResourceTagValueResponse"/></returns>
        public Task<UpdateResourceTagValueResponse> UpdateResourceTagValue(UpdateResourceTagValueRequest req)
        {
            return InternalRequestAsync<UpdateResourceTagValueResponse>(req, "UpdateResourceTagValue");
        }

        /// <summary>
        /// 本接口用于修改资源已关联的标签值（标签键不变）
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceTagValueRequest"/></param>
        /// <returns><see cref="UpdateResourceTagValueResponse"/></returns>
        public UpdateResourceTagValueResponse UpdateResourceTagValueSync(UpdateResourceTagValueRequest req)
        {
            return InternalRequestAsync<UpdateResourceTagValueResponse>(req, "UpdateResourceTagValue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
