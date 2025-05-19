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
       private const string sdkVersion = "SDK_NET_3.0.1242";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public YoumallClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建集团门店管理员账号
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount");
        }

        /// <summary>
        /// 创建集团门店管理员账号
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public CreateAccountResponse CreateAccountSync(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过上传指定规格的人脸图片，创建黑名单用户或者白名单用户。
        /// </summary>
        /// <param name="req"><see cref="CreateFacePictureRequest"/></param>
        /// <returns><see cref="CreateFacePictureResponse"/></returns>
        public Task<CreateFacePictureResponse> CreateFacePicture(CreateFacePictureRequest req)
        {
            return InternalRequestAsync<CreateFacePictureResponse>(req, "CreateFacePicture");
        }

        /// <summary>
        /// 通过上传指定规格的人脸图片，创建黑名单用户或者白名单用户。
        /// </summary>
        /// <param name="req"><see cref="CreateFacePictureRequest"/></param>
        /// <returns><see cref="CreateFacePictureResponse"/></returns>
        public CreateFacePictureResponse CreateFacePictureSync(CreateFacePictureRequest req)
        {
            return InternalRequestAsync<CreateFacePictureResponse>(req, "CreateFacePicture")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除顾客特征，仅支持删除黑名单或者白名单用户特征。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonFeatureRequest"/></param>
        /// <returns><see cref="DeletePersonFeatureResponse"/></returns>
        public Task<DeletePersonFeatureResponse> DeletePersonFeature(DeletePersonFeatureRequest req)
        {
            return InternalRequestAsync<DeletePersonFeatureResponse>(req, "DeletePersonFeature");
        }

        /// <summary>
        /// 删除顾客特征，仅支持删除黑名单或者白名单用户特征。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonFeatureRequest"/></param>
        /// <returns><see cref="DeletePersonFeatureResponse"/></returns>
        public DeletePersonFeatureResponse DeletePersonFeatureSync(DeletePersonFeatureRequest req)
        {
            return InternalRequestAsync<DeletePersonFeatureResponse>(req, "DeletePersonFeature")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过指定设备ID和指定时段，获取该时段内中收银台摄像设备抓取到顾客头像及身份ID
        /// </summary>
        /// <param name="req"><see cref="DescribeCameraPersonRequest"/></param>
        /// <returns><see cref="DescribeCameraPersonResponse"/></returns>
        public Task<DescribeCameraPersonResponse> DescribeCameraPerson(DescribeCameraPersonRequest req)
        {
            return InternalRequestAsync<DescribeCameraPersonResponse>(req, "DescribeCameraPerson");
        }

        /// <summary>
        /// 通过指定设备ID和指定时段，获取该时段内中收银台摄像设备抓取到顾客头像及身份ID
        /// </summary>
        /// <param name="req"><see cref="DescribeCameraPersonRequest"/></param>
        /// <returns><see cref="DescribeCameraPersonResponse"/></returns>
        public DescribeCameraPersonResponse DescribeCameraPersonSync(DescribeCameraPersonRequest req)
        {
            return InternalRequestAsync<DescribeCameraPersonResponse>(req, "DescribeCameraPerson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 输出开始时间到结束时间段内的进出场数据。按天聚合的情况下，每天多次进出场算一次，以最初进场时间为进场时间，最后离场时间为离场时间。停留时间为多次进出场的停留时间之和。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPersonArrivedMallRequest"/></param>
        /// <returns><see cref="DescribeClusterPersonArrivedMallResponse"/></returns>
        public Task<DescribeClusterPersonArrivedMallResponse> DescribeClusterPersonArrivedMall(DescribeClusterPersonArrivedMallRequest req)
        {
            return InternalRequestAsync<DescribeClusterPersonArrivedMallResponse>(req, "DescribeClusterPersonArrivedMall");
        }

        /// <summary>
        /// 输出开始时间到结束时间段内的进出场数据。按天聚合的情况下，每天多次进出场算一次，以最初进场时间为进场时间，最后离场时间为离场时间。停留时间为多次进出场的停留时间之和。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPersonArrivedMallRequest"/></param>
        /// <returns><see cref="DescribeClusterPersonArrivedMallResponse"/></returns>
        public DescribeClusterPersonArrivedMallResponse DescribeClusterPersonArrivedMallSync(DescribeClusterPersonArrivedMallRequest req)
        {
            return InternalRequestAsync<DescribeClusterPersonArrivedMallResponse>(req, "DescribeClusterPersonArrivedMall")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 输出开始时间到结束时间段内的进出场数据。按天聚合的情况下，每天多次进出场算一次，以最初进场时间为进场时间，最后离场时间为离场时间。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPersonTraceRequest"/></param>
        /// <returns><see cref="DescribeClusterPersonTraceResponse"/></returns>
        public Task<DescribeClusterPersonTraceResponse> DescribeClusterPersonTrace(DescribeClusterPersonTraceRequest req)
        {
            return InternalRequestAsync<DescribeClusterPersonTraceResponse>(req, "DescribeClusterPersonTrace");
        }

        /// <summary>
        /// 输出开始时间到结束时间段内的进出场数据。按天聚合的情况下，每天多次进出场算一次，以最初进场时间为进场时间，最后离场时间为离场时间。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPersonTraceRequest"/></param>
        /// <returns><see cref="DescribeClusterPersonTraceResponse"/></returns>
        public DescribeClusterPersonTraceResponse DescribeClusterPersonTraceSync(DescribeClusterPersonTraceRequest req)
        {
            return InternalRequestAsync<DescribeClusterPersonTraceResponse>(req, "DescribeClusterPersonTrace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过DescribeCameraPerson接口上报的收银台身份ID查询顾客的FaceID。查询最佳时间为收银台上报的次日1点后。
        /// </summary>
        /// <param name="req"><see cref="DescribeFaceIdByTempIdRequest"/></param>
        /// <returns><see cref="DescribeFaceIdByTempIdResponse"/></returns>
        public Task<DescribeFaceIdByTempIdResponse> DescribeFaceIdByTempId(DescribeFaceIdByTempIdRequest req)
        {
            return InternalRequestAsync<DescribeFaceIdByTempIdResponse>(req, "DescribeFaceIdByTempId");
        }

        /// <summary>
        /// 通过DescribeCameraPerson接口上报的收银台身份ID查询顾客的FaceID。查询最佳时间为收银台上报的次日1点后。
        /// </summary>
        /// <param name="req"><see cref="DescribeFaceIdByTempIdRequest"/></param>
        /// <returns><see cref="DescribeFaceIdByTempIdResponse"/></returns>
        public DescribeFaceIdByTempIdResponse DescribeFaceIdByTempIdSync(DescribeFaceIdByTempIdRequest req)
        {
            return InternalRequestAsync<DescribeFaceIdByTempIdResponse>(req, "DescribeFaceIdByTempId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回当前门店历史网络状态数据
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryNetworkInfoRequest"/></param>
        /// <returns><see cref="DescribeHistoryNetworkInfoResponse"/></returns>
        public Task<DescribeHistoryNetworkInfoResponse> DescribeHistoryNetworkInfo(DescribeHistoryNetworkInfoRequest req)
        {
            return InternalRequestAsync<DescribeHistoryNetworkInfoResponse>(req, "DescribeHistoryNetworkInfo");
        }

        /// <summary>
        /// 返回当前门店历史网络状态数据
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryNetworkInfoRequest"/></param>
        /// <returns><see cref="DescribeHistoryNetworkInfoResponse"/></returns>
        public DescribeHistoryNetworkInfoResponse DescribeHistoryNetworkInfoSync(DescribeHistoryNetworkInfoRequest req)
        {
            return InternalRequestAsync<DescribeHistoryNetworkInfoResponse>(req, "DescribeHistoryNetworkInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回当前门店最新网络状态数据
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInfoRequest"/></param>
        /// <returns><see cref="DescribeNetworkInfoResponse"/></returns>
        public Task<DescribeNetworkInfoResponse> DescribeNetworkInfo(DescribeNetworkInfoRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInfoResponse>(req, "DescribeNetworkInfo");
        }

        /// <summary>
        /// 返回当前门店最新网络状态数据
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInfoRequest"/></param>
        /// <returns><see cref="DescribeNetworkInfoResponse"/></returns>
        public DescribeNetworkInfoResponse DescribeNetworkInfoSync(DescribeNetworkInfoRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInfoResponse>(req, "DescribeNetworkInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定某一卖场的用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribePersonRequest"/></param>
        /// <returns><see cref="DescribePersonResponse"/></returns>
        public Task<DescribePersonResponse> DescribePerson(DescribePersonRequest req)
        {
            return InternalRequestAsync<DescribePersonResponse>(req, "DescribePerson");
        }

        /// <summary>
        /// 查询指定某一卖场的用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribePersonRequest"/></param>
        /// <returns><see cref="DescribePersonResponse"/></returns>
        public DescribePersonResponse DescribePersonSync(DescribePersonRequest req)
        {
            return InternalRequestAsync<DescribePersonResponse>(req, "DescribePerson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 输出开始时间到结束时间段内的进出场数据。不做按天聚合的情况下，每次进出场，产生一条进出场数据。
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribePersonArrivedMallRequest"/></param>
        /// <returns><see cref="DescribePersonArrivedMallResponse"/></returns>
        public Task<DescribePersonArrivedMallResponse> DescribePersonArrivedMall(DescribePersonArrivedMallRequest req)
        {
            return InternalRequestAsync<DescribePersonArrivedMallResponse>(req, "DescribePersonArrivedMall");
        }

        /// <summary>
        /// 输出开始时间到结束时间段内的进出场数据。不做按天聚合的情况下，每次进出场，产生一条进出场数据。
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribePersonArrivedMallRequest"/></param>
        /// <returns><see cref="DescribePersonArrivedMallResponse"/></returns>
        public DescribePersonArrivedMallResponse DescribePersonArrivedMallSync(DescribePersonArrivedMallRequest req)
        {
            return InternalRequestAsync<DescribePersonArrivedMallResponse>(req, "DescribePersonArrivedMall")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 指定门店获取所有顾客详情列表，包含客户ID、图片、年龄、性别
        /// </summary>
        /// <param name="req"><see cref="DescribePersonInfoRequest"/></param>
        /// <returns><see cref="DescribePersonInfoResponse"/></returns>
        public Task<DescribePersonInfoResponse> DescribePersonInfo(DescribePersonInfoRequest req)
        {
            return InternalRequestAsync<DescribePersonInfoResponse>(req, "DescribePersonInfo");
        }

        /// <summary>
        /// 指定门店获取所有顾客详情列表，包含客户ID、图片、年龄、性别
        /// </summary>
        /// <param name="req"><see cref="DescribePersonInfoRequest"/></param>
        /// <returns><see cref="DescribePersonInfoResponse"/></returns>
        public DescribePersonInfoResponse DescribePersonInfoSync(DescribePersonInfoRequest req)
        {
            return InternalRequestAsync<DescribePersonInfoResponse>(req, "DescribePersonInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过上传人脸图片检索系统face id、顾客身份信息及底图
        /// </summary>
        /// <param name="req"><see cref="DescribePersonInfoByFacePictureRequest"/></param>
        /// <returns><see cref="DescribePersonInfoByFacePictureResponse"/></returns>
        public Task<DescribePersonInfoByFacePictureResponse> DescribePersonInfoByFacePicture(DescribePersonInfoByFacePictureRequest req)
        {
            return InternalRequestAsync<DescribePersonInfoByFacePictureResponse>(req, "DescribePersonInfoByFacePicture");
        }

        /// <summary>
        /// 通过上传人脸图片检索系统face id、顾客身份信息及底图
        /// </summary>
        /// <param name="req"><see cref="DescribePersonInfoByFacePictureRequest"/></param>
        /// <returns><see cref="DescribePersonInfoByFacePictureResponse"/></returns>
        public DescribePersonInfoByFacePictureResponse DescribePersonInfoByFacePictureSync(DescribePersonInfoByFacePictureRequest req)
        {
            return InternalRequestAsync<DescribePersonInfoByFacePictureResponse>(req, "DescribePersonInfoByFacePicture")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 输出开始时间到结束时间段内的进出场数据。
        /// </summary>
        /// <param name="req"><see cref="DescribePersonTraceRequest"/></param>
        /// <returns><see cref="DescribePersonTraceResponse"/></returns>
        public Task<DescribePersonTraceResponse> DescribePersonTrace(DescribePersonTraceRequest req)
        {
            return InternalRequestAsync<DescribePersonTraceResponse>(req, "DescribePersonTrace");
        }

        /// <summary>
        /// 输出开始时间到结束时间段内的进出场数据。
        /// </summary>
        /// <param name="req"><see cref="DescribePersonTraceRequest"/></param>
        /// <returns><see cref="DescribePersonTraceResponse"/></returns>
        public DescribePersonTraceResponse DescribePersonTraceSync(DescribePersonTraceRequest req)
        {
            return InternalRequestAsync<DescribePersonTraceResponse>(req, "DescribePersonTrace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询客户单次到场轨迹明细
        /// </summary>
        /// <param name="req"><see cref="DescribePersonTraceDetailRequest"/></param>
        /// <returns><see cref="DescribePersonTraceDetailResponse"/></returns>
        public Task<DescribePersonTraceDetailResponse> DescribePersonTraceDetail(DescribePersonTraceDetailRequest req)
        {
            return InternalRequestAsync<DescribePersonTraceDetailResponse>(req, "DescribePersonTraceDetail");
        }

        /// <summary>
        /// 查询客户单次到场轨迹明细
        /// </summary>
        /// <param name="req"><see cref="DescribePersonTraceDetailRequest"/></param>
        /// <returns><see cref="DescribePersonTraceDetailResponse"/></returns>
        public DescribePersonTraceDetailResponse DescribePersonTraceDetailSync(DescribePersonTraceDetailRequest req)
        {
            return InternalRequestAsync<DescribePersonTraceDetailResponse>(req, "DescribePersonTraceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取门店指定时间范围内的所有用户到访信息记录，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req"><see cref="DescribePersonVisitInfoRequest"/></param>
        /// <returns><see cref="DescribePersonVisitInfoResponse"/></returns>
        public Task<DescribePersonVisitInfoResponse> DescribePersonVisitInfo(DescribePersonVisitInfoRequest req)
        {
            return InternalRequestAsync<DescribePersonVisitInfoResponse>(req, "DescribePersonVisitInfo");
        }

        /// <summary>
        /// 获取门店指定时间范围内的所有用户到访信息记录，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req"><see cref="DescribePersonVisitInfoRequest"/></param>
        /// <returns><see cref="DescribePersonVisitInfoResponse"/></returns>
        public DescribePersonVisitInfoResponse DescribePersonVisitInfoSync(DescribePersonVisitInfoRequest req)
        {
            return InternalRequestAsync<DescribePersonVisitInfoResponse>(req, "DescribePersonVisitInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按小时提供查询日期范围内门店的每天每小时累计客流人数数据，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req"><see cref="DescribeShopHourTrafficInfoRequest"/></param>
        /// <returns><see cref="DescribeShopHourTrafficInfoResponse"/></returns>
        public Task<DescribeShopHourTrafficInfoResponse> DescribeShopHourTrafficInfo(DescribeShopHourTrafficInfoRequest req)
        {
            return InternalRequestAsync<DescribeShopHourTrafficInfoResponse>(req, "DescribeShopHourTrafficInfo");
        }

        /// <summary>
        /// 按小时提供查询日期范围内门店的每天每小时累计客流人数数据，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req"><see cref="DescribeShopHourTrafficInfoRequest"/></param>
        /// <returns><see cref="DescribeShopHourTrafficInfoResponse"/></returns>
        public DescribeShopHourTrafficInfoResponse DescribeShopHourTrafficInfoSync(DescribeShopHourTrafficInfoRequest req)
        {
            return InternalRequestAsync<DescribeShopHourTrafficInfoResponse>(req, "DescribeShopHourTrafficInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据客户身份标识获取客户下所有的门店信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeShopInfoRequest"/></param>
        /// <returns><see cref="DescribeShopInfoResponse"/></returns>
        public Task<DescribeShopInfoResponse> DescribeShopInfo(DescribeShopInfoRequest req)
        {
            return InternalRequestAsync<DescribeShopInfoResponse>(req, "DescribeShopInfo");
        }

        /// <summary>
        /// 根据客户身份标识获取客户下所有的门店信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeShopInfoRequest"/></param>
        /// <returns><see cref="DescribeShopInfoResponse"/></returns>
        public DescribeShopInfoResponse DescribeShopInfoSync(DescribeShopInfoRequest req)
        {
            return InternalRequestAsync<DescribeShopInfoResponse>(req, "DescribeShopInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按天提供查询日期范围内门店的单日累计客流人数，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req"><see cref="DescribeShopTrafficInfoRequest"/></param>
        /// <returns><see cref="DescribeShopTrafficInfoResponse"/></returns>
        public Task<DescribeShopTrafficInfoResponse> DescribeShopTrafficInfo(DescribeShopTrafficInfoRequest req)
        {
            return InternalRequestAsync<DescribeShopTrafficInfoResponse>(req, "DescribeShopTrafficInfo");
        }

        /// <summary>
        /// 按天提供查询日期范围内门店的单日累计客流人数，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req"><see cref="DescribeShopTrafficInfoRequest"/></param>
        /// <returns><see cref="DescribeShopTrafficInfoResponse"/></returns>
        public DescribeShopTrafficInfoResponse DescribeShopTrafficInfoSync(DescribeShopTrafficInfoRequest req)
        {
            return InternalRequestAsync<DescribeShopTrafficInfoResponse>(req, "DescribeShopTrafficInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取动线轨迹信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTrajectoryDataRequest"/></param>
        /// <returns><see cref="DescribeTrajectoryDataResponse"/></returns>
        public Task<DescribeTrajectoryDataResponse> DescribeTrajectoryData(DescribeTrajectoryDataRequest req)
        {
            return InternalRequestAsync<DescribeTrajectoryDataResponse>(req, "DescribeTrajectoryData");
        }

        /// <summary>
        /// 获取动线轨迹信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTrajectoryDataRequest"/></param>
        /// <returns><see cref="DescribeTrajectoryDataResponse"/></returns>
        public DescribeTrajectoryDataResponse DescribeTrajectoryDataSync(DescribeTrajectoryDataRequest req)
        {
            return InternalRequestAsync<DescribeTrajectoryDataResponse>(req, "DescribeTrajectoryData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定区域人流各年龄占比
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowAgeInfoByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowAgeInfoByZoneIdResponse"/></returns>
        public Task<DescribeZoneFlowAgeInfoByZoneIdResponse> DescribeZoneFlowAgeInfoByZoneId(DescribeZoneFlowAgeInfoByZoneIdRequest req)
        {
            return InternalRequestAsync<DescribeZoneFlowAgeInfoByZoneIdResponse>(req, "DescribeZoneFlowAgeInfoByZoneId");
        }

        /// <summary>
        /// 获取指定区域人流各年龄占比
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowAgeInfoByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowAgeInfoByZoneIdResponse"/></returns>
        public DescribeZoneFlowAgeInfoByZoneIdResponse DescribeZoneFlowAgeInfoByZoneIdSync(DescribeZoneFlowAgeInfoByZoneIdRequest req)
        {
            return InternalRequestAsync<DescribeZoneFlowAgeInfoByZoneIdResponse>(req, "DescribeZoneFlowAgeInfoByZoneId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取区域人流和停留时间
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowAndStayTimeRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowAndStayTimeResponse"/></returns>
        public Task<DescribeZoneFlowAndStayTimeResponse> DescribeZoneFlowAndStayTime(DescribeZoneFlowAndStayTimeRequest req)
        {
            return InternalRequestAsync<DescribeZoneFlowAndStayTimeResponse>(req, "DescribeZoneFlowAndStayTime");
        }

        /// <summary>
        /// 获取区域人流和停留时间
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowAndStayTimeRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowAndStayTimeResponse"/></returns>
        public DescribeZoneFlowAndStayTimeResponse DescribeZoneFlowAndStayTimeSync(DescribeZoneFlowAndStayTimeRequest req)
        {
            return InternalRequestAsync<DescribeZoneFlowAndStayTimeResponse>(req, "DescribeZoneFlowAndStayTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定区域每日客流量
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowDailyByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowDailyByZoneIdResponse"/></returns>
        public Task<DescribeZoneFlowDailyByZoneIdResponse> DescribeZoneFlowDailyByZoneId(DescribeZoneFlowDailyByZoneIdRequest req)
        {
            return InternalRequestAsync<DescribeZoneFlowDailyByZoneIdResponse>(req, "DescribeZoneFlowDailyByZoneId");
        }

        /// <summary>
        /// 获取指定区域每日客流量
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowDailyByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowDailyByZoneIdResponse"/></returns>
        public DescribeZoneFlowDailyByZoneIdResponse DescribeZoneFlowDailyByZoneIdSync(DescribeZoneFlowDailyByZoneIdRequest req)
        {
            return InternalRequestAsync<DescribeZoneFlowDailyByZoneIdResponse>(req, "DescribeZoneFlowDailyByZoneId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定区域不同年龄段男女平均停留时间
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowGenderAvrStayTimeByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse"/></returns>
        public Task<DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse> DescribeZoneFlowGenderAvrStayTimeByZoneId(DescribeZoneFlowGenderAvrStayTimeByZoneIdRequest req)
        {
            return InternalRequestAsync<DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse>(req, "DescribeZoneFlowGenderAvrStayTimeByZoneId");
        }

        /// <summary>
        /// 获取指定区域不同年龄段男女平均停留时间
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowGenderAvrStayTimeByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse"/></returns>
        public DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse DescribeZoneFlowGenderAvrStayTimeByZoneIdSync(DescribeZoneFlowGenderAvrStayTimeByZoneIdRequest req)
        {
            return InternalRequestAsync<DescribeZoneFlowGenderAvrStayTimeByZoneIdResponse>(req, "DescribeZoneFlowGenderAvrStayTimeByZoneId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定区域性别占比
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowGenderInfoByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowGenderInfoByZoneIdResponse"/></returns>
        public Task<DescribeZoneFlowGenderInfoByZoneIdResponse> DescribeZoneFlowGenderInfoByZoneId(DescribeZoneFlowGenderInfoByZoneIdRequest req)
        {
            return InternalRequestAsync<DescribeZoneFlowGenderInfoByZoneIdResponse>(req, "DescribeZoneFlowGenderInfoByZoneId");
        }

        /// <summary>
        /// 获取指定区域性别占比
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowGenderInfoByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowGenderInfoByZoneIdResponse"/></returns>
        public DescribeZoneFlowGenderInfoByZoneIdResponse DescribeZoneFlowGenderInfoByZoneIdSync(DescribeZoneFlowGenderInfoByZoneIdRequest req)
        {
            return InternalRequestAsync<DescribeZoneFlowGenderInfoByZoneIdResponse>(req, "DescribeZoneFlowGenderInfoByZoneId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定区域分时客流量
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowHourlyByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowHourlyByZoneIdResponse"/></returns>
        public Task<DescribeZoneFlowHourlyByZoneIdResponse> DescribeZoneFlowHourlyByZoneId(DescribeZoneFlowHourlyByZoneIdRequest req)
        {
            return InternalRequestAsync<DescribeZoneFlowHourlyByZoneIdResponse>(req, "DescribeZoneFlowHourlyByZoneId");
        }

        /// <summary>
        /// 获取指定区域分时客流量
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneFlowHourlyByZoneIdRequest"/></param>
        /// <returns><see cref="DescribeZoneFlowHourlyByZoneIdResponse"/></returns>
        public DescribeZoneFlowHourlyByZoneIdResponse DescribeZoneFlowHourlyByZoneIdSync(DescribeZoneFlowHourlyByZoneIdRequest req)
        {
            return InternalRequestAsync<DescribeZoneFlowHourlyByZoneIdResponse>(req, "DescribeZoneFlowHourlyByZoneId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按天提供查询日期范围内，客户指定门店下的所有区域（优Mall部署时已配置区域）的累计客流人次和平均停留时间。支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneTrafficInfoRequest"/></param>
        /// <returns><see cref="DescribeZoneTrafficInfoResponse"/></returns>
        public Task<DescribeZoneTrafficInfoResponse> DescribeZoneTrafficInfo(DescribeZoneTrafficInfoRequest req)
        {
            return InternalRequestAsync<DescribeZoneTrafficInfoResponse>(req, "DescribeZoneTrafficInfo");
        }

        /// <summary>
        /// 按天提供查询日期范围内，客户指定门店下的所有区域（优Mall部署时已配置区域）的累计客流人次和平均停留时间。支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneTrafficInfoRequest"/></param>
        /// <returns><see cref="DescribeZoneTrafficInfoResponse"/></returns>
        public DescribeZoneTrafficInfoResponse DescribeZoneTrafficInfoSync(DescribeZoneTrafficInfoRequest req)
        {
            return InternalRequestAsync<DescribeZoneTrafficInfoResponse>(req, "DescribeZoneTrafficInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 支持修改黑白名单类型的顾客特征
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonFeatureInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonFeatureInfoResponse"/></returns>
        public Task<ModifyPersonFeatureInfoResponse> ModifyPersonFeatureInfo(ModifyPersonFeatureInfoRequest req)
        {
            return InternalRequestAsync<ModifyPersonFeatureInfoResponse>(req, "ModifyPersonFeatureInfo");
        }

        /// <summary>
        /// 支持修改黑白名单类型的顾客特征
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonFeatureInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonFeatureInfoResponse"/></returns>
        public ModifyPersonFeatureInfoResponse ModifyPersonFeatureInfoSync(ModifyPersonFeatureInfoRequest req)
        {
            return InternalRequestAsync<ModifyPersonFeatureInfoResponse>(req, "ModifyPersonFeatureInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 标记到店顾客的身份类型，例如黑名单、白名单等
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonTagInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonTagInfoResponse"/></returns>
        public Task<ModifyPersonTagInfoResponse> ModifyPersonTagInfo(ModifyPersonTagInfoRequest req)
        {
            return InternalRequestAsync<ModifyPersonTagInfoResponse>(req, "ModifyPersonTagInfo");
        }

        /// <summary>
        /// 标记到店顾客的身份类型，例如黑名单、白名单等
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonTagInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonTagInfoResponse"/></returns>
        public ModifyPersonTagInfoResponse ModifyPersonTagInfoSync(ModifyPersonTagInfoRequest req)
        {
            return InternalRequestAsync<ModifyPersonTagInfoResponse>(req, "ModifyPersonTagInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改顾客身份类型接口
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonTypeRequest"/></param>
        /// <returns><see cref="ModifyPersonTypeResponse"/></returns>
        public Task<ModifyPersonTypeResponse> ModifyPersonType(ModifyPersonTypeRequest req)
        {
            return InternalRequestAsync<ModifyPersonTypeResponse>(req, "ModifyPersonType");
        }

        /// <summary>
        /// 修改顾客身份类型接口
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonTypeRequest"/></param>
        /// <returns><see cref="ModifyPersonTypeResponse"/></returns>
        public ModifyPersonTypeResponse ModifyPersonTypeSync(ModifyPersonTypeRequest req)
        {
            return InternalRequestAsync<ModifyPersonTypeResponse>(req, "ModifyPersonType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用本接口在优Mall中注册自己集团的到店通知回调接口地址，接口协议为HTTP或HTTPS。注册后，若集团有特殊身份（例如老客）到店通知，优Mall后台将主动将到店信息push给该接口
        /// </summary>
        /// <param name="req"><see cref="RegisterCallbackRequest"/></param>
        /// <returns><see cref="RegisterCallbackResponse"/></returns>
        public Task<RegisterCallbackResponse> RegisterCallback(RegisterCallbackRequest req)
        {
            return InternalRequestAsync<RegisterCallbackResponse>(req, "RegisterCallback");
        }

        /// <summary>
        /// 调用本接口在优Mall中注册自己集团的到店通知回调接口地址，接口协议为HTTP或HTTPS。注册后，若集团有特殊身份（例如老客）到店通知，优Mall后台将主动将到店信息push给该接口
        /// </summary>
        /// <param name="req"><see cref="RegisterCallbackRequest"/></param>
        /// <returns><see cref="RegisterCallbackResponse"/></returns>
        public RegisterCallbackResponse RegisterCallbackSync(RegisterCallbackRequest req)
        {
            return InternalRequestAsync<RegisterCallbackResponse>(req, "RegisterCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
