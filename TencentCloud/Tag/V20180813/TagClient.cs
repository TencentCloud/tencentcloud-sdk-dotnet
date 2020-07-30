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
        /// 用于查询已有资源标签键值对
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
        /// 用于查询已有资源标签键值对
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
