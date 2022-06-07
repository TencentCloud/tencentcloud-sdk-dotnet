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

namespace TencentCloud.Tione.V20211111
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tione.V20211111.Models;

   public class TioneClient : AbstractClient{

       private const string endpoint = "tione.tencentcloudapi.com";
       private const string version = "2021-11-11";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TioneClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TioneClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建数据集
        /// </summary>
        /// <param name="req"><see cref="CreateDatasetRequest"/></param>
        /// <returns><see cref="CreateDatasetResponse"/></returns>
        public async Task<CreateDatasetResponse> CreateDataset(CreateDatasetRequest req)
        {
             JsonResponseModel<CreateDatasetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDataset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatasetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建数据集
        /// </summary>
        /// <param name="req"><see cref="CreateDatasetRequest"/></param>
        /// <returns><see cref="CreateDatasetResponse"/></returns>
        public CreateDatasetResponse CreateDatasetSync(CreateDatasetRequest req)
        {
             JsonResponseModel<CreateDatasetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDataset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatasetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入模型
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingModelRequest"/></param>
        /// <returns><see cref="CreateTrainingModelResponse"/></returns>
        public async Task<CreateTrainingModelResponse> CreateTrainingModel(CreateTrainingModelRequest req)
        {
             JsonResponseModel<CreateTrainingModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTrainingModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrainingModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入模型
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingModelRequest"/></param>
        /// <returns><see cref="CreateTrainingModelResponse"/></returns>
        public CreateTrainingModelResponse CreateTrainingModelSync(CreateTrainingModelRequest req)
        {
             JsonResponseModel<CreateTrainingModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTrainingModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrainingModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建模型训练任务
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingTaskRequest"/></param>
        /// <returns><see cref="CreateTrainingTaskResponse"/></returns>
        public async Task<CreateTrainingTaskResponse> CreateTrainingTask(CreateTrainingTaskRequest req)
        {
             JsonResponseModel<CreateTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建模型训练任务
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingTaskRequest"/></param>
        /// <returns><see cref="CreateTrainingTaskResponse"/></returns>
        public CreateTrainingTaskResponse CreateTrainingTaskSync(CreateTrainingTaskRequest req)
        {
             JsonResponseModel<CreateTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除数据集
        /// </summary>
        /// <param name="req"><see cref="DeleteDatasetRequest"/></param>
        /// <returns><see cref="DeleteDatasetResponse"/></returns>
        public async Task<DeleteDatasetResponse> DeleteDataset(DeleteDatasetRequest req)
        {
             JsonResponseModel<DeleteDatasetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDataset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDatasetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除数据集
        /// </summary>
        /// <param name="req"><see cref="DeleteDatasetRequest"/></param>
        /// <returns><see cref="DeleteDatasetResponse"/></returns>
        public DeleteDatasetResponse DeleteDatasetSync(DeleteDatasetRequest req)
        {
             JsonResponseModel<DeleteDatasetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDataset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDatasetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除模型
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingModelRequest"/></param>
        /// <returns><see cref="DeleteTrainingModelResponse"/></returns>
        public async Task<DeleteTrainingModelResponse> DeleteTrainingModel(DeleteTrainingModelRequest req)
        {
             JsonResponseModel<DeleteTrainingModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTrainingModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrainingModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除模型
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingModelRequest"/></param>
        /// <returns><see cref="DeleteTrainingModelResponse"/></returns>
        public DeleteTrainingModelResponse DeleteTrainingModelSync(DeleteTrainingModelRequest req)
        {
             JsonResponseModel<DeleteTrainingModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTrainingModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrainingModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除模型版本
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingModelVersionRequest"/></param>
        /// <returns><see cref="DeleteTrainingModelVersionResponse"/></returns>
        public async Task<DeleteTrainingModelVersionResponse> DeleteTrainingModelVersion(DeleteTrainingModelVersionRequest req)
        {
             JsonResponseModel<DeleteTrainingModelVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTrainingModelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrainingModelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除模型版本
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingModelVersionRequest"/></param>
        /// <returns><see cref="DeleteTrainingModelVersionResponse"/></returns>
        public DeleteTrainingModelVersionResponse DeleteTrainingModelVersionSync(DeleteTrainingModelVersionRequest req)
        {
             JsonResponseModel<DeleteTrainingModelVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTrainingModelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrainingModelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除训练任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingTaskRequest"/></param>
        /// <returns><see cref="DeleteTrainingTaskResponse"/></returns>
        public async Task<DeleteTrainingTaskResponse> DeleteTrainingTask(DeleteTrainingTaskRequest req)
        {
             JsonResponseModel<DeleteTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除训练任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingTaskRequest"/></param>
        /// <returns><see cref="DeleteTrainingTaskResponse"/></returns>
        public DeleteTrainingTaskResponse DeleteTrainingTaskSync(DeleteTrainingTaskRequest req)
        {
             JsonResponseModel<DeleteTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupsRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupsResponse"/></returns>
        public async Task<DescribeBillingResourceGroupsResponse> DescribeBillingResourceGroups(DescribeBillingResourceGroupsRequest req)
        {
             JsonResponseModel<DescribeBillingResourceGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillingResourceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingResourceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupsRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupsResponse"/></returns>
        public DescribeBillingResourceGroupsResponse DescribeBillingResourceGroupsSync(DescribeBillingResourceGroupsRequest req)
        {
             JsonResponseModel<DescribeBillingResourceGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillingResourceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingResourceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBillingSpecsPrice)用于查询计费项价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingSpecsPriceRequest"/></param>
        /// <returns><see cref="DescribeBillingSpecsPriceResponse"/></returns>
        public async Task<DescribeBillingSpecsPriceResponse> DescribeBillingSpecsPrice(DescribeBillingSpecsPriceRequest req)
        {
             JsonResponseModel<DescribeBillingSpecsPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillingSpecsPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingSpecsPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBillingSpecsPrice)用于查询计费项价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingSpecsPriceRequest"/></param>
        /// <returns><see cref="DescribeBillingSpecsPriceResponse"/></returns>
        public DescribeBillingSpecsPriceResponse DescribeBillingSpecsPriceSync(DescribeBillingSpecsPriceRequest req)
        {
             JsonResponseModel<DescribeBillingSpecsPriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillingSpecsPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingSpecsPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询结构化数据集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetDetailStructuredRequest"/></param>
        /// <returns><see cref="DescribeDatasetDetailStructuredResponse"/></returns>
        public async Task<DescribeDatasetDetailStructuredResponse> DescribeDatasetDetailStructured(DescribeDatasetDetailStructuredRequest req)
        {
             JsonResponseModel<DescribeDatasetDetailStructuredResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatasetDetailStructured");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasetDetailStructuredResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询结构化数据集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetDetailStructuredRequest"/></param>
        /// <returns><see cref="DescribeDatasetDetailStructuredResponse"/></returns>
        public DescribeDatasetDetailStructuredResponse DescribeDatasetDetailStructuredSync(DescribeDatasetDetailStructuredRequest req)
        {
             JsonResponseModel<DescribeDatasetDetailStructuredResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatasetDetailStructured");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasetDetailStructuredResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询非结构化数据集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetDetailUnstructuredRequest"/></param>
        /// <returns><see cref="DescribeDatasetDetailUnstructuredResponse"/></returns>
        public async Task<DescribeDatasetDetailUnstructuredResponse> DescribeDatasetDetailUnstructured(DescribeDatasetDetailUnstructuredRequest req)
        {
             JsonResponseModel<DescribeDatasetDetailUnstructuredResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatasetDetailUnstructured");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasetDetailUnstructuredResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询非结构化数据集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetDetailUnstructuredRequest"/></param>
        /// <returns><see cref="DescribeDatasetDetailUnstructuredResponse"/></returns>
        public DescribeDatasetDetailUnstructuredResponse DescribeDatasetDetailUnstructuredSync(DescribeDatasetDetailUnstructuredRequest req)
        {
             JsonResponseModel<DescribeDatasetDetailUnstructuredResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatasetDetailUnstructured");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasetDetailUnstructuredResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据集列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetsRequest"/></param>
        /// <returns><see cref="DescribeDatasetsResponse"/></returns>
        public async Task<DescribeDatasetsResponse> DescribeDatasets(DescribeDatasetsRequest req)
        {
             JsonResponseModel<DescribeDatasetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatasets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据集列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetsRequest"/></param>
        /// <returns><see cref="DescribeDatasetsResponse"/></returns>
        public DescribeDatasetsResponse DescribeDatasetsSync(DescribeDatasetsRequest req)
        {
             JsonResponseModel<DescribeDatasetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatasets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询推理镜像模板
        /// </summary>
        /// <param name="req"><see cref="DescribeInferTemplatesRequest"/></param>
        /// <returns><see cref="DescribeInferTemplatesResponse"/></returns>
        public async Task<DescribeInferTemplatesResponse> DescribeInferTemplates(DescribeInferTemplatesRequest req)
        {
             JsonResponseModel<DescribeInferTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInferTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInferTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询推理镜像模板
        /// </summary>
        /// <param name="req"><see cref="DescribeInferTemplatesRequest"/></param>
        /// <returns><see cref="DescribeInferTemplatesResponse"/></returns>
        public DescribeInferTemplatesResponse DescribeInferTemplatesSync(DescribeInferTemplatesRequest req)
        {
             JsonResponseModel<DescribeInferTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInferTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInferTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最近上报的训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="DescribeLatestTrainingMetricsRequest"/></param>
        /// <returns><see cref="DescribeLatestTrainingMetricsResponse"/></returns>
        public async Task<DescribeLatestTrainingMetricsResponse> DescribeLatestTrainingMetrics(DescribeLatestTrainingMetricsRequest req)
        {
             JsonResponseModel<DescribeLatestTrainingMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLatestTrainingMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLatestTrainingMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最近上报的训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="DescribeLatestTrainingMetricsRequest"/></param>
        /// <returns><see cref="DescribeLatestTrainingMetricsResponse"/></returns>
        public DescribeLatestTrainingMetricsResponse DescribeLatestTrainingMetricsSync(DescribeLatestTrainingMetricsRequest req)
        {
             JsonResponseModel<DescribeLatestTrainingMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLatestTrainingMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLatestTrainingMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取训练、推理、Notebook服务的日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public async Task<DescribeLogsResponse> DescribeLogs(DescribeLogsRequest req)
        {
             JsonResponseModel<DescribeLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取训练、推理、Notebook服务的日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public DescribeLogsResponse DescribeLogsSync(DescribeLogsRequest req)
        {
             JsonResponseModel<DescribeLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练框架列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingFrameworksRequest"/></param>
        /// <returns><see cref="DescribeTrainingFrameworksResponse"/></returns>
        public async Task<DescribeTrainingFrameworksResponse> DescribeTrainingFrameworks(DescribeTrainingFrameworksRequest req)
        {
             JsonResponseModel<DescribeTrainingFrameworksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingFrameworks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingFrameworksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练框架列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingFrameworksRequest"/></param>
        /// <returns><see cref="DescribeTrainingFrameworksResponse"/></returns>
        public DescribeTrainingFrameworksResponse DescribeTrainingFrameworksSync(DescribeTrainingFrameworksRequest req)
        {
             JsonResponseModel<DescribeTrainingFrameworksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingFrameworks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingFrameworksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingMetricsRequest"/></param>
        /// <returns><see cref="DescribeTrainingMetricsResponse"/></returns>
        public async Task<DescribeTrainingMetricsResponse> DescribeTrainingMetrics(DescribeTrainingMetricsRequest req)
        {
             JsonResponseModel<DescribeTrainingMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingMetricsRequest"/></param>
        /// <returns><see cref="DescribeTrainingMetricsResponse"/></returns>
        public DescribeTrainingMetricsResponse DescribeTrainingMetricsSync(DescribeTrainingMetricsRequest req)
        {
             JsonResponseModel<DescribeTrainingMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询模型版本
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelVersionRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelVersionResponse"/></returns>
        public async Task<DescribeTrainingModelVersionResponse> DescribeTrainingModelVersion(DescribeTrainingModelVersionRequest req)
        {
             JsonResponseModel<DescribeTrainingModelVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingModelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingModelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询模型版本
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelVersionRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelVersionResponse"/></returns>
        public DescribeTrainingModelVersionResponse DescribeTrainingModelVersionSync(DescribeTrainingModelVersionRequest req)
        {
             JsonResponseModel<DescribeTrainingModelVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingModelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingModelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 模型版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelVersionsRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelVersionsResponse"/></returns>
        public async Task<DescribeTrainingModelVersionsResponse> DescribeTrainingModelVersions(DescribeTrainingModelVersionsRequest req)
        {
             JsonResponseModel<DescribeTrainingModelVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingModelVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingModelVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 模型版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelVersionsRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelVersionsResponse"/></returns>
        public DescribeTrainingModelVersionsResponse DescribeTrainingModelVersionsSync(DescribeTrainingModelVersionsRequest req)
        {
             JsonResponseModel<DescribeTrainingModelVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingModelVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingModelVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 模型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelsRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelsResponse"/></returns>
        public async Task<DescribeTrainingModelsResponse> DescribeTrainingModels(DescribeTrainingModelsRequest req)
        {
             JsonResponseModel<DescribeTrainingModelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingModels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingModelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 模型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelsRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelsResponse"/></returns>
        public DescribeTrainingModelsResponse DescribeTrainingModelsSync(DescribeTrainingModelsRequest req)
        {
             JsonResponseModel<DescribeTrainingModelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingModels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingModelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskResponse"/></returns>
        public async Task<DescribeTrainingTaskResponse> DescribeTrainingTask(DescribeTrainingTaskRequest req)
        {
             JsonResponseModel<DescribeTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskResponse"/></returns>
        public DescribeTrainingTaskResponse DescribeTrainingTaskSync(DescribeTrainingTaskRequest req)
        {
             JsonResponseModel<DescribeTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练任务pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskPodsRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskPodsResponse"/></returns>
        public async Task<DescribeTrainingTaskPodsResponse> DescribeTrainingTaskPods(DescribeTrainingTaskPodsRequest req)
        {
             JsonResponseModel<DescribeTrainingTaskPodsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingTaskPods");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingTaskPodsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练任务pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskPodsRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskPodsResponse"/></returns>
        public DescribeTrainingTaskPodsResponse DescribeTrainingTaskPodsSync(DescribeTrainingTaskPodsRequest req)
        {
             JsonResponseModel<DescribeTrainingTaskPodsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingTaskPods");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingTaskPodsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTasksRequest"/></param>
        /// <returns><see cref="DescribeTrainingTasksResponse"/></returns>
        public async Task<DescribeTrainingTasksResponse> DescribeTrainingTasks(DescribeTrainingTasksRequest req)
        {
             JsonResponseModel<DescribeTrainingTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTasksRequest"/></param>
        /// <returns><see cref="DescribeTrainingTasksResponse"/></returns>
        public DescribeTrainingTasksResponse DescribeTrainingTasksSync(DescribeTrainingTasksRequest req)
        {
             JsonResponseModel<DescribeTrainingTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="PushTrainingMetricsRequest"/></param>
        /// <returns><see cref="PushTrainingMetricsResponse"/></returns>
        public async Task<PushTrainingMetricsResponse> PushTrainingMetrics(PushTrainingMetricsRequest req)
        {
             JsonResponseModel<PushTrainingMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PushTrainingMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushTrainingMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="PushTrainingMetricsRequest"/></param>
        /// <returns><see cref="PushTrainingMetricsResponse"/></returns>
        public PushTrainingMetricsResponse PushTrainingMetricsSync(PushTrainingMetricsRequest req)
        {
             JsonResponseModel<PushTrainingMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PushTrainingMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushTrainingMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动模型训练任务
        /// </summary>
        /// <param name="req"><see cref="StartTrainingTaskRequest"/></param>
        /// <returns><see cref="StartTrainingTaskResponse"/></returns>
        public async Task<StartTrainingTaskResponse> StartTrainingTask(StartTrainingTaskRequest req)
        {
             JsonResponseModel<StartTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动模型训练任务
        /// </summary>
        /// <param name="req"><see cref="StartTrainingTaskRequest"/></param>
        /// <returns><see cref="StartTrainingTaskResponse"/></returns>
        public StartTrainingTaskResponse StartTrainingTaskSync(StartTrainingTaskRequest req)
        {
             JsonResponseModel<StartTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止模型训练任务
        /// </summary>
        /// <param name="req"><see cref="StopTrainingTaskRequest"/></param>
        /// <returns><see cref="StopTrainingTaskResponse"/></returns>
        public async Task<StopTrainingTaskResponse> StopTrainingTask(StopTrainingTaskRequest req)
        {
             JsonResponseModel<StopTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止模型训练任务
        /// </summary>
        /// <param name="req"><see cref="StopTrainingTaskRequest"/></param>
        /// <returns><see cref="StopTrainingTaskResponse"/></returns>
        public StopTrainingTaskResponse StopTrainingTaskSync(StopTrainingTaskRequest req)
        {
             JsonResponseModel<StopTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
