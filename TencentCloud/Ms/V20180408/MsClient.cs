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

namespace TencentCloud.Ms.V20180408
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ms.V20180408.Models;

   public class MsClient : AbstractClient{

       private const string endpoint = "ms.tencentcloudapi.com";
       private const string version = "2018-04-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 该接口供渠道合作应用加固使用，接口调用有白名单用户限制，取消渠道合作加固中的任务。
        /// </summary>
        /// <param name="req"><see cref="CancelEncryptTaskRequest"/></param>
        /// <returns><see cref="CancelEncryptTaskResponse"/></returns>
        public async Task<CancelEncryptTaskResponse> CancelEncryptTask(CancelEncryptTaskRequest req)
        {
             JsonResponseModel<CancelEncryptTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelEncryptTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelEncryptTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口供渠道合作应用加固使用，接口调用有白名单用户限制，取消渠道合作加固中的任务。
        /// </summary>
        /// <param name="req"><see cref="CancelEncryptTaskRequest"/></param>
        /// <returns><see cref="CancelEncryptTaskResponse"/></returns>
        public CancelEncryptTaskResponse CancelEncryptTaskSync(CancelEncryptTaskRequest req)
        {
             JsonResponseModel<CancelEncryptTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelEncryptTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelEncryptTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将应用和资源进行绑定。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="CreateBindInstanceRequest"/></param>
        /// <returns><see cref="CreateBindInstanceResponse"/></returns>
        public async Task<CreateBindInstanceResponse> CreateBindInstance(CreateBindInstanceRequest req)
        {
             JsonResponseModel<CreateBindInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBindInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBindInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将应用和资源进行绑定。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="CreateBindInstanceRequest"/></param>
        /// <returns><see cref="CreateBindInstanceResponse"/></returns>
        public CreateBindInstanceResponse CreateBindInstanceSync(CreateBindInstanceRequest req)
        {
             JsonResponseModel<CreateBindInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBindInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBindInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云COS文件存储临时密钥，密钥仅限于临时上传文件，有访问限制和时效性，请保管好临时密钥。
        /// </summary>
        /// <param name="req"><see cref="CreateCosSecKeyInstanceRequest"/></param>
        /// <returns><see cref="CreateCosSecKeyInstanceResponse"/></returns>
        public async Task<CreateCosSecKeyInstanceResponse> CreateCosSecKeyInstance(CreateCosSecKeyInstanceRequest req)
        {
             JsonResponseModel<CreateCosSecKeyInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCosSecKeyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCosSecKeyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云COS文件存储临时密钥，密钥仅限于临时上传文件，有访问限制和时效性，请保管好临时密钥。
        /// </summary>
        /// <param name="req"><see cref="CreateCosSecKeyInstanceRequest"/></param>
        /// <returns><see cref="CreateCosSecKeyInstanceResponse"/></returns>
        public CreateCosSecKeyInstanceResponse CreateCosSecKeyInstanceSync(CreateCosSecKeyInstanceRequest req)
        {
             JsonResponseModel<CreateCosSecKeyInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCosSecKeyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCosSecKeyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口供渠道合作应用加固使用，接口调用有白名单用户限制，用于创建加固任务。
        /// </summary>
        /// <param name="req"><see cref="CreateEncryptInstanceRequest"/></param>
        /// <returns><see cref="CreateEncryptInstanceResponse"/></returns>
        public async Task<CreateEncryptInstanceResponse> CreateEncryptInstance(CreateEncryptInstanceRequest req)
        {
             JsonResponseModel<CreateEncryptInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEncryptInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEncryptInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口供渠道合作应用加固使用，接口调用有白名单用户限制，用于创建加固任务。
        /// </summary>
        /// <param name="req"><see cref="CreateEncryptInstanceRequest"/></param>
        /// <returns><see cref="CreateEncryptInstanceResponse"/></returns>
        public CreateEncryptInstanceResponse CreateEncryptInstanceSync(CreateEncryptInstanceRequest req)
        {
             JsonResponseModel<CreateEncryptInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEncryptInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEncryptInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口供渠道合作应用加固使用，接口调用有白名单用户限制。
        /// 订单类型有：免费试用、按年收费、按次收费。
        /// 应用加固支持的平台类型有：android加固 、ios源码混淆 、sdk加固、applet小程序加固
        /// </summary>
        /// <param name="req"><see cref="CreateOrderInstanceRequest"/></param>
        /// <returns><see cref="CreateOrderInstanceResponse"/></returns>
        public async Task<CreateOrderInstanceResponse> CreateOrderInstance(CreateOrderInstanceRequest req)
        {
             JsonResponseModel<CreateOrderInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrderInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrderInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口供渠道合作应用加固使用，接口调用有白名单用户限制。
        /// 订单类型有：免费试用、按年收费、按次收费。
        /// 应用加固支持的平台类型有：android加固 、ios源码混淆 、sdk加固、applet小程序加固
        /// </summary>
        /// <param name="req"><see cref="CreateOrderInstanceRequest"/></param>
        /// <returns><see cref="CreateOrderInstanceResponse"/></returns>
        public CreateOrderInstanceResponse CreateOrderInstanceSync(CreateOrderInstanceRequest req)
        {
             JsonResponseModel<CreateOrderInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrderInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrderInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户可以使用该接口自建资源，只支持白名单用户
        /// </summary>
        /// <param name="req"><see cref="CreateResourceInstancesRequest"/></param>
        /// <returns><see cref="CreateResourceInstancesResponse"/></returns>
        public async Task<CreateResourceInstancesResponse> CreateResourceInstances(CreateResourceInstancesRequest req)
        {
             JsonResponseModel<CreateResourceInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateResourceInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户可以使用该接口自建资源，只支持白名单用户
        /// </summary>
        /// <param name="req"><see cref="CreateResourceInstancesRequest"/></param>
        /// <returns><see cref="CreateResourceInstancesResponse"/></returns>
        public CreateResourceInstancesResponse CreateResourceInstancesSync(CreateResourceInstancesRequest req)
        {
             JsonResponseModel<CreateResourceInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateResourceInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口提交应用进行应用加固，加固后需通过DescribeShieldResult接口查询加固结果。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="CreateShieldInstanceRequest"/></param>
        /// <returns><see cref="CreateShieldInstanceResponse"/></returns>
        public async Task<CreateShieldInstanceResponse> CreateShieldInstance(CreateShieldInstanceRequest req)
        {
             JsonResponseModel<CreateShieldInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateShieldInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateShieldInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口提交应用进行应用加固，加固后需通过DescribeShieldResult接口查询加固结果。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="CreateShieldInstanceRequest"/></param>
        /// <returns><see cref="CreateShieldInstanceResponse"/></returns>
        public CreateShieldInstanceResponse CreateShieldInstanceSync(CreateShieldInstanceRequest req)
        {
             JsonResponseModel<CreateShieldInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateShieldInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateShieldInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对资源进行策略新增。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="CreateShieldPlanInstanceRequest"/></param>
        /// <returns><see cref="CreateShieldPlanInstanceResponse"/></returns>
        public async Task<CreateShieldPlanInstanceResponse> CreateShieldPlanInstance(CreateShieldPlanInstanceRequest req)
        {
             JsonResponseModel<CreateShieldPlanInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateShieldPlanInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateShieldPlanInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对资源进行策略新增。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="CreateShieldPlanInstanceRequest"/></param>
        /// <returns><see cref="CreateShieldPlanInstanceResponse"/></returns>
        public CreateShieldPlanInstanceResponse CreateShieldPlanInstanceSync(CreateShieldPlanInstanceRequest req)
        {
             JsonResponseModel<CreateShieldPlanInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateShieldPlanInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateShieldPlanInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个或者多个app加固信息。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="DeleteShieldInstancesRequest"/></param>
        /// <returns><see cref="DeleteShieldInstancesResponse"/></returns>
        public async Task<DeleteShieldInstancesResponse> DeleteShieldInstances(DeleteShieldInstancesRequest req)
        {
             JsonResponseModel<DeleteShieldInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteShieldInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteShieldInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个或者多个app加固信息。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="DeleteShieldInstancesRequest"/></param>
        /// <returns><see cref="DeleteShieldInstancesResponse"/></returns>
        public DeleteShieldInstancesResponse DeleteShieldInstancesSync(DeleteShieldInstancesRequest req)
        {
             JsonResponseModel<DeleteShieldInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteShieldInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteShieldInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口采用同步模式请求腾讯APK云检测服务，即时返回检测数据，需要用户用轮询的方式调用本接口来进行样本送检并获取检测结果(每隔60s发送一次请求，传相同的参数，重试30次)，一般情况下0.5h内会出检测结果，最长时间是3h。当Result为ok并且ResultList数组非空有值时，代表检测完毕，若长时间获取不到检测结果，请联系客服。
        /// </summary>
        /// <param name="req"><see cref="DescribeApkDetectionResultRequest"/></param>
        /// <returns><see cref="DescribeApkDetectionResultResponse"/></returns>
        public async Task<DescribeApkDetectionResultResponse> DescribeApkDetectionResult(DescribeApkDetectionResultRequest req)
        {
             JsonResponseModel<DescribeApkDetectionResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApkDetectionResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApkDetectionResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口采用同步模式请求腾讯APK云检测服务，即时返回检测数据，需要用户用轮询的方式调用本接口来进行样本送检并获取检测结果(每隔60s发送一次请求，传相同的参数，重试30次)，一般情况下0.5h内会出检测结果，最长时间是3h。当Result为ok并且ResultList数组非空有值时，代表检测完毕，若长时间获取不到检测结果，请联系客服。
        /// </summary>
        /// <param name="req"><see cref="DescribeApkDetectionResultRequest"/></param>
        /// <returns><see cref="DescribeApkDetectionResultResponse"/></returns>
        public DescribeApkDetectionResultResponse DescribeApkDetectionResultSync(DescribeApkDetectionResultRequest req)
        {
             JsonResponseModel<DescribeApkDetectionResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApkDetectionResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApkDetectionResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口供渠道合作应用加固使用，接口调用有白名单用户限制，用于查询加固任务，入参中的条件过滤字段均为精准匹配。支持功能点：1. 多任务分页查询  2.根据任务Id唯一值查询单记录
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptInstancesRequest"/></param>
        /// <returns><see cref="DescribeEncryptInstancesResponse"/></returns>
        public async Task<DescribeEncryptInstancesResponse> DescribeEncryptInstances(DescribeEncryptInstancesRequest req)
        {
             JsonResponseModel<DescribeEncryptInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEncryptInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEncryptInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口供渠道合作应用加固使用，接口调用有白名单用户限制，用于查询加固任务，入参中的条件过滤字段均为精准匹配。支持功能点：1. 多任务分页查询  2.根据任务Id唯一值查询单记录
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptInstancesRequest"/></param>
        /// <returns><see cref="DescribeEncryptInstancesResponse"/></returns>
        public DescribeEncryptInstancesResponse DescribeEncryptInstancesSync(DescribeEncryptInstancesRequest req)
        {
             JsonResponseModel<DescribeEncryptInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEncryptInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEncryptInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口供渠道合作应用加固使用，接口调用有白名单用户限制。入参中的条件过滤字段均为精准匹配。
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptPlanRequest"/></param>
        /// <returns><see cref="DescribeEncryptPlanResponse"/></returns>
        public async Task<DescribeEncryptPlanResponse> DescribeEncryptPlan(DescribeEncryptPlanRequest req)
        {
             JsonResponseModel<DescribeEncryptPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEncryptPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEncryptPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口供渠道合作应用加固使用，接口调用有白名单用户限制。入参中的条件过滤字段均为精准匹配。
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptPlanRequest"/></param>
        /// <returns><see cref="DescribeEncryptPlanResponse"/></returns>
        public DescribeEncryptPlanResponse DescribeEncryptPlanSync(DescribeEncryptPlanRequest req)
        {
             JsonResponseModel<DescribeEncryptPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEncryptPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEncryptPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口供渠道合作应用加固使用，接口调用有白名单用户限制。 接口返回的结果为：创建订单后，订单审批状态信息，以及与订单关联的资源状态等信息，入参中的条件过滤字段均为精准匹配。
        /// 接口功能点：
        /// 1.支持多订单分页查询；
        /// 2.支持唯一订单号精准匹配查询；
        /// 3.支持唯一资源号精准匹配查询；
        /// </summary>
        /// <param name="req"><see cref="DescribeOrderInstancesRequest"/></param>
        /// <returns><see cref="DescribeOrderInstancesResponse"/></returns>
        public async Task<DescribeOrderInstancesResponse> DescribeOrderInstances(DescribeOrderInstancesRequest req)
        {
             JsonResponseModel<DescribeOrderInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrderInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrderInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口供渠道合作应用加固使用，接口调用有白名单用户限制。 接口返回的结果为：创建订单后，订单审批状态信息，以及与订单关联的资源状态等信息，入参中的条件过滤字段均为精准匹配。
        /// 接口功能点：
        /// 1.支持多订单分页查询；
        /// 2.支持唯一订单号精准匹配查询；
        /// 3.支持唯一资源号精准匹配查询；
        /// </summary>
        /// <param name="req"><see cref="DescribeOrderInstancesRequest"/></param>
        /// <returns><see cref="DescribeOrderInstancesResponse"/></returns>
        public DescribeOrderInstancesResponse DescribeOrderInstancesSync(DescribeOrderInstancesRequest req)
        {
             JsonResponseModel<DescribeOrderInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrderInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrderInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取某个用户的所有资源信息。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceInstancesRequest"/></param>
        /// <returns><see cref="DescribeResourceInstancesResponse"/></returns>
        public async Task<DescribeResourceInstancesResponse> DescribeResourceInstances(DescribeResourceInstancesRequest req)
        {
             JsonResponseModel<DescribeResourceInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取某个用户的所有资源信息。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceInstancesRequest"/></param>
        /// <returns><see cref="DescribeResourceInstancesResponse"/></returns>
        public DescribeResourceInstancesResponse DescribeResourceInstancesSync(DescribeResourceInstancesRequest req)
        {
             JsonResponseModel<DescribeResourceInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查看app列表。
        /// 可以通过指定任务唯一标识ItemId来查询指定app的详细信息，或通过设定过滤器来查询满足过滤条件的app的详细信息。 指定偏移(Offset)和限制(Limit)来选择结果中的一部分，默认返回满足条件的前20个app信息。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="DescribeShieldInstancesRequest"/></param>
        /// <returns><see cref="DescribeShieldInstancesResponse"/></returns>
        public async Task<DescribeShieldInstancesResponse> DescribeShieldInstances(DescribeShieldInstancesRequest req)
        {
             JsonResponseModel<DescribeShieldInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShieldInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShieldInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查看app列表。
        /// 可以通过指定任务唯一标识ItemId来查询指定app的详细信息，或通过设定过滤器来查询满足过滤条件的app的详细信息。 指定偏移(Offset)和限制(Limit)来选择结果中的一部分，默认返回满足条件的前20个app信息。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="DescribeShieldInstancesRequest"/></param>
        /// <returns><see cref="DescribeShieldInstancesResponse"/></returns>
        public DescribeShieldInstancesResponse DescribeShieldInstancesSync(DescribeShieldInstancesRequest req)
        {
             JsonResponseModel<DescribeShieldInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShieldInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShieldInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询加固策略。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="DescribeShieldPlanInstanceRequest"/></param>
        /// <returns><see cref="DescribeShieldPlanInstanceResponse"/></returns>
        public async Task<DescribeShieldPlanInstanceResponse> DescribeShieldPlanInstance(DescribeShieldPlanInstanceRequest req)
        {
             JsonResponseModel<DescribeShieldPlanInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShieldPlanInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShieldPlanInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询加固策略。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="DescribeShieldPlanInstanceRequest"/></param>
        /// <returns><see cref="DescribeShieldPlanInstanceResponse"/></returns>
        public DescribeShieldPlanInstanceResponse DescribeShieldPlanInstanceSync(DescribeShieldPlanInstanceRequest req)
        {
             JsonResponseModel<DescribeShieldPlanInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShieldPlanInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShieldPlanInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过唯一标识获取加固的结果。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="DescribeShieldResultRequest"/></param>
        /// <returns><see cref="DescribeShieldResultResponse"/></returns>
        public async Task<DescribeShieldResultResponse> DescribeShieldResult(DescribeShieldResultRequest req)
        {
             JsonResponseModel<DescribeShieldResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShieldResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShieldResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过唯一标识获取加固的结果。（注意：根据国家互联网用户实名制相关要求，使用该产品前，需先完成实名认证。）
        /// </summary>
        /// <param name="req"><see cref="DescribeShieldResultRequest"/></param>
        /// <returns><see cref="DescribeShieldResultResponse"/></returns>
        public DescribeShieldResultResponse DescribeShieldResultSync(DescribeShieldResultRequest req)
        {
             JsonResponseModel<DescribeShieldResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShieldResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShieldResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动安全-网址检测服务
        /// </summary>
        /// <param name="req"><see cref="DescribeUrlDetectionResultRequest"/></param>
        /// <returns><see cref="DescribeUrlDetectionResultResponse"/></returns>
        public async Task<DescribeUrlDetectionResultResponse> DescribeUrlDetectionResult(DescribeUrlDetectionResultRequest req)
        {
             JsonResponseModel<DescribeUrlDetectionResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUrlDetectionResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUrlDetectionResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动安全-网址检测服务
        /// </summary>
        /// <param name="req"><see cref="DescribeUrlDetectionResultRequest"/></param>
        /// <returns><see cref="DescribeUrlDetectionResultResponse"/></returns>
        public DescribeUrlDetectionResultResponse DescribeUrlDetectionResultSync(DescribeUrlDetectionResultRequest req)
        {
             JsonResponseModel<DescribeUrlDetectionResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUrlDetectionResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUrlDetectionResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户基础信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserBaseInfoInstanceRequest"/></param>
        /// <returns><see cref="DescribeUserBaseInfoInstanceResponse"/></returns>
        public async Task<DescribeUserBaseInfoInstanceResponse> DescribeUserBaseInfoInstance(DescribeUserBaseInfoInstanceRequest req)
        {
             JsonResponseModel<DescribeUserBaseInfoInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserBaseInfoInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserBaseInfoInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户基础信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserBaseInfoInstanceRequest"/></param>
        /// <returns><see cref="DescribeUserBaseInfoInstanceResponse"/></returns>
        public DescribeUserBaseInfoInstanceResponse DescribeUserBaseInfoInstanceSync(DescribeUserBaseInfoInstanceRequest req)
        {
             JsonResponseModel<DescribeUserBaseInfoInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserBaseInfoInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserBaseInfoInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// client任务请求
        /// </summary>
        /// <param name="req"><see cref="RequestLocalTaskRequest"/></param>
        /// <returns><see cref="RequestLocalTaskResponse"/></returns>
        public async Task<RequestLocalTaskResponse> RequestLocalTask(RequestLocalTaskRequest req)
        {
             JsonResponseModel<RequestLocalTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RequestLocalTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RequestLocalTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// client任务请求
        /// </summary>
        /// <param name="req"><see cref="RequestLocalTaskRequest"/></param>
        /// <returns><see cref="RequestLocalTaskResponse"/></returns>
        public RequestLocalTaskResponse RequestLocalTaskSync(RequestLocalTaskRequest req)
        {
             JsonResponseModel<RequestLocalTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RequestLocalTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RequestLocalTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新client状态，需要白名单
        /// </summary>
        /// <param name="req"><see cref="UpdateClientStateRequest"/></param>
        /// <returns><see cref="UpdateClientStateResponse"/></returns>
        public async Task<UpdateClientStateResponse> UpdateClientState(UpdateClientStateRequest req)
        {
             JsonResponseModel<UpdateClientStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateClientState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateClientStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新client状态，需要白名单
        /// </summary>
        /// <param name="req"><see cref="UpdateClientStateRequest"/></param>
        /// <returns><see cref="UpdateClientStateResponse"/></returns>
        public UpdateClientStateResponse UpdateClientStateSync(UpdateClientStateRequest req)
        {
             JsonResponseModel<UpdateClientStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateClientState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateClientStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新本地任务执行结果
        /// </summary>
        /// <param name="req"><see cref="UpdateLocalTaskResultRequest"/></param>
        /// <returns><see cref="UpdateLocalTaskResultResponse"/></returns>
        public async Task<UpdateLocalTaskResultResponse> UpdateLocalTaskResult(UpdateLocalTaskResultRequest req)
        {
             JsonResponseModel<UpdateLocalTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateLocalTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateLocalTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新本地任务执行结果
        /// </summary>
        /// <param name="req"><see cref="UpdateLocalTaskResultRequest"/></param>
        /// <returns><see cref="UpdateLocalTaskResultResponse"/></returns>
        public UpdateLocalTaskResultResponse UpdateLocalTaskResultSync(UpdateLocalTaskResultRequest req)
        {
             JsonResponseModel<UpdateLocalTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateLocalTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateLocalTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
