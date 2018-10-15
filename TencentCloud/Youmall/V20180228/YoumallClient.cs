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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public YoumallClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public YoumallClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建集团门店管理员账号
        /// </summary>
        /// <param name="req">参考<see cref="CreateAccountRequest"/></param>
        /// <returns>参考<see cref="CreateAccountResponse"/>实例</returns>
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
        /// 上传人脸图片
        /// </summary>
        /// <param name="req">参考<see cref="CreateFacePictureRequest"/></param>
        /// <returns>参考<see cref="CreateFacePictureResponse"/>实例</returns>
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
        /// 通过指定设备ID和指定时段，获取该时段内中收银台摄像设备抓取到顾客头像及身份ID
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCameraPersonRequest"/></param>
        /// <returns>参考<see cref="DescribeCameraPersonResponse"/>实例</returns>
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
        /// 通过DescribeCameraPerson接口上报的收银台身份ID查询顾客的FaceID。查询最佳时间为收银台上报的次日1点后。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFaceIdByTempIdRequest"/></param>
        /// <returns>参考<see cref="DescribeFaceIdByTempIdResponse"/>实例</returns>
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
        /// 返回当前门店历史网络状态数据
        /// </summary>
        /// <param name="req">参考<see cref="DescribeHistoryNetworkInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeHistoryNetworkInfoResponse"/>实例</returns>
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
        /// 返回当前门店最新网络状态数据
        /// </summary>
        /// <param name="req">参考<see cref="DescribeNetworkInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeNetworkInfoResponse"/>实例</returns>
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
        /// 指定门店获取所有顾客详情列表，包含客户ID、图片、年龄、性别
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonInfoRequest"/></param>
        /// <returns>参考<see cref="DescribePersonInfoResponse"/>实例</returns>
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
        /// 获取门店指定时间范围内的所有用户到访信息记录，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonVisitInfoRequest"/></param>
        /// <returns>参考<see cref="DescribePersonVisitInfoResponse"/>实例</returns>
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
        /// 按小时提供查询日期范围内门店的每天每小时累计客流人数数据，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeShopHourTrafficInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeShopHourTrafficInfoResponse"/>实例</returns>
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
        /// 根据客户身份标识获取客户下所有的门店信息列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeShopInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeShopInfoResponse"/>实例</returns>
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
        /// 按天提供查询日期范围内门店的单日累计客流人数，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeShopTrafficInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeShopTrafficInfoResponse"/>实例</returns>
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
        /// 获取动线轨迹信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTrajectoryDataRequest"/></param>
        /// <returns>参考<see cref="DescribeTrajectoryDataResponse"/>实例</returns>
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
        /// 获取指定区域人流各年龄占比
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneFlowAgeInfoByZoneIdRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneFlowAgeInfoByZoneIdResponse"/>实例</returns>
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
        /// 获取区域人流和停留时间
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneFlowAndStayTimeRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneFlowAndStayTimeResponse"/>实例</returns>
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
        /// 获取指定区域每日客流量
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneFlowDailyByZoneIdRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneFlowDailyByZoneIdResponse"/>实例</returns>
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
        /// 获取指定区域不同年龄段男女平均停留时间
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneFlowGenderAvrStayTimeByZoneIdRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse"/>实例</returns>
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
        /// 获取指定区域性别占比
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneFlowGenderInfoByZoneIdRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneFlowGenderInfoByZoneIdResponse"/>实例</returns>
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
        /// 获取指定区域分时客流量
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneFlowHourlyByZoneIdRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneFlowHourlyByZoneIdResponse"/>实例</returns>
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
        /// 按天提供查询日期范围内，客户指定门店下的所有区域（优Mall部署时已配置区域）的累计客流人次和平均停留时间。支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneTrafficInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneTrafficInfoResponse"/>实例</returns>
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
        /// 标记到店顾客的身份类型，例如黑名单、白名单等
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPersonTagInfoRequest"/></param>
        /// <returns>参考<see cref="ModifyPersonTagInfoResponse"/>实例</returns>
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
        /// 调用本接口在优Mall中注册自己集团的到店通知回调接口地址，接口协议为HTTP或HTTPS。注册后，若集团有特殊身份（例如老客）到店通知，优Mall后台将主动将到店信息push给该接口
        /// </summary>
        /// <param name="req">参考<see cref="RegisterCallbackRequest"/></param>
        /// <returns>参考<see cref="RegisterCallbackResponse"/>实例</returns>
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

    }
}
