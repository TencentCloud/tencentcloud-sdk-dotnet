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

namespace TencentCloud.Youmall.V20180228
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Youmall.V20180228.Models;

   public class YoumallClient : AbstractClient{

       private const string endpoint = "youmall.tencentcloudapi.com";
       private const string version = "2018-02-28";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public YoumallClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public YoumallClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建集团门店管理员账号
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public async Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
             JsonResponseModel<CreateAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateAccount接口的同步版本，创建集团门店管理员账号
        /// </summary>
        /// <param name="req">参考<see cref="CreateAccountRequest"/></param>
        /// <returns>参考<see cref="CreateAccountResponse"/>实例</returns>
        public CreateAccountResponse CreateAccountSync(CreateAccountRequest req)
        {
             JsonResponseModel<CreateAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过上传指定规格的人脸图片，创建黑名单用户或者白名单用户。
        /// </summary>
        /// <param name="req"><see cref="CreateFacePictureRequest"/></param>
        /// <returns><see cref="CreateFacePictureResponse"/></returns>
        public async Task<CreateFacePictureResponse> CreateFacePicture(CreateFacePictureRequest req)
        {
             JsonResponseModel<CreateFacePictureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFacePicture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFacePictureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateFacePicture接口的同步版本，通过上传指定规格的人脸图片，创建黑名单用户或者白名单用户。
        /// </summary>
        /// <param name="req">参考<see cref="CreateFacePictureRequest"/></param>
        /// <returns>参考<see cref="CreateFacePictureResponse"/>实例</returns>
        public CreateFacePictureResponse CreateFacePictureSync(CreateFacePictureRequest req)
        {
             JsonResponseModel<CreateFacePictureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFacePicture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFacePictureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除顾客特征，仅支持删除黑名单或者白名单用户特征。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonFeatureRequest"/></param>
        /// <returns><see cref="DeletePersonFeatureResponse"/></returns>
        public async Task<DeletePersonFeatureResponse> DeletePersonFeature(DeletePersonFeatureRequest req)
        {
             JsonResponseModel<DeletePersonFeatureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePersonFeature");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonFeatureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeletePersonFeature接口的同步版本，删除顾客特征，仅支持删除黑名单或者白名单用户特征。
        /// </summary>
        /// <param name="req">参考<see cref="DeletePersonFeatureRequest"/></param>
        /// <returns>参考<see cref="DeletePersonFeatureResponse"/>实例</returns>
        public DeletePersonFeatureResponse DeletePersonFeatureSync(DeletePersonFeatureRequest req)
        {
             JsonResponseModel<DeletePersonFeatureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePersonFeature");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonFeatureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过指定设备ID和指定时段，获取该时段内中收银台摄像设备抓取到顾客头像及身份ID
        /// </summary>
        /// <param name="req"><see cref="DescribeCameraPersonRequest"/></param>
        /// <returns><see cref="DescribeCameraPersonResponse"/></returns>
        public async Task<DescribeCameraPersonResponse> DescribeCameraPerson(DescribeCameraPersonRequest req)
        {
             JsonResponseModel<DescribeCameraPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCameraPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCameraPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCameraPerson接口的同步版本，通过指定设备ID和指定时段，获取该时段内中收银台摄像设备抓取到顾客头像及身份ID
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCameraPersonRequest"/></param>
        /// <returns>参考<see cref="DescribeCameraPersonResponse"/>实例</returns>
        public DescribeCameraPersonResponse DescribeCameraPersonSync(DescribeCameraPersonRequest req)
        {
             JsonResponseModel<DescribeCameraPersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCameraPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCameraPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 输出开始时间到结束时间段内的进出场数据。按天聚合的情况下，每天多次进出场算一次，以最初进场时间为进场时间，最后离场时间为离场时间。停留时间为多次进出场的停留时间之和。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPersonArrivedMallRequest"/></param>
        /// <returns><see cref="DescribeClusterPersonArrivedMallResponse"/></returns>
        public async Task<DescribeClusterPersonArrivedMallResponse> DescribeClusterPersonArrivedMall(DescribeClusterPersonArrivedMallRequest req)
        {
             JsonResponseModel<DescribeClusterPersonArrivedMallResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterPersonArrivedMall");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterPersonArrivedMallResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClusterPersonArrivedMall接口的同步版本，输出开始时间到结束时间段内的进出场数据。按天聚合的情况下，每天多次进出场算一次，以最初进场时间为进场时间，最后离场时间为离场时间。停留时间为多次进出场的停留时间之和。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClusterPersonArrivedMallRequest"/></param>
        /// <returns>参考<see cref="DescribeClusterPersonArrivedMallResponse"/>实例</returns>
        public DescribeClusterPersonArrivedMallResponse DescribeClusterPersonArrivedMallSync(DescribeClusterPersonArrivedMallRequest req)
        {
             JsonResponseModel<DescribeClusterPersonArrivedMallResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterPersonArrivedMall");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterPersonArrivedMallResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 输出开始时间到结束时间段内的进出场数据。按天聚合的情况下，每天多次进出场算一次，以最初进场时间为进场时间，最后离场时间为离场时间。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPersonTraceRequest"/></param>
        /// <returns><see cref="DescribeClusterPersonTraceResponse"/></returns>
        public async Task<DescribeClusterPersonTraceResponse> DescribeClusterPersonTrace(DescribeClusterPersonTraceRequest req)
        {
             JsonResponseModel<DescribeClusterPersonTraceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterPersonTrace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterPersonTraceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClusterPersonTrace接口的同步版本，输出开始时间到结束时间段内的进出场数据。按天聚合的情况下，每天多次进出场算一次，以最初进场时间为进场时间，最后离场时间为离场时间。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClusterPersonTraceRequest"/></param>
        /// <returns>参考<see cref="DescribeClusterPersonTraceResponse"/>实例</returns>
        public DescribeClusterPersonTraceResponse DescribeClusterPersonTraceSync(DescribeClusterPersonTraceRequest req)
        {
             JsonResponseModel<DescribeClusterPersonTraceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterPersonTrace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterPersonTraceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过DescribeCameraPerson接口上报的收银台身份ID查询顾客的FaceID。查询最佳时间为收银台上报的次日1点后。
        /// </summary>
        /// <param name="req"><see cref="DescribeFaceIdByTempIdRequest"/></param>
        /// <returns><see cref="DescribeFaceIdByTempIdResponse"/></returns>
        public async Task<DescribeFaceIdByTempIdResponse> DescribeFaceIdByTempId(DescribeFaceIdByTempIdRequest req)
        {
             JsonResponseModel<DescribeFaceIdByTempIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFaceIdByTempId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFaceIdByTempIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeFaceIdByTempId接口的同步版本，通过DescribeCameraPerson接口上报的收银台身份ID查询顾客的FaceID。查询最佳时间为收银台上报的次日1点后。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFaceIdByTempIdRequest"/></param>
        /// <returns>参考<see cref="DescribeFaceIdByTempIdResponse"/>实例</returns>
        public DescribeFaceIdByTempIdResponse DescribeFaceIdByTempIdSync(DescribeFaceIdByTempIdRequest req)
        {
             JsonResponseModel<DescribeFaceIdByTempIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFaceIdByTempId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFaceIdByTempIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回当前门店历史网络状态数据
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryNetworkInfoRequest"/></param>
        /// <returns><see cref="DescribeHistoryNetworkInfoResponse"/></returns>
        public async Task<DescribeHistoryNetworkInfoResponse> DescribeHistoryNetworkInfo(DescribeHistoryNetworkInfoRequest req)
        {
             JsonResponseModel<DescribeHistoryNetworkInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHistoryNetworkInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHistoryNetworkInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeHistoryNetworkInfo接口的同步版本，返回当前门店历史网络状态数据
        /// </summary>
        /// <param name="req">参考<see cref="DescribeHistoryNetworkInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeHistoryNetworkInfoResponse"/>实例</returns>
        public DescribeHistoryNetworkInfoResponse DescribeHistoryNetworkInfoSync(DescribeHistoryNetworkInfoRequest req)
        {
             JsonResponseModel<DescribeHistoryNetworkInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHistoryNetworkInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHistoryNetworkInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回当前门店最新网络状态数据
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInfoRequest"/></param>
        /// <returns><see cref="DescribeNetworkInfoResponse"/></returns>
        public async Task<DescribeNetworkInfoResponse> DescribeNetworkInfo(DescribeNetworkInfoRequest req)
        {
             JsonResponseModel<DescribeNetworkInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeNetworkInfo接口的同步版本，返回当前门店最新网络状态数据
        /// </summary>
        /// <param name="req">参考<see cref="DescribeNetworkInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeNetworkInfoResponse"/>实例</returns>
        public DescribeNetworkInfoResponse DescribeNetworkInfoSync(DescribeNetworkInfoRequest req)
        {
             JsonResponseModel<DescribeNetworkInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定某一卖场的用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribePersonRequest"/></param>
        /// <returns><see cref="DescribePersonResponse"/></returns>
        public async Task<DescribePersonResponse> DescribePerson(DescribePersonRequest req)
        {
             JsonResponseModel<DescribePersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePerson接口的同步版本，查询指定某一卖场的用户信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonRequest"/></param>
        /// <returns>参考<see cref="DescribePersonResponse"/>实例</returns>
        public DescribePersonResponse DescribePersonSync(DescribePersonRequest req)
        {
             JsonResponseModel<DescribePersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 输出开始时间到结束时间段内的进出场数据。不做按天聚合的情况下，每次进出场，产生一条进出场数据。
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribePersonArrivedMallRequest"/></param>
        /// <returns><see cref="DescribePersonArrivedMallResponse"/></returns>
        public async Task<DescribePersonArrivedMallResponse> DescribePersonArrivedMall(DescribePersonArrivedMallRequest req)
        {
             JsonResponseModel<DescribePersonArrivedMallResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersonArrivedMall");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonArrivedMallResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePersonArrivedMall接口的同步版本，输出开始时间到结束时间段内的进出场数据。不做按天聚合的情况下，每次进出场，产生一条进出场数据。
        /// 
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonArrivedMallRequest"/></param>
        /// <returns>参考<see cref="DescribePersonArrivedMallResponse"/>实例</returns>
        public DescribePersonArrivedMallResponse DescribePersonArrivedMallSync(DescribePersonArrivedMallRequest req)
        {
             JsonResponseModel<DescribePersonArrivedMallResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePersonArrivedMall");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonArrivedMallResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定门店获取所有顾客详情列表，包含客户ID、图片、年龄、性别
        /// </summary>
        /// <param name="req"><see cref="DescribePersonInfoRequest"/></param>
        /// <returns><see cref="DescribePersonInfoResponse"/></returns>
        public async Task<DescribePersonInfoResponse> DescribePersonInfo(DescribePersonInfoRequest req)
        {
             JsonResponseModel<DescribePersonInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersonInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePersonInfo接口的同步版本，指定门店获取所有顾客详情列表，包含客户ID、图片、年龄、性别
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonInfoRequest"/></param>
        /// <returns>参考<see cref="DescribePersonInfoResponse"/>实例</returns>
        public DescribePersonInfoResponse DescribePersonInfoSync(DescribePersonInfoRequest req)
        {
             JsonResponseModel<DescribePersonInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePersonInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过上传人脸图片检索系统face id、顾客身份信息及底图
        /// </summary>
        /// <param name="req"><see cref="DescribePersonInfoByFacePictureRequest"/></param>
        /// <returns><see cref="DescribePersonInfoByFacePictureResponse"/></returns>
        public async Task<DescribePersonInfoByFacePictureResponse> DescribePersonInfoByFacePicture(DescribePersonInfoByFacePictureRequest req)
        {
             JsonResponseModel<DescribePersonInfoByFacePictureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersonInfoByFacePicture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonInfoByFacePictureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePersonInfoByFacePicture接口的同步版本，通过上传人脸图片检索系统face id、顾客身份信息及底图
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonInfoByFacePictureRequest"/></param>
        /// <returns>参考<see cref="DescribePersonInfoByFacePictureResponse"/>实例</returns>
        public DescribePersonInfoByFacePictureResponse DescribePersonInfoByFacePictureSync(DescribePersonInfoByFacePictureRequest req)
        {
             JsonResponseModel<DescribePersonInfoByFacePictureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePersonInfoByFacePicture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonInfoByFacePictureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 输出开始时间到结束时间段内的进出场数据。
        /// </summary>
        /// <param name="req"><see cref="DescribePersonTraceRequest"/></param>
        /// <returns><see cref="DescribePersonTraceResponse"/></returns>
        public async Task<DescribePersonTraceResponse> DescribePersonTrace(DescribePersonTraceRequest req)
        {
             JsonResponseModel<DescribePersonTraceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersonTrace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonTraceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePersonTrace接口的同步版本，输出开始时间到结束时间段内的进出场数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonTraceRequest"/></param>
        /// <returns>参考<see cref="DescribePersonTraceResponse"/>实例</returns>
        public DescribePersonTraceResponse DescribePersonTraceSync(DescribePersonTraceRequest req)
        {
             JsonResponseModel<DescribePersonTraceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePersonTrace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonTraceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询客户单次到场轨迹明细
        /// </summary>
        /// <param name="req"><see cref="DescribePersonTraceDetailRequest"/></param>
        /// <returns><see cref="DescribePersonTraceDetailResponse"/></returns>
        public async Task<DescribePersonTraceDetailResponse> DescribePersonTraceDetail(DescribePersonTraceDetailRequest req)
        {
             JsonResponseModel<DescribePersonTraceDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersonTraceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonTraceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePersonTraceDetail接口的同步版本，查询客户单次到场轨迹明细
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonTraceDetailRequest"/></param>
        /// <returns>参考<see cref="DescribePersonTraceDetailResponse"/>实例</returns>
        public DescribePersonTraceDetailResponse DescribePersonTraceDetailSync(DescribePersonTraceDetailRequest req)
        {
             JsonResponseModel<DescribePersonTraceDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePersonTraceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonTraceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取门店指定时间范围内的所有用户到访信息记录，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req"><see cref="DescribePersonVisitInfoRequest"/></param>
        /// <returns><see cref="DescribePersonVisitInfoResponse"/></returns>
        public async Task<DescribePersonVisitInfoResponse> DescribePersonVisitInfo(DescribePersonVisitInfoRequest req)
        {
             JsonResponseModel<DescribePersonVisitInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersonVisitInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonVisitInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePersonVisitInfo接口的同步版本，获取门店指定时间范围内的所有用户到访信息记录，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonVisitInfoRequest"/></param>
        /// <returns>参考<see cref="DescribePersonVisitInfoResponse"/>实例</returns>
        public DescribePersonVisitInfoResponse DescribePersonVisitInfoSync(DescribePersonVisitInfoRequest req)
        {
             JsonResponseModel<DescribePersonVisitInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePersonVisitInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonVisitInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按小时提供查询日期范围内门店的每天每小时累计客流人数数据，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req"><see cref="DescribeShopHourTrafficInfoRequest"/></param>
        /// <returns><see cref="DescribeShopHourTrafficInfoResponse"/></returns>
        public async Task<DescribeShopHourTrafficInfoResponse> DescribeShopHourTrafficInfo(DescribeShopHourTrafficInfoRequest req)
        {
             JsonResponseModel<DescribeShopHourTrafficInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShopHourTrafficInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShopHourTrafficInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeShopHourTrafficInfo接口的同步版本，按小时提供查询日期范围内门店的每天每小时累计客流人数数据，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeShopHourTrafficInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeShopHourTrafficInfoResponse"/>实例</returns>
        public DescribeShopHourTrafficInfoResponse DescribeShopHourTrafficInfoSync(DescribeShopHourTrafficInfoRequest req)
        {
             JsonResponseModel<DescribeShopHourTrafficInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShopHourTrafficInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShopHourTrafficInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据客户身份标识获取客户下所有的门店信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeShopInfoRequest"/></param>
        /// <returns><see cref="DescribeShopInfoResponse"/></returns>
        public async Task<DescribeShopInfoResponse> DescribeShopInfo(DescribeShopInfoRequest req)
        {
             JsonResponseModel<DescribeShopInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShopInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShopInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeShopInfo接口的同步版本，根据客户身份标识获取客户下所有的门店信息列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeShopInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeShopInfoResponse"/>实例</returns>
        public DescribeShopInfoResponse DescribeShopInfoSync(DescribeShopInfoRequest req)
        {
             JsonResponseModel<DescribeShopInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShopInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShopInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按天提供查询日期范围内门店的单日累计客流人数，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req"><see cref="DescribeShopTrafficInfoRequest"/></param>
        /// <returns><see cref="DescribeShopTrafficInfoResponse"/></returns>
        public async Task<DescribeShopTrafficInfoResponse> DescribeShopTrafficInfo(DescribeShopTrafficInfoRequest req)
        {
             JsonResponseModel<DescribeShopTrafficInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShopTrafficInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShopTrafficInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeShopTrafficInfo接口的同步版本，按天提供查询日期范围内门店的单日累计客流人数，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeShopTrafficInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeShopTrafficInfoResponse"/>实例</returns>
        public DescribeShopTrafficInfoResponse DescribeShopTrafficInfoSync(DescribeShopTrafficInfoRequest req)
        {
             JsonResponseModel<DescribeShopTrafficInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShopTrafficInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShopTrafficInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取动线轨迹信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTrajectoryDataRequest"/></param>
        /// <returns><see cref="DescribeTrajectoryDataResponse"/></returns>
        public async Task<DescribeTrajectoryDataResponse> DescribeTrajectoryData(DescribeTrajectoryDataRequest req)
        {
             JsonResponseModel<DescribeTrajectoryDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrajectoryData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrajectoryDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTrajectoryData接口的同步版本，获取动线轨迹信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTrajectoryDataRequest"/></param>
        /// <returns>参考<see cref="DescribeTrajectoryDataResponse"/>实例</returns>
        public DescribeTrajectoryDataResponse DescribeTrajectoryDataSync(DescribeTrajectoryDataRequest req)
        {
             JsonResponseModel<DescribeTrajectoryDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrajectoryData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrajectoryDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定区域人流各年龄占比
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowAgeInfoByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowAgeInfoByZoneIdResponse"/></returns>
        public async Task<DescribeZoneFlowAgeInfoByZoneIdResponse> DescribeZoneFlowAgeInfoByZoneId(DescribeZoneFlowAgeInfoByZoneIdRequest req)
        {
             JsonResponseModel<DescribeZoneFlowAgeInfoByZoneIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneFlowAgeInfoByZoneId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneFlowAgeInfoByZoneIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeZoneFlowAgeInfoByZoneId接口的同步版本，获取指定区域人流各年龄占比
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneFlowAgeInfoByZoneIdRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneFlowAgeInfoByZoneIdResponse"/>实例</returns>
        public DescribeZoneFlowAgeInfoByZoneIdResponse DescribeZoneFlowAgeInfoByZoneIdSync(DescribeZoneFlowAgeInfoByZoneIdRequest req)
        {
             JsonResponseModel<DescribeZoneFlowAgeInfoByZoneIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneFlowAgeInfoByZoneId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneFlowAgeInfoByZoneIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取区域人流和停留时间
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowAndStayTimeRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowAndStayTimeResponse"/></returns>
        public async Task<DescribeZoneFlowAndStayTimeResponse> DescribeZoneFlowAndStayTime(DescribeZoneFlowAndStayTimeRequest req)
        {
             JsonResponseModel<DescribeZoneFlowAndStayTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneFlowAndStayTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneFlowAndStayTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeZoneFlowAndStayTime接口的同步版本，获取区域人流和停留时间
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneFlowAndStayTimeRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneFlowAndStayTimeResponse"/>实例</returns>
        public DescribeZoneFlowAndStayTimeResponse DescribeZoneFlowAndStayTimeSync(DescribeZoneFlowAndStayTimeRequest req)
        {
             JsonResponseModel<DescribeZoneFlowAndStayTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneFlowAndStayTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneFlowAndStayTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定区域每日客流量
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowDailyByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowDailyByZoneIdResponse"/></returns>
        public async Task<DescribeZoneFlowDailyByZoneIdResponse> DescribeZoneFlowDailyByZoneId(DescribeZoneFlowDailyByZoneIdRequest req)
        {
             JsonResponseModel<DescribeZoneFlowDailyByZoneIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneFlowDailyByZoneId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneFlowDailyByZoneIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeZoneFlowDailyByZoneId接口的同步版本，获取指定区域每日客流量
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneFlowDailyByZoneIdRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneFlowDailyByZoneIdResponse"/>实例</returns>
        public DescribeZoneFlowDailyByZoneIdResponse DescribeZoneFlowDailyByZoneIdSync(DescribeZoneFlowDailyByZoneIdRequest req)
        {
             JsonResponseModel<DescribeZoneFlowDailyByZoneIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneFlowDailyByZoneId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneFlowDailyByZoneIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定区域不同年龄段男女平均停留时间
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowGenderAvrStayTimeByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse"/></returns>
        public async Task<DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse> DescribeZoneFlowGenderAvrStayTimeByZoneId(DescribeZoneFlowGenderAvrStayTimeByZoneIdRequest req)
        {
             JsonResponseModel<DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneFlowGenderAvrStayTimeByZoneId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeZoneFlowGenderAvrStayTimeByZoneId接口的同步版本，获取指定区域不同年龄段男女平均停留时间
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneFlowGenderAvrStayTimeByZoneIdRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse"/>实例</returns>
        public DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse DescribeZoneFlowGenderAvrStayTimeByZoneIdSync(DescribeZoneFlowGenderAvrStayTimeByZoneIdRequest req)
        {
             JsonResponseModel<DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneFlowGenderAvrStayTimeByZoneId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定区域性别占比
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowGenderInfoByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowGenderInfoByZoneIdResponse"/></returns>
        public async Task<DescribeZoneFlowGenderInfoByZoneIdResponse> DescribeZoneFlowGenderInfoByZoneId(DescribeZoneFlowGenderInfoByZoneIdRequest req)
        {
             JsonResponseModel<DescribeZoneFlowGenderInfoByZoneIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneFlowGenderInfoByZoneId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneFlowGenderInfoByZoneIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeZoneFlowGenderInfoByZoneId接口的同步版本，获取指定区域性别占比
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneFlowGenderInfoByZoneIdRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneFlowGenderInfoByZoneIdResponse"/>实例</returns>
        public DescribeZoneFlowGenderInfoByZoneIdResponse DescribeZoneFlowGenderInfoByZoneIdSync(DescribeZoneFlowGenderInfoByZoneIdRequest req)
        {
             JsonResponseModel<DescribeZoneFlowGenderInfoByZoneIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneFlowGenderInfoByZoneId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneFlowGenderInfoByZoneIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定区域分时客流量
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowHourlyByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowHourlyByZoneIdResponse"/></returns>
        public async Task<DescribeZoneFlowHourlyByZoneIdResponse> DescribeZoneFlowHourlyByZoneId(DescribeZoneFlowHourlyByZoneIdRequest req)
        {
             JsonResponseModel<DescribeZoneFlowHourlyByZoneIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneFlowHourlyByZoneId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneFlowHourlyByZoneIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeZoneFlowHourlyByZoneId接口的同步版本，获取指定区域分时客流量
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneFlowHourlyByZoneIdRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneFlowHourlyByZoneIdResponse"/>实例</returns>
        public DescribeZoneFlowHourlyByZoneIdResponse DescribeZoneFlowHourlyByZoneIdSync(DescribeZoneFlowHourlyByZoneIdRequest req)
        {
             JsonResponseModel<DescribeZoneFlowHourlyByZoneIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneFlowHourlyByZoneId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneFlowHourlyByZoneIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按天提供查询日期范围内，客户指定门店下的所有区域（优Mall部署时已配置区域）的累计客流人次和平均停留时间。支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneTrafficInfoRequest"/></param>
        /// <returns><see cref="DescribeZoneTrafficInfoResponse"/></returns>
        public async Task<DescribeZoneTrafficInfoResponse> DescribeZoneTrafficInfo(DescribeZoneTrafficInfoRequest req)
        {
             JsonResponseModel<DescribeZoneTrafficInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneTrafficInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneTrafficInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeZoneTrafficInfo接口的同步版本，按天提供查询日期范围内，客户指定门店下的所有区域（优Mall部署时已配置区域）的累计客流人次和平均停留时间。支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneTrafficInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneTrafficInfoResponse"/>实例</returns>
        public DescribeZoneTrafficInfoResponse DescribeZoneTrafficInfoSync(DescribeZoneTrafficInfoRequest req)
        {
             JsonResponseModel<DescribeZoneTrafficInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneTrafficInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneTrafficInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持修改黑白名单类型的顾客特征
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonFeatureInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonFeatureInfoResponse"/></returns>
        public async Task<ModifyPersonFeatureInfoResponse> ModifyPersonFeatureInfo(ModifyPersonFeatureInfoRequest req)
        {
             JsonResponseModel<ModifyPersonFeatureInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonFeatureInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonFeatureInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyPersonFeatureInfo接口的同步版本，支持修改黑白名单类型的顾客特征
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPersonFeatureInfoRequest"/></param>
        /// <returns>参考<see cref="ModifyPersonFeatureInfoResponse"/>实例</returns>
        public ModifyPersonFeatureInfoResponse ModifyPersonFeatureInfoSync(ModifyPersonFeatureInfoRequest req)
        {
             JsonResponseModel<ModifyPersonFeatureInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPersonFeatureInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonFeatureInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 标记到店顾客的身份类型，例如黑名单、白名单等
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonTagInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonTagInfoResponse"/></returns>
        public async Task<ModifyPersonTagInfoResponse> ModifyPersonTagInfo(ModifyPersonTagInfoRequest req)
        {
             JsonResponseModel<ModifyPersonTagInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonTagInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonTagInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyPersonTagInfo接口的同步版本，标记到店顾客的身份类型，例如黑名单、白名单等
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPersonTagInfoRequest"/></param>
        /// <returns>参考<see cref="ModifyPersonTagInfoResponse"/>实例</returns>
        public ModifyPersonTagInfoResponse ModifyPersonTagInfoSync(ModifyPersonTagInfoRequest req)
        {
             JsonResponseModel<ModifyPersonTagInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPersonTagInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonTagInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改顾客身份类型接口
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonTypeRequest"/></param>
        /// <returns><see cref="ModifyPersonTypeResponse"/></returns>
        public async Task<ModifyPersonTypeResponse> ModifyPersonType(ModifyPersonTypeRequest req)
        {
             JsonResponseModel<ModifyPersonTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyPersonType接口的同步版本，修改顾客身份类型接口
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPersonTypeRequest"/></param>
        /// <returns>参考<see cref="ModifyPersonTypeResponse"/>实例</returns>
        public ModifyPersonTypeResponse ModifyPersonTypeSync(ModifyPersonTypeRequest req)
        {
             JsonResponseModel<ModifyPersonTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPersonType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用本接口在优Mall中注册自己集团的到店通知回调接口地址，接口协议为HTTP或HTTPS。注册后，若集团有特殊身份（例如老客）到店通知，优Mall后台将主动将到店信息push给该接口
        /// </summary>
        /// <param name="req"><see cref="RegisterCallbackRequest"/></param>
        /// <returns><see cref="RegisterCallbackResponse"/></returns>
        public async Task<RegisterCallbackResponse> RegisterCallback(RegisterCallbackRequest req)
        {
             JsonResponseModel<RegisterCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RegisterCallback接口的同步版本，调用本接口在优Mall中注册自己集团的到店通知回调接口地址，接口协议为HTTP或HTTPS。注册后，若集团有特殊身份（例如老客）到店通知，优Mall后台将主动将到店信息push给该接口
        /// </summary>
        /// <param name="req">参考<see cref="RegisterCallbackRequest"/></param>
        /// <returns>参考<see cref="RegisterCallbackResponse"/>实例</returns>
        public RegisterCallbackResponse RegisterCallbackSync(RegisterCallbackRequest req)
        {
             JsonResponseModel<RegisterCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
