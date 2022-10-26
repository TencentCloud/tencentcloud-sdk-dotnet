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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TagClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="req"><see cref="AddProjectRequest"/></param>
        /// <returns><see cref="AddProjectResponse"/></returns>
        public async Task<AddProjectResponse> AddProject(AddProjectRequest req)
        {
             JsonResponseModel<AddProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="req"><see cref="AddProjectRequest"/></param>
        /// <returns><see cref="AddProjectResponse"/></returns>
        public AddProjectResponse AddProjectSync(AddProjectRequest req)
        {
             JsonResponseModel<AddProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于给标签关联资源
        /// </summary>
        /// <param name="req"><see cref="AddResourceTagRequest"/></param>
        /// <returns><see cref="AddResourceTagResponse"/></returns>
        public async Task<AddResourceTagResponse> AddResourceTag(AddResourceTagRequest req)
        {
             JsonResponseModel<AddResourceTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddResourceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddResourceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于给标签关联资源
        /// </summary>
        /// <param name="req"><see cref="AddResourceTagRequest"/></param>
        /// <returns><see cref="AddResourceTagResponse"/></returns>
        public AddResourceTagResponse AddResourceTagSync(AddResourceTagRequest req)
        {
             JsonResponseModel<AddResourceTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddResourceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddResourceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给多个资源关联某个标签
        /// </summary>
        /// <param name="req"><see cref="AttachResourcesTagRequest"/></param>
        /// <returns><see cref="AttachResourcesTagResponse"/></returns>
        public async Task<AttachResourcesTagResponse> AttachResourcesTag(AttachResourcesTagRequest req)
        {
             JsonResponseModel<AttachResourcesTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachResourcesTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachResourcesTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给多个资源关联某个标签
        /// </summary>
        /// <param name="req"><see cref="AttachResourcesTagRequest"/></param>
        /// <returns><see cref="AttachResourcesTagResponse"/></returns>
        public AttachResourcesTagResponse AttachResourcesTagSync(AttachResourcesTagRequest req)
        {
             JsonResponseModel<AttachResourcesTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachResourcesTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachResourcesTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建一对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="CreateTagRequest"/></param>
        /// <returns><see cref="CreateTagResponse"/></returns>
        public async Task<CreateTagResponse> CreateTag(CreateTagRequest req)
        {
             JsonResponseModel<CreateTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建一对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="CreateTagRequest"/></param>
        /// <returns><see cref="CreateTagResponse"/></returns>
        public CreateTagResponse CreateTagSync(CreateTagRequest req)
        {
             JsonResponseModel<CreateTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建多对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="CreateTagsRequest"/></param>
        /// <returns><see cref="CreateTagsResponse"/></returns>
        public async Task<CreateTagsResponse> CreateTags(CreateTagsRequest req)
        {
             JsonResponseModel<CreateTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建多对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="CreateTagsRequest"/></param>
        /// <returns><see cref="CreateTagsResponse"/></returns>
        public CreateTagsResponse CreateTagsSync(CreateTagsRequest req)
        {
             JsonResponseModel<CreateTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于解除标签和资源的关联关系
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceTagRequest"/></param>
        /// <returns><see cref="DeleteResourceTagResponse"/></returns>
        public async Task<DeleteResourceTagResponse> DeleteResourceTag(DeleteResourceTagRequest req)
        {
             JsonResponseModel<DeleteResourceTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteResourceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于解除标签和资源的关联关系
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceTagRequest"/></param>
        /// <returns><see cref="DeleteResourceTagResponse"/></returns>
        public DeleteResourceTagResponse DeleteResourceTagSync(DeleteResourceTagRequest req)
        {
             JsonResponseModel<DeleteResourceTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteResourceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除一对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRequest"/></param>
        /// <returns><see cref="DeleteTagResponse"/></returns>
        public async Task<DeleteTagResponse> DeleteTag(DeleteTagRequest req)
        {
             JsonResponseModel<DeleteTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除一对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRequest"/></param>
        /// <returns><see cref="DeleteTagResponse"/></returns>
        public DeleteTagResponse DeleteTagSync(DeleteTagRequest req)
        {
             JsonResponseModel<DeleteTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除一对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="DeleteTagsRequest"/></param>
        /// <returns><see cref="DeleteTagsResponse"/></returns>
        public async Task<DeleteTagsResponse> DeleteTags(DeleteTagsRequest req)
        {
             JsonResponseModel<DeleteTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除一对标签键和标签值
        /// </summary>
        /// <param name="req"><see cref="DeleteTagsRequest"/></param>
        /// <returns><see cref="DeleteTagsResponse"/></returns>
        public DeleteTagsResponse DeleteTagsSync(DeleteTagsRequest req)
        {
             JsonResponseModel<DeleteTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public async Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
             JsonResponseModel<DescribeProjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
             JsonResponseModel<DescribeProjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源关联标签
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsResponse"/></returns>
        public async Task<DescribeResourceTagsResponse> DescribeResourceTags(DescribeResourceTagsRequest req)
        {
             JsonResponseModel<DescribeResourceTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源关联标签
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsResponse"/></returns>
        public DescribeResourceTagsResponse DescribeResourceTagsSync(DescribeResourceTagsRequest req)
        {
             JsonResponseModel<DescribeResourceTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量查询已有资源关联的标签键值对
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsResponse"/></returns>
        public async Task<DescribeResourceTagsByResourceIdsResponse> DescribeResourceTagsByResourceIds(DescribeResourceTagsByResourceIdsRequest req)
        {
             JsonResponseModel<DescribeResourceTagsByResourceIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceTagsByResourceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsByResourceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量查询已有资源关联的标签键值对
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsResponse"/></returns>
        public DescribeResourceTagsByResourceIdsResponse DescribeResourceTagsByResourceIdsSync(DescribeResourceTagsByResourceIdsRequest req)
        {
             JsonResponseModel<DescribeResourceTagsByResourceIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceTagsByResourceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsByResourceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按顺序查看资源关联的标签
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsSeqRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsSeqResponse"/></returns>
        public async Task<DescribeResourceTagsByResourceIdsSeqResponse> DescribeResourceTagsByResourceIdsSeq(DescribeResourceTagsByResourceIdsSeqRequest req)
        {
             JsonResponseModel<DescribeResourceTagsByResourceIdsSeqResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceTagsByResourceIdsSeq");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsByResourceIdsSeqResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按顺序查看资源关联的标签
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsSeqRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsSeqResponse"/></returns>
        public DescribeResourceTagsByResourceIdsSeqResponse DescribeResourceTagsByResourceIdsSeqSync(DescribeResourceTagsByResourceIdsSeqRequest req)
        {
             JsonResponseModel<DescribeResourceTagsByResourceIdsSeqResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceTagsByResourceIdsSeq");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsByResourceIdsSeqResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据标签键获取资源标签
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByTagKeysRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByTagKeysResponse"/></returns>
        public async Task<DescribeResourceTagsByTagKeysResponse> DescribeResourceTagsByTagKeys(DescribeResourceTagsByTagKeysRequest req)
        {
             JsonResponseModel<DescribeResourceTagsByTagKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceTagsByTagKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsByTagKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据标签键获取资源标签
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByTagKeysRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByTagKeysResponse"/></returns>
        public DescribeResourceTagsByTagKeysResponse DescribeResourceTagsByTagKeysSync(DescribeResourceTagsByTagKeysRequest req)
        {
             JsonResponseModel<DescribeResourceTagsByTagKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceTagsByTagKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsByTagKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过标签查询资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsResponse"/></returns>
        public async Task<DescribeResourcesByTagsResponse> DescribeResourcesByTags(DescribeResourcesByTagsRequest req)
        {
             JsonResponseModel<DescribeResourcesByTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourcesByTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesByTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过标签查询资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsResponse"/></returns>
        public DescribeResourcesByTagsResponse DescribeResourcesByTagsSync(DescribeResourcesByTagsRequest req)
        {
             JsonResponseModel<DescribeResourcesByTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourcesByTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesByTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过标签查询资源列表并集
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsUnionRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsUnionResponse"/></returns>
        public async Task<DescribeResourcesByTagsUnionResponse> DescribeResourcesByTagsUnion(DescribeResourcesByTagsUnionRequest req)
        {
             JsonResponseModel<DescribeResourcesByTagsUnionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourcesByTagsUnion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesByTagsUnionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过标签查询资源列表并集
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsUnionRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsUnionResponse"/></returns>
        public DescribeResourcesByTagsUnionResponse DescribeResourcesByTagsUnionSync(DescribeResourcesByTagsUnionRequest req)
        {
             JsonResponseModel<DescribeResourcesByTagsUnionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourcesByTagsUnion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesByTagsUnionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签键。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagKeysRequest"/></param>
        /// <returns><see cref="DescribeTagKeysResponse"/></returns>
        public async Task<DescribeTagKeysResponse> DescribeTagKeys(DescribeTagKeysRequest req)
        {
             JsonResponseModel<DescribeTagKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签键。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagKeysRequest"/></param>
        /// <returns><see cref="DescribeTagKeysResponse"/></returns>
        public DescribeTagKeysResponse DescribeTagKeysSync(DescribeTagKeysRequest req)
        {
             JsonResponseModel<DescribeTagKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public async Task<DescribeTagValuesResponse> DescribeTagValues(DescribeTagValuesRequest req)
        {
             JsonResponseModel<DescribeTagValuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public DescribeTagValuesResponse DescribeTagValuesSync(DescribeTagValuesRequest req)
        {
             JsonResponseModel<DescribeTagValuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesSeqRequest"/></param>
        /// <returns><see cref="DescribeTagValuesSeqResponse"/></returns>
        public async Task<DescribeTagValuesSeqResponse> DescribeTagValuesSeq(DescribeTagValuesSeqRequest req)
        {
             JsonResponseModel<DescribeTagValuesSeqResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagValuesSeq");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagValuesSeqResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesSeqRequest"/></param>
        /// <returns><see cref="DescribeTagValuesSeqResponse"/></returns>
        public DescribeTagValuesSeqResponse DescribeTagValuesSeqSync(DescribeTagValuesSeqRequest req)
        {
             JsonResponseModel<DescribeTagValuesSeqResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagValuesSeq");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagValuesSeqResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public async Task<DescribeTagsResponse> DescribeTags(DescribeTagsRequest req)
        {
             JsonResponseModel<DescribeTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public DescribeTagsResponse DescribeTagsSync(DescribeTagsRequest req)
        {
             JsonResponseModel<DescribeTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsSeqRequest"/></param>
        /// <returns><see cref="DescribeTagsSeqResponse"/></returns>
        public async Task<DescribeTagsSeqResponse> DescribeTagsSeq(DescribeTagsSeqRequest req)
        {
             JsonResponseModel<DescribeTagsSeqResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagsSeq");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsSeqResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsSeqRequest"/></param>
        /// <returns><see cref="DescribeTagsSeqResponse"/></returns>
        public DescribeTagsSeqResponse DescribeTagsSeqSync(DescribeTagsSeqRequest req)
        {
             JsonResponseModel<DescribeTagsSeqResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagsSeq");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsSeqResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑多个资源关联的某个标签
        /// </summary>
        /// <param name="req"><see cref="DetachResourcesTagRequest"/></param>
        /// <returns><see cref="DetachResourcesTagResponse"/></returns>
        public async Task<DetachResourcesTagResponse> DetachResourcesTag(DetachResourcesTagRequest req)
        {
             JsonResponseModel<DetachResourcesTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachResourcesTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachResourcesTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑多个资源关联的某个标签
        /// </summary>
        /// <param name="req"><see cref="DetachResourcesTagRequest"/></param>
        /// <returns><see cref="DetachResourcesTagResponse"/></returns>
        public DetachResourcesTagResponse DetachResourcesTagSync(DetachResourcesTagRequest req)
        {
             JsonResponseModel<DetachResourcesTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachResourcesTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachResourcesTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询绑定了标签的资源列表。
        /// </summary>
        /// <param name="req"><see cref="GetResourcesRequest"/></param>
        /// <returns><see cref="GetResourcesResponse"/></returns>
        public async Task<GetResourcesResponse> GetResources(GetResourcesRequest req)
        {
             JsonResponseModel<GetResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询绑定了标签的资源列表。
        /// </summary>
        /// <param name="req"><see cref="GetResourcesRequest"/></param>
        /// <returns><see cref="GetResourcesResponse"/></returns>
        public GetResourcesResponse GetResourcesSync(GetResourcesRequest req)
        {
             JsonResponseModel<GetResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询标签键列表。
        /// </summary>
        /// <param name="req"><see cref="GetTagKeysRequest"/></param>
        /// <returns><see cref="GetTagKeysResponse"/></returns>
        public async Task<GetTagKeysResponse> GetTagKeys(GetTagKeysRequest req)
        {
             JsonResponseModel<GetTagKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTagKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTagKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询标签键列表。
        /// </summary>
        /// <param name="req"><see cref="GetTagKeysRequest"/></param>
        /// <returns><see cref="GetTagKeysResponse"/></returns>
        public GetTagKeysResponse GetTagKeysSync(GetTagKeysRequest req)
        {
             JsonResponseModel<GetTagKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTagKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTagKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req"><see cref="GetTagValuesRequest"/></param>
        /// <returns><see cref="GetTagValuesResponse"/></returns>
        public async Task<GetTagValuesResponse> GetTagValues(GetTagValuesRequest req)
        {
             JsonResponseModel<GetTagValuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTagValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTagValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req"><see cref="GetTagValuesRequest"/></param>
        /// <returns><see cref="GetTagValuesResponse"/></returns>
        public GetTagValuesResponse GetTagValuesSync(GetTagValuesRequest req)
        {
             JsonResponseModel<GetTagValuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTagValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTagValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取已建立的标签列表。
        /// </summary>
        /// <param name="req"><see cref="GetTagsRequest"/></param>
        /// <returns><see cref="GetTagsResponse"/></returns>
        public async Task<GetTagsResponse> GetTags(GetTagsRequest req)
        {
             JsonResponseModel<GetTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取已建立的标签列表。
        /// </summary>
        /// <param name="req"><see cref="GetTagsRequest"/></param>
        /// <returns><see cref="GetTagsResponse"/></returns>
        public GetTagsResponse GetTagsSync(GetTagsRequest req)
        {
             JsonResponseModel<GetTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改资源关联的所有标签
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public async Task<ModifyResourceTagsResponse> ModifyResourceTags(ModifyResourceTagsRequest req)
        {
             JsonResponseModel<ModifyResourceTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourceTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改资源关联的所有标签
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public ModifyResourceTagsResponse ModifyResourceTagsSync(ModifyResourceTagsRequest req)
        {
             JsonResponseModel<ModifyResourceTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourceTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改多个资源关联的某个标签键对应的标签值
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcesTagValueRequest"/></param>
        /// <returns><see cref="ModifyResourcesTagValueResponse"/></returns>
        public async Task<ModifyResourcesTagValueResponse> ModifyResourcesTagValue(ModifyResourcesTagValueRequest req)
        {
             JsonResponseModel<ModifyResourcesTagValueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourcesTagValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourcesTagValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改多个资源关联的某个标签键对应的标签值
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcesTagValueRequest"/></param>
        /// <returns><see cref="ModifyResourcesTagValueResponse"/></returns>
        public ModifyResourcesTagValueResponse ModifyResourcesTagValueSync(ModifyResourcesTagValueRequest req)
        {
             JsonResponseModel<ModifyResourcesTagValueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourcesTagValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourcesTagValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为指定的多个云产品的多个云资源统一创建并绑定标签。
        /// </summary>
        /// <param name="req"><see cref="TagResourcesRequest"/></param>
        /// <returns><see cref="TagResourcesResponse"/></returns>
        public async Task<TagResourcesResponse> TagResources(TagResourcesRequest req)
        {
             JsonResponseModel<TagResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TagResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TagResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为指定的多个云产品的多个云资源统一创建并绑定标签。
        /// </summary>
        /// <param name="req"><see cref="TagResourcesRequest"/></param>
        /// <returns><see cref="TagResourcesResponse"/></returns>
        public TagResourcesResponse TagResourcesSync(TagResourcesRequest req)
        {
             JsonResponseModel<TagResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TagResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TagResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定的多个云产品的多个云资源统一解绑标签。
        /// </summary>
        /// <param name="req"><see cref="UnTagResourcesRequest"/></param>
        /// <returns><see cref="UnTagResourcesResponse"/></returns>
        public async Task<UnTagResourcesResponse> UnTagResources(UnTagResourcesRequest req)
        {
             JsonResponseModel<UnTagResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnTagResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnTagResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定的多个云产品的多个云资源统一解绑标签。
        /// </summary>
        /// <param name="req"><see cref="UnTagResourcesRequest"/></param>
        /// <returns><see cref="UnTagResourcesResponse"/></returns>
        public UnTagResourcesResponse UnTagResourcesSync(UnTagResourcesRequest req)
        {
             JsonResponseModel<UnTagResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnTagResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnTagResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="req"><see cref="UpdateProjectRequest"/></param>
        /// <returns><see cref="UpdateProjectResponse"/></returns>
        public async Task<UpdateProjectResponse> UpdateProject(UpdateProjectRequest req)
        {
             JsonResponseModel<UpdateProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="req"><see cref="UpdateProjectRequest"/></param>
        /// <returns><see cref="UpdateProjectResponse"/></returns>
        public UpdateProjectResponse UpdateProjectSync(UpdateProjectRequest req)
        {
             JsonResponseModel<UpdateProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改资源已关联的标签值（标签键不变）
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceTagValueRequest"/></param>
        /// <returns><see cref="UpdateResourceTagValueResponse"/></returns>
        public async Task<UpdateResourceTagValueResponse> UpdateResourceTagValue(UpdateResourceTagValueRequest req)
        {
             JsonResponseModel<UpdateResourceTagValueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateResourceTagValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateResourceTagValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改资源已关联的标签值（标签键不变）
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceTagValueRequest"/></param>
        /// <returns><see cref="UpdateResourceTagValueResponse"/></returns>
        public UpdateResourceTagValueResponse UpdateResourceTagValueSync(UpdateResourceTagValueRequest req)
        {
             JsonResponseModel<UpdateResourceTagValueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateResourceTagValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateResourceTagValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
