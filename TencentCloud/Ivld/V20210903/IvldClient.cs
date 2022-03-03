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

namespace TencentCloud.Ivld.V20210903
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ivld.V20210903.Models;

   public class IvldClient : AbstractClient{

       private const string endpoint = "ivld.tencentcloudapi.com";
       private const string version = "2021-09-03";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IvldClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IvldClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 增加自定义人脸图片，每个自定义人物最多可包含10张人脸图片
        /// 
        /// 请注意，与创建自定义人物一样，图片数据优先级优于图片URL优先级
        /// </summary>
        /// <param name="req"><see cref="AddCustomPersonImageRequest"/></param>
        /// <returns><see cref="AddCustomPersonImageResponse"/></returns>
        public async Task<AddCustomPersonImageResponse> AddCustomPersonImage(AddCustomPersonImageRequest req)
        {
             JsonResponseModel<AddCustomPersonImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddCustomPersonImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCustomPersonImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加自定义人脸图片，每个自定义人物最多可包含10张人脸图片
        /// 
        /// 请注意，与创建自定义人物一样，图片数据优先级优于图片URL优先级
        /// </summary>
        /// <param name="req"><see cref="AddCustomPersonImageRequest"/></param>
        /// <returns><see cref="AddCustomPersonImageResponse"/></returns>
        public AddCustomPersonImageResponse AddCustomPersonImageSync(AddCustomPersonImageRequest req)
        {
             JsonResponseModel<AddCustomPersonImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddCustomPersonImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCustomPersonImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义人物分类信息
        /// 
        /// 当L2Category为空时，将创建一级自定义分类。
        /// 当L1Category与L2Category均不为空时，将创建二级自定义分类。请注意，**只有当一级自定义分类存在时，才可创建二级自定义分类**。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomCategoryRequest"/></param>
        /// <returns><see cref="CreateCustomCategoryResponse"/></returns>
        public async Task<CreateCustomCategoryResponse> CreateCustomCategory(CreateCustomCategoryRequest req)
        {
             JsonResponseModel<CreateCustomCategoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomCategory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomCategoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义人物分类信息
        /// 
        /// 当L2Category为空时，将创建一级自定义分类。
        /// 当L1Category与L2Category均不为空时，将创建二级自定义分类。请注意，**只有当一级自定义分类存在时，才可创建二级自定义分类**。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomCategoryRequest"/></param>
        /// <returns><see cref="CreateCustomCategoryResponse"/></returns>
        public CreateCustomCategoryResponse CreateCustomCategorySync(CreateCustomCategoryRequest req)
        {
             JsonResponseModel<CreateCustomCategoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomCategory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomCategoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义人物库
        /// 
        /// Bucket的格式参考为 `bucketName-123456.cos.ap-shanghai.myqcloud.com`
        /// 
        /// 在调用CreateCustomPerson和AddCustomPersonImage接口之前，请先确保本接口成功调用。当前每个用户只支持一个自定义人物库，一旦自定义人物库创建成功，后续接口调用均会返回人物库已存在错误。
        /// 
        /// 由于人脸图片对于自定义人物识别至关重要，因此自定义人物识别功能需要用户显式指定COS存储桶方可使用。具体来说，自定义人物识别功能接口(主要是CreateCustomPerson和AddCustomPersonImage)会在此COS桶下面新建IVLDCustomPersonImage目录，并在此目录下存储自定义人物图片数据以支持后续潜在的特征更新。
        /// 
        /// 请注意：本接口指定的COS桶仅用于**备份存储自定义人物图片**，CreateCustomPerson和AddCustomPersonImage接口入参URL可使用任意COS存储桶下的任意图片。
        /// 
        /// **重要**：请务必确保本接口指定的COS存储桶存在(不要手动删除COS桶)。COS存储桶一旦指定，将不能修改。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomGroupRequest"/></param>
        /// <returns><see cref="CreateCustomGroupResponse"/></returns>
        public async Task<CreateCustomGroupResponse> CreateCustomGroup(CreateCustomGroupRequest req)
        {
             JsonResponseModel<CreateCustomGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义人物库
        /// 
        /// Bucket的格式参考为 `bucketName-123456.cos.ap-shanghai.myqcloud.com`
        /// 
        /// 在调用CreateCustomPerson和AddCustomPersonImage接口之前，请先确保本接口成功调用。当前每个用户只支持一个自定义人物库，一旦自定义人物库创建成功，后续接口调用均会返回人物库已存在错误。
        /// 
        /// 由于人脸图片对于自定义人物识别至关重要，因此自定义人物识别功能需要用户显式指定COS存储桶方可使用。具体来说，自定义人物识别功能接口(主要是CreateCustomPerson和AddCustomPersonImage)会在此COS桶下面新建IVLDCustomPersonImage目录，并在此目录下存储自定义人物图片数据以支持后续潜在的特征更新。
        /// 
        /// 请注意：本接口指定的COS桶仅用于**备份存储自定义人物图片**，CreateCustomPerson和AddCustomPersonImage接口入参URL可使用任意COS存储桶下的任意图片。
        /// 
        /// **重要**：请务必确保本接口指定的COS存储桶存在(不要手动删除COS桶)。COS存储桶一旦指定，将不能修改。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomGroupRequest"/></param>
        /// <returns><see cref="CreateCustomGroupResponse"/></returns>
        public CreateCustomGroupResponse CreateCustomGroupSync(CreateCustomGroupRequest req)
        {
             JsonResponseModel<CreateCustomGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义人物。
        /// 
        /// 输入人物名称，基本信息，分类信息与人脸图片，创建自定义人物
        /// 
        /// 人脸图片可使用图片数据(base64编码的图片数据)或者图片URL(推荐使用COS以减少下载时间，其他地址也支持)，原始图片优先，也即如果同时指定了图片数据和图片URL，接口将仅使用图片数据
        /// </summary>
        /// <param name="req"><see cref="CreateCustomPersonRequest"/></param>
        /// <returns><see cref="CreateCustomPersonResponse"/></returns>
        public async Task<CreateCustomPersonResponse> CreateCustomPerson(CreateCustomPersonRequest req)
        {
             JsonResponseModel<CreateCustomPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义人物。
        /// 
        /// 输入人物名称，基本信息，分类信息与人脸图片，创建自定义人物
        /// 
        /// 人脸图片可使用图片数据(base64编码的图片数据)或者图片URL(推荐使用COS以减少下载时间，其他地址也支持)，原始图片优先，也即如果同时指定了图片数据和图片URL，接口将仅使用图片数据
        /// </summary>
        /// <param name="req"><see cref="CreateCustomPersonRequest"/></param>
        /// <returns><see cref="CreateCustomPersonResponse"/></returns>
        public CreateCustomPersonResponse CreateCustomPersonSync(CreateCustomPersonRequest req)
        {
             JsonResponseModel<CreateCustomPersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建默认自定义人物类型
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultCategoriesRequest"/></param>
        /// <returns><see cref="CreateDefaultCategoriesResponse"/></returns>
        public async Task<CreateDefaultCategoriesResponse> CreateDefaultCategories(CreateDefaultCategoriesRequest req)
        {
             JsonResponseModel<CreateDefaultCategoriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDefaultCategories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultCategoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建默认自定义人物类型
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultCategoriesRequest"/></param>
        /// <returns><see cref="CreateDefaultCategoriesResponse"/></returns>
        public CreateDefaultCategoriesResponse CreateDefaultCategoriesSync(CreateDefaultCategoriesRequest req)
        {
             JsonResponseModel<CreateDefaultCategoriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDefaultCategories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultCategoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建智能标签任务。
        /// 
        /// 请注意，本接口为异步接口，**返回TaskId只代表任务创建成功，不代表任务执行成功**。
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public async Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建智能标签任务。
        /// 
        /// 请注意，本接口为异步接口，**返回TaskId只代表任务创建成功，不代表任务执行成功**。
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义分类信息
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomCategoryRequest"/></param>
        /// <returns><see cref="DeleteCustomCategoryResponse"/></returns>
        public async Task<DeleteCustomCategoryResponse> DeleteCustomCategory(DeleteCustomCategoryRequest req)
        {
             JsonResponseModel<DeleteCustomCategoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomCategory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomCategoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义分类信息
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomCategoryRequest"/></param>
        /// <returns><see cref="DeleteCustomCategoryResponse"/></returns>
        public DeleteCustomCategoryResponse DeleteCustomCategorySync(DeleteCustomCategoryRequest req)
        {
             JsonResponseModel<DeleteCustomCategoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCustomCategory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomCategoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义人物
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomPersonRequest"/></param>
        /// <returns><see cref="DeleteCustomPersonResponse"/></returns>
        public async Task<DeleteCustomPersonResponse> DeleteCustomPerson(DeleteCustomPersonRequest req)
        {
             JsonResponseModel<DeleteCustomPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义人物
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomPersonRequest"/></param>
        /// <returns><see cref="DeleteCustomPersonResponse"/></returns>
        public DeleteCustomPersonResponse DeleteCustomPersonSync(DeleteCustomPersonRequest req)
        {
             JsonResponseModel<DeleteCustomPersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCustomPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义人脸数据
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomPersonImageRequest"/></param>
        /// <returns><see cref="DeleteCustomPersonImageResponse"/></returns>
        public async Task<DeleteCustomPersonImageResponse> DeleteCustomPersonImage(DeleteCustomPersonImageRequest req)
        {
             JsonResponseModel<DeleteCustomPersonImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomPersonImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomPersonImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义人脸数据
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomPersonImageRequest"/></param>
        /// <returns><see cref="DeleteCustomPersonImageResponse"/></returns>
        public DeleteCustomPersonImageResponse DeleteCustomPersonImageSync(DeleteCustomPersonImageRequest req)
        {
             JsonResponseModel<DeleteCustomPersonImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCustomPersonImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomPersonImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将MediaId对应的媒资文件从系统中删除。
        /// 
        /// **请注意，本接口仅删除媒资文件，媒资文件对应的视频分析结果不会被删除**。如您需要删除结构化分析结果，请调用DeleteTask接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaRequest"/></param>
        /// <returns><see cref="DeleteMediaResponse"/></returns>
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
        /// 将MediaId对应的媒资文件从系统中删除。
        /// 
        /// **请注意，本接口仅删除媒资文件，媒资文件对应的视频分析结果不会被删除**。如您需要删除结构化分析结果，请调用DeleteTask接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaRequest"/></param>
        /// <returns><see cref="DeleteMediaResponse"/></returns>
        public DeleteMediaResponse DeleteMediaSync(DeleteMediaRequest req)
        {
             JsonResponseModel<DeleteMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务信息
        /// 
        /// 请注意，本接口**不会**删除媒资文件
        /// 
        /// 只有已完成(成功或者失败)的任务可以删除，**正在执行中的任务不支持删除**
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public async Task<DeleteTaskResponse> DeleteTask(DeleteTaskRequest req)
        {
             JsonResponseModel<DeleteTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务信息
        /// 
        /// 请注意，本接口**不会**删除媒资文件
        /// 
        /// 只有已完成(成功或者失败)的任务可以删除，**正在执行中的任务不支持删除**
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public DeleteTaskResponse DeleteTaskSync(DeleteTaskRequest req)
        {
             JsonResponseModel<DeleteTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量描述自定义人物分类信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomCategoriesRequest"/></param>
        /// <returns><see cref="DescribeCustomCategoriesResponse"/></returns>
        public async Task<DescribeCustomCategoriesResponse> DescribeCustomCategories(DescribeCustomCategoriesRequest req)
        {
             JsonResponseModel<DescribeCustomCategoriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomCategories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomCategoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量描述自定义人物分类信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomCategoriesRequest"/></param>
        /// <returns><see cref="DescribeCustomCategoriesResponse"/></returns>
        public DescribeCustomCategoriesResponse DescribeCustomCategoriesSync(DescribeCustomCategoriesRequest req)
        {
             JsonResponseModel<DescribeCustomCategoriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomCategories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomCategoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述自定义人物库信息，当前库大小(库中有多少人脸)，以及库中的存储桶
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomGroupRequest"/></param>
        /// <returns><see cref="DescribeCustomGroupResponse"/></returns>
        public async Task<DescribeCustomGroupResponse> DescribeCustomGroup(DescribeCustomGroupRequest req)
        {
             JsonResponseModel<DescribeCustomGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述自定义人物库信息，当前库大小(库中有多少人脸)，以及库中的存储桶
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomGroupRequest"/></param>
        /// <returns><see cref="DescribeCustomGroupResponse"/></returns>
        public DescribeCustomGroupResponse DescribeCustomGroupSync(DescribeCustomGroupRequest req)
        {
             JsonResponseModel<DescribeCustomGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述自定义人物详细信息，包括人物信息与人物信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomPersonDetailRequest"/></param>
        /// <returns><see cref="DescribeCustomPersonDetailResponse"/></returns>
        public async Task<DescribeCustomPersonDetailResponse> DescribeCustomPersonDetail(DescribeCustomPersonDetailRequest req)
        {
             JsonResponseModel<DescribeCustomPersonDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomPersonDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomPersonDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述自定义人物详细信息，包括人物信息与人物信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomPersonDetailRequest"/></param>
        /// <returns><see cref="DescribeCustomPersonDetailResponse"/></returns>
        public DescribeCustomPersonDetailResponse DescribeCustomPersonDetailSync(DescribeCustomPersonDetailRequest req)
        {
             JsonResponseModel<DescribeCustomPersonDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomPersonDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomPersonDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量描述自定义人物
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomPersonsRequest"/></param>
        /// <returns><see cref="DescribeCustomPersonsResponse"/></returns>
        public async Task<DescribeCustomPersonsResponse> DescribeCustomPersons(DescribeCustomPersonsRequest req)
        {
             JsonResponseModel<DescribeCustomPersonsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomPersons");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomPersonsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量描述自定义人物
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomPersonsRequest"/></param>
        /// <returns><see cref="DescribeCustomPersonsResponse"/></returns>
        public DescribeCustomPersonsResponse DescribeCustomPersonsSync(DescribeCustomPersonsRequest req)
        {
             JsonResponseModel<DescribeCustomPersonsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomPersons");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomPersonsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述媒资文件信息，包括媒资状态，分辨率，帧率等。
        /// 
        /// 如果媒资文件未完成导入，本接口将仅输出媒资文件的状态信息；导入完成后，本接口还将输出媒资文件的其他元信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaRequest"/></param>
        /// <returns><see cref="DescribeMediaResponse"/></returns>
        public async Task<DescribeMediaResponse> DescribeMedia(DescribeMediaRequest req)
        {
             JsonResponseModel<DescribeMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述媒资文件信息，包括媒资状态，分辨率，帧率等。
        /// 
        /// 如果媒资文件未完成导入，本接口将仅输出媒资文件的状态信息；导入完成后，本接口还将输出媒资文件的其他元信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaRequest"/></param>
        /// <returns><see cref="DescribeMediaResponse"/></returns>
        public DescribeMediaResponse DescribeMediaSync(DescribeMediaRequest req)
        {
             JsonResponseModel<DescribeMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依照输入条件，描述命中的媒资文件信息，包括媒资状态，分辨率，帧率等。
        /// 
        /// 请注意，本接口最多支持同时描述**50**个媒资文件
        /// 
        /// 如果媒资文件未完成导入，本接口将仅输出媒资文件的状态信息；导入完成后，本接口还将输出媒资文件的其他元信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediasRequest"/></param>
        /// <returns><see cref="DescribeMediasResponse"/></returns>
        public async Task<DescribeMediasResponse> DescribeMedias(DescribeMediasRequest req)
        {
             JsonResponseModel<DescribeMediasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMedias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依照输入条件，描述命中的媒资文件信息，包括媒资状态，分辨率，帧率等。
        /// 
        /// 请注意，本接口最多支持同时描述**50**个媒资文件
        /// 
        /// 如果媒资文件未完成导入，本接口将仅输出媒资文件的状态信息；导入完成后，本接口还将输出媒资文件的其他元信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediasRequest"/></param>
        /// <returns><see cref="DescribeMediasResponse"/></returns>
        public DescribeMediasResponse DescribeMediasSync(DescribeMediasRequest req)
        {
             JsonResponseModel<DescribeMediasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMedias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述智能标签任务进度。
        /// 
        /// 请注意，**此接口仅返回任务执行状态信息，不返回任务执行结果**
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public async Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
             JsonResponseModel<DescribeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述智能标签任务进度。
        /// 
        /// 请注意，**此接口仅返回任务执行状态信息，不返回任务执行结果**
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public DescribeTaskResponse DescribeTaskSync(DescribeTaskRequest req)
        {
             JsonResponseModel<DescribeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述任务信息，如果任务成功完成，还将返回任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述任务信息，如果任务成功完成，还将返回任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依照输入条件，描述命中的任务信息，包括任务创建时间，处理时间信息等。
        /// 
        /// 请注意，本接口最多支持同时描述**50**个任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依照输入条件，描述命中的任务信息，包括任务创建时间，处理时间信息等。
        /// 
        /// 请注意，本接口最多支持同时描述**50**个任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将URL指向的媒资视频文件导入系统之中。
        /// 
        /// **请注意，本接口为异步接口**。接口返回MediaId仅代表导入视频任务发起，不代表任务完成，您可调用读接口(DescribeMedia/DescribeMedias)接口查询MediaId对应的媒资文件的状态。
        /// 
        /// 当前URL只支持COS地址，其形式为`https://${Bucket}-${AppId}.cos.${Region}.myqcloud.com/${ObjectKey}`，其中`${Bucket}`为您的COS桶名称，Region为COS桶所在[可用区](https://cloud.tencent.com/document/product/213/6091)，`${ObjectKey}`为指向存储在COS桶内的待分析的视频的[ObjectKey](https://cloud.tencent.com/document/product/436/13324)
        /// 
        /// 分析完成后，本产品将在您的`${Bucket}`桶内创建名为`${ObjectKey}-${task-start-time}`的目录(`task-start-time`形式为1970-01-01T08:08:08)并将分析结果将回传回该目录，也即，结构化分析结果(包括图片，JSON等数据)将会写回`https://${Bucket}-${AppId}.cos.${Region}.myqcloud.com/${ObjectKey}-${task-start-time}`目录
        /// </summary>
        /// <param name="req"><see cref="ImportMediaRequest"/></param>
        /// <returns><see cref="ImportMediaResponse"/></returns>
        public async Task<ImportMediaResponse> ImportMedia(ImportMediaRequest req)
        {
             JsonResponseModel<ImportMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将URL指向的媒资视频文件导入系统之中。
        /// 
        /// **请注意，本接口为异步接口**。接口返回MediaId仅代表导入视频任务发起，不代表任务完成，您可调用读接口(DescribeMedia/DescribeMedias)接口查询MediaId对应的媒资文件的状态。
        /// 
        /// 当前URL只支持COS地址，其形式为`https://${Bucket}-${AppId}.cos.${Region}.myqcloud.com/${ObjectKey}`，其中`${Bucket}`为您的COS桶名称，Region为COS桶所在[可用区](https://cloud.tencent.com/document/product/213/6091)，`${ObjectKey}`为指向存储在COS桶内的待分析的视频的[ObjectKey](https://cloud.tencent.com/document/product/436/13324)
        /// 
        /// 分析完成后，本产品将在您的`${Bucket}`桶内创建名为`${ObjectKey}-${task-start-time}`的目录(`task-start-time`形式为1970-01-01T08:08:08)并将分析结果将回传回该目录，也即，结构化分析结果(包括图片，JSON等数据)将会写回`https://${Bucket}-${AppId}.cos.${Region}.myqcloud.com/${ObjectKey}-${task-start-time}`目录
        /// </summary>
        /// <param name="req"><see cref="ImportMediaRequest"/></param>
        /// <returns><see cref="ImportMediaResponse"/></returns>
        public ImportMediaResponse ImportMediaSync(ImportMediaRequest req)
        {
             JsonResponseModel<ImportMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户设置对应事件的回调地址
        /// 
        /// ### 回调事件消息通知协议
        /// 
        /// #### 网络协议
        /// - 回调接口协议目前仅支持http/https协议；
        /// - 请求：HTTP POST 请求，包体内容为 JSON，每一种消息的具体包体内容参见后文。
        /// - 应答：HTTP STATUS CODE = 200，服务端忽略应答包具体内容，为了协议友好，建议客户应答内容携带 JSON： `{"code":0}`
        /// 
        /// #### 通知可靠性
        /// 
        /// 事件通知服务具备重试能力，事件通知失败后会总计重试3次；
        /// 为了避免重试对您的服务器以及网络带宽造成冲击，请保持正常回包。触发重试条件如下：
        /// - 长时间（20 秒）未回包应答。
        /// - 应答 HTTP STATUS 不为200。
        /// 
        /// 
        /// #### 回调接口协议
        /// 
        /// ##### 分析任务完成消息回调
        /// | 参数名称 | 必选 | 类型 | 描述 |
        /// |---------|---------|---------|---------|
        /// | EventType | 是 | int | 回调时间类型，1-任务分析完成，2-媒资导入完成 |
        /// | TaskId | 是 | String | 任务ID |
        /// | TaskStatus | 是 | [TaskStatus](/document/product/1611/63373?!preview&preview_docmenu=1&lang=cn&!document=1#TaskStatus) | 任务执行状态 |
        /// | FailedReason | 是 | String | 若任务失败，该字段为失败原因 |
        /// 
        /// 
        /// ##### 导入媒资完成消息回调
        /// | 参数名称 | 必选 | 类型 | 描述 |
        /// |---------|---------|---------|---------|
        /// | EventType | 是 | int | 回调时间类型，1-任务分析完成，2-媒资导入完成 |
        /// | MediaId | 是 | String | 媒资ID |
        /// | MediaStatus | 是 | [MediaStatus](/document/product/1611/63373?!preview&preview_docmenu=1&lang=cn&!document=1#MediaStatus) | 媒资导入状态|
        /// | FailedReason | 是 | String | 若任务失败，该字段为失败原因 |
        /// </summary>
        /// <param name="req"><see cref="ModifyCallbackRequest"/></param>
        /// <returns><see cref="ModifyCallbackResponse"/></returns>
        public async Task<ModifyCallbackResponse> ModifyCallback(ModifyCallbackRequest req)
        {
             JsonResponseModel<ModifyCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户设置对应事件的回调地址
        /// 
        /// ### 回调事件消息通知协议
        /// 
        /// #### 网络协议
        /// - 回调接口协议目前仅支持http/https协议；
        /// - 请求：HTTP POST 请求，包体内容为 JSON，每一种消息的具体包体内容参见后文。
        /// - 应答：HTTP STATUS CODE = 200，服务端忽略应答包具体内容，为了协议友好，建议客户应答内容携带 JSON： `{"code":0}`
        /// 
        /// #### 通知可靠性
        /// 
        /// 事件通知服务具备重试能力，事件通知失败后会总计重试3次；
        /// 为了避免重试对您的服务器以及网络带宽造成冲击，请保持正常回包。触发重试条件如下：
        /// - 长时间（20 秒）未回包应答。
        /// - 应答 HTTP STATUS 不为200。
        /// 
        /// 
        /// #### 回调接口协议
        /// 
        /// ##### 分析任务完成消息回调
        /// | 参数名称 | 必选 | 类型 | 描述 |
        /// |---------|---------|---------|---------|
        /// | EventType | 是 | int | 回调时间类型，1-任务分析完成，2-媒资导入完成 |
        /// | TaskId | 是 | String | 任务ID |
        /// | TaskStatus | 是 | [TaskStatus](/document/product/1611/63373?!preview&preview_docmenu=1&lang=cn&!document=1#TaskStatus) | 任务执行状态 |
        /// | FailedReason | 是 | String | 若任务失败，该字段为失败原因 |
        /// 
        /// 
        /// ##### 导入媒资完成消息回调
        /// | 参数名称 | 必选 | 类型 | 描述 |
        /// |---------|---------|---------|---------|
        /// | EventType | 是 | int | 回调时间类型，1-任务分析完成，2-媒资导入完成 |
        /// | MediaId | 是 | String | 媒资ID |
        /// | MediaStatus | 是 | [MediaStatus](/document/product/1611/63373?!preview&preview_docmenu=1&lang=cn&!document=1#MediaStatus) | 媒资导入状态|
        /// | FailedReason | 是 | String | 若任务失败，该字段为失败原因 |
        /// </summary>
        /// <param name="req"><see cref="ModifyCallbackRequest"/></param>
        /// <returns><see cref="ModifyCallbackResponse"/></returns>
        public ModifyCallbackResponse ModifyCallbackSync(ModifyCallbackRequest req)
        {
             JsonResponseModel<ModifyCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户回调设置
        /// </summary>
        /// <param name="req"><see cref="QueryCallbackRequest"/></param>
        /// <returns><see cref="QueryCallbackResponse"/></returns>
        public async Task<QueryCallbackResponse> QueryCallback(QueryCallbackRequest req)
        {
             JsonResponseModel<QueryCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户回调设置
        /// </summary>
        /// <param name="req"><see cref="QueryCallbackRequest"/></param>
        /// <returns><see cref="QueryCallbackResponse"/></returns>
        public QueryCallbackResponse QueryCallbackSync(QueryCallbackRequest req)
        {
             JsonResponseModel<QueryCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新自定义人物分类
        /// 
        /// 当L2Category为空时，代表更新CategoryId对应的一级自定义人物类型以及所有二级自定义人物类型所从属的一级自定义人物类型；
        /// 当L2Category非空时，仅更新CategoryId对应的二级自定义人物类型
        /// </summary>
        /// <param name="req"><see cref="UpdateCustomCategoryRequest"/></param>
        /// <returns><see cref="UpdateCustomCategoryResponse"/></returns>
        public async Task<UpdateCustomCategoryResponse> UpdateCustomCategory(UpdateCustomCategoryRequest req)
        {
             JsonResponseModel<UpdateCustomCategoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCustomCategory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCustomCategoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新自定义人物分类
        /// 
        /// 当L2Category为空时，代表更新CategoryId对应的一级自定义人物类型以及所有二级自定义人物类型所从属的一级自定义人物类型；
        /// 当L2Category非空时，仅更新CategoryId对应的二级自定义人物类型
        /// </summary>
        /// <param name="req"><see cref="UpdateCustomCategoryRequest"/></param>
        /// <returns><see cref="UpdateCustomCategoryResponse"/></returns>
        public UpdateCustomCategoryResponse UpdateCustomCategorySync(UpdateCustomCategoryRequest req)
        {
             JsonResponseModel<UpdateCustomCategoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCustomCategory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCustomCategoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新自定义人物信息，包括姓名，简要信息，分类信息等
        /// </summary>
        /// <param name="req"><see cref="UpdateCustomPersonRequest"/></param>
        /// <returns><see cref="UpdateCustomPersonResponse"/></returns>
        public async Task<UpdateCustomPersonResponse> UpdateCustomPerson(UpdateCustomPersonRequest req)
        {
             JsonResponseModel<UpdateCustomPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCustomPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCustomPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新自定义人物信息，包括姓名，简要信息，分类信息等
        /// </summary>
        /// <param name="req"><see cref="UpdateCustomPersonRequest"/></param>
        /// <returns><see cref="UpdateCustomPersonResponse"/></returns>
        public UpdateCustomPersonResponse UpdateCustomPersonSync(UpdateCustomPersonRequest req)
        {
             JsonResponseModel<UpdateCustomPersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCustomPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCustomPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
