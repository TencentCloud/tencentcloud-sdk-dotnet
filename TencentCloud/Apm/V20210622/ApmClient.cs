/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Apm.V20210622
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Apm.V20210622.Models;

   public class ApmClient : AbstractClient{

       private const string endpoint = "apm.tencentcloudapi.com";
       private const string version = "2021-06-22";
       private const string sdkVersion = "SDK_NET_3.0.1375";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ApmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 业务购买 APM 业务系统，调用该接口创建
        /// </summary>
        /// <param name="req"><see cref="CreateApmInstanceRequest"/></param>
        /// <returns><see cref="CreateApmInstanceResponse"/></returns>
        public Task<CreateApmInstanceResponse> CreateApmInstance(CreateApmInstanceRequest req)
        {
            return InternalRequestAsync<CreateApmInstanceResponse>(req, "CreateApmInstance");
        }

        /// <summary>
        /// 业务购买 APM 业务系统，调用该接口创建
        /// </summary>
        /// <param name="req"><see cref="CreateApmInstanceRequest"/></param>
        /// <returns><see cref="CreateApmInstanceResponse"/></returns>
        public CreateApmInstanceResponse CreateApmInstanceSync(CreateApmInstanceRequest req)
        {
            return InternalRequestAsync<CreateApmInstanceResponse>(req, "CreateApmInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建apm业务系统与Prometheus实例的指标匹配规则
        /// </summary>
        /// <param name="req"><see cref="CreateApmPrometheusRuleRequest"/></param>
        /// <returns><see cref="CreateApmPrometheusRuleResponse"/></returns>
        public Task<CreateApmPrometheusRuleResponse> CreateApmPrometheusRule(CreateApmPrometheusRuleRequest req)
        {
            return InternalRequestAsync<CreateApmPrometheusRuleResponse>(req, "CreateApmPrometheusRule");
        }

        /// <summary>
        /// 用于创建apm业务系统与Prometheus实例的指标匹配规则
        /// </summary>
        /// <param name="req"><see cref="CreateApmPrometheusRuleRequest"/></param>
        /// <returns><see cref="CreateApmPrometheusRuleResponse"/></returns>
        public CreateApmPrometheusRuleResponse CreateApmPrometheusRuleSync(CreateApmPrometheusRuleRequest req)
        {
            return InternalRequestAsync<CreateApmPrometheusRuleResponse>(req, "CreateApmPrometheusRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建采样配置接口
        /// </summary>
        /// <param name="req"><see cref="CreateApmSampleConfigRequest"/></param>
        /// <returns><see cref="CreateApmSampleConfigResponse"/></returns>
        public Task<CreateApmSampleConfigResponse> CreateApmSampleConfig(CreateApmSampleConfigRequest req)
        {
            return InternalRequestAsync<CreateApmSampleConfigResponse>(req, "CreateApmSampleConfig");
        }

        /// <summary>
        /// 创建采样配置接口
        /// </summary>
        /// <param name="req"><see cref="CreateApmSampleConfigRequest"/></param>
        /// <returns><see cref="CreateApmSampleConfigResponse"/></returns>
        public CreateApmSampleConfigResponse CreateApmSampleConfigSync(CreateApmSampleConfigRequest req)
        {
            return InternalRequestAsync<CreateApmSampleConfigResponse>(req, "CreateApmSampleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建事件任务
        /// </summary>
        /// <param name="req"><see cref="CreateProfileTaskRequest"/></param>
        /// <returns><see cref="CreateProfileTaskResponse"/></returns>
        public Task<CreateProfileTaskResponse> CreateProfileTask(CreateProfileTaskRequest req)
        {
            return InternalRequestAsync<CreateProfileTaskResponse>(req, "CreateProfileTask");
        }

        /// <summary>
        /// 创建事件任务
        /// </summary>
        /// <param name="req"><see cref="CreateProfileTaskRequest"/></param>
        /// <returns><see cref="CreateProfileTaskResponse"/></returns>
        public CreateProfileTaskResponse CreateProfileTaskSync(CreateProfileTaskRequest req)
        {
            return InternalRequestAsync<CreateProfileTaskResponse>(req, "CreateProfileTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除采样配置接口
        /// </summary>
        /// <param name="req"><see cref="DeleteApmSampleConfigRequest"/></param>
        /// <returns><see cref="DeleteApmSampleConfigResponse"/></returns>
        public Task<DeleteApmSampleConfigResponse> DeleteApmSampleConfig(DeleteApmSampleConfigRequest req)
        {
            return InternalRequestAsync<DeleteApmSampleConfigResponse>(req, "DeleteApmSampleConfig");
        }

        /// <summary>
        /// 删除采样配置接口
        /// </summary>
        /// <param name="req"><see cref="DeleteApmSampleConfigRequest"/></param>
        /// <returns><see cref="DeleteApmSampleConfigResponse"/></returns>
        public DeleteApmSampleConfigResponse DeleteApmSampleConfigSync(DeleteApmSampleConfigRequest req)
        {
            return InternalRequestAsync<DeleteApmSampleConfigResponse>(req, "DeleteApmSampleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 APM 接入点
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAgentRequest"/></param>
        /// <returns><see cref="DescribeApmAgentResponse"/></returns>
        public Task<DescribeApmAgentResponse> DescribeApmAgent(DescribeApmAgentRequest req)
        {
            return InternalRequestAsync<DescribeApmAgentResponse>(req, "DescribeApmAgent");
        }

        /// <summary>
        /// 获取 APM 接入点
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAgentRequest"/></param>
        /// <returns><see cref="DescribeApmAgentResponse"/></returns>
        public DescribeApmAgentResponse DescribeApmAgentSync(DescribeApmAgentRequest req)
        {
            return InternalRequestAsync<DescribeApmAgentResponse>(req, "DescribeApmAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户所有漏洞信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAllVulCountRequest"/></param>
        /// <returns><see cref="DescribeApmAllVulCountResponse"/></returns>
        public Task<DescribeApmAllVulCountResponse> DescribeApmAllVulCount(DescribeApmAllVulCountRequest req)
        {
            return InternalRequestAsync<DescribeApmAllVulCountResponse>(req, "DescribeApmAllVulCount");
        }

        /// <summary>
        /// 查询用户所有漏洞信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAllVulCountRequest"/></param>
        /// <returns><see cref="DescribeApmAllVulCountResponse"/></returns>
        public DescribeApmAllVulCountResponse DescribeApmAllVulCountSync(DescribeApmAllVulCountRequest req)
        {
            return InternalRequestAsync<DescribeApmAllVulCountResponse>(req, "DescribeApmAllVulCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询应用配置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeApmApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeApmApplicationConfigResponse"/></returns>
        public Task<DescribeApmApplicationConfigResponse> DescribeApmApplicationConfig(DescribeApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeApmApplicationConfigResponse>(req, "DescribeApmApplicationConfig");
        }

        /// <summary>
        /// 查询应用配置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeApmApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeApmApplicationConfigResponse"/></returns>
        public DescribeApmApplicationConfigResponse DescribeApmApplicationConfigSync(DescribeApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeApmApplicationConfigResponse>(req, "DescribeApmApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询apm业务系统与其他产品的关联关系
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAssociationRequest"/></param>
        /// <returns><see cref="DescribeApmAssociationResponse"/></returns>
        public Task<DescribeApmAssociationResponse> DescribeApmAssociation(DescribeApmAssociationRequest req)
        {
            return InternalRequestAsync<DescribeApmAssociationResponse>(req, "DescribeApmAssociation");
        }

        /// <summary>
        /// 用于查询apm业务系统与其他产品的关联关系
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAssociationRequest"/></param>
        /// <returns><see cref="DescribeApmAssociationResponse"/></returns>
        public DescribeApmAssociationResponse DescribeApmAssociationSync(DescribeApmAssociationRequest req)
        {
            return InternalRequestAsync<DescribeApmAssociationResponse>(req, "DescribeApmAssociation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 APM 业务系统列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApmInstancesRequest"/></param>
        /// <returns><see cref="DescribeApmInstancesResponse"/></returns>
        public Task<DescribeApmInstancesResponse> DescribeApmInstances(DescribeApmInstancesRequest req)
        {
            return InternalRequestAsync<DescribeApmInstancesResponse>(req, "DescribeApmInstances");
        }

        /// <summary>
        /// 获取 APM 业务系统列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApmInstancesRequest"/></param>
        /// <returns><see cref="DescribeApmInstancesResponse"/></returns>
        public DescribeApmInstancesResponse DescribeApmInstancesSync(DescribeApmInstancesRequest req)
        {
            return InternalRequestAsync<DescribeApmInstancesResponse>(req, "DescribeApmInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询apm业务系统与Prometheus实例的指标匹配规则
        /// </summary>
        /// <param name="req"><see cref="DescribeApmPrometheusRuleRequest"/></param>
        /// <returns><see cref="DescribeApmPrometheusRuleResponse"/></returns>
        public Task<DescribeApmPrometheusRuleResponse> DescribeApmPrometheusRule(DescribeApmPrometheusRuleRequest req)
        {
            return InternalRequestAsync<DescribeApmPrometheusRuleResponse>(req, "DescribeApmPrometheusRule");
        }

        /// <summary>
        /// 用于查询apm业务系统与Prometheus实例的指标匹配规则
        /// </summary>
        /// <param name="req"><see cref="DescribeApmPrometheusRuleRequest"/></param>
        /// <returns><see cref="DescribeApmPrometheusRuleResponse"/></returns>
        public DescribeApmPrometheusRuleResponse DescribeApmPrometheusRuleSync(DescribeApmPrometheusRuleRequest req)
        {
            return InternalRequestAsync<DescribeApmPrometheusRuleResponse>(req, "DescribeApmPrometheusRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询采样配置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeApmSampleConfigRequest"/></param>
        /// <returns><see cref="DescribeApmSampleConfigResponse"/></returns>
        public Task<DescribeApmSampleConfigResponse> DescribeApmSampleConfig(DescribeApmSampleConfigRequest req)
        {
            return InternalRequestAsync<DescribeApmSampleConfigResponse>(req, "DescribeApmSampleConfig");
        }

        /// <summary>
        /// 查询采样配置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeApmSampleConfigRequest"/></param>
        /// <returns><see cref="DescribeApmSampleConfigResponse"/></returns>
        public DescribeApmSampleConfigResponse DescribeApmSampleConfigSync(DescribeApmSampleConfigRequest req)
        {
            return InternalRequestAsync<DescribeApmSampleConfigResponse>(req, "DescribeApmSampleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 APM 应用指标列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApmServiceMetricRequest"/></param>
        /// <returns><see cref="DescribeApmServiceMetricResponse"/></returns>
        public Task<DescribeApmServiceMetricResponse> DescribeApmServiceMetric(DescribeApmServiceMetricRequest req)
        {
            return InternalRequestAsync<DescribeApmServiceMetricResponse>(req, "DescribeApmServiceMetric");
        }

        /// <summary>
        /// 获取 APM 应用指标列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApmServiceMetricRequest"/></param>
        /// <returns><see cref="DescribeApmServiceMetricResponse"/></returns>
        public DescribeApmServiceMetricResponse DescribeApmServiceMetricSync(DescribeApmServiceMetricRequest req)
        {
            return InternalRequestAsync<DescribeApmServiceMetricResponse>(req, "DescribeApmServiceMetric")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询漏洞指标
        /// </summary>
        /// <param name="req"><see cref="DescribeApmVulnerabilityCountRequest"/></param>
        /// <returns><see cref="DescribeApmVulnerabilityCountResponse"/></returns>
        public Task<DescribeApmVulnerabilityCountResponse> DescribeApmVulnerabilityCount(DescribeApmVulnerabilityCountRequest req)
        {
            return InternalRequestAsync<DescribeApmVulnerabilityCountResponse>(req, "DescribeApmVulnerabilityCount");
        }

        /// <summary>
        /// 查询漏洞指标
        /// </summary>
        /// <param name="req"><see cref="DescribeApmVulnerabilityCountRequest"/></param>
        /// <returns><see cref="DescribeApmVulnerabilityCountResponse"/></returns>
        public DescribeApmVulnerabilityCountResponse DescribeApmVulnerabilityCountSync(DescribeApmVulnerabilityCountRequest req)
        {
            return InternalRequestAsync<DescribeApmVulnerabilityCountResponse>(req, "DescribeApmVulnerabilityCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询漏洞详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApmVulnerabilityDetailRequest"/></param>
        /// <returns><see cref="DescribeApmVulnerabilityDetailResponse"/></returns>
        public Task<DescribeApmVulnerabilityDetailResponse> DescribeApmVulnerabilityDetail(DescribeApmVulnerabilityDetailRequest req)
        {
            return InternalRequestAsync<DescribeApmVulnerabilityDetailResponse>(req, "DescribeApmVulnerabilityDetail");
        }

        /// <summary>
        /// 查询漏洞详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApmVulnerabilityDetailRequest"/></param>
        /// <returns><see cref="DescribeApmVulnerabilityDetailResponse"/></returns>
        public DescribeApmVulnerabilityDetailResponse DescribeApmVulnerabilityDetailSync(DescribeApmVulnerabilityDetailRequest req)
        {
            return InternalRequestAsync<DescribeApmVulnerabilityDetailResponse>(req, "DescribeApmVulnerabilityDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询应用配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralApmApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeGeneralApmApplicationConfigResponse"/></returns>
        public Task<DescribeGeneralApmApplicationConfigResponse> DescribeGeneralApmApplicationConfig(DescribeGeneralApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeGeneralApmApplicationConfigResponse>(req, "DescribeGeneralApmApplicationConfig");
        }

        /// <summary>
        /// 查询应用配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralApmApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeGeneralApmApplicationConfigResponse"/></returns>
        public DescribeGeneralApmApplicationConfigResponse DescribeGeneralApmApplicationConfigSync(DescribeGeneralApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeGeneralApmApplicationConfigResponse>(req, "DescribeGeneralApmApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指标数据通用接口。用户根据需要上送请求参数，返回对应的指标数据。
        /// 接口调用频率限制为：20次/秒，1200次/分钟。单请求的数据点数限制为1440个。
        /// 
        /// 获取指标数据通用接口用法：DescribeGeneralMetricData 是通用的指标数据查询接口，支持灵活的获取指标数据。该接口的查询方式类似于使用如下 SQL 语句：SELECT {Metrics} FROM {ViewName} WHERE {Filters} GROUP BY {GroupBy}。在发起请求前，请确定如下关键入参：
        /// 1. 视图（ViewName）
        /// 决定您要查询的数据领域。
        /// 例如：service_metric（服务监控视图）、db_metric（数据库视图）等。关于 APM 支持的视图，请参考 [指标视图](https://cloud.tencent.com/document/product/248/101681#069b06a9-2593-49db-b694-dea4200f3b19)。
        /// 
        /// 2. 指标（Metrics）
        /// 用于指定返回结果中包含的一个或多个指标项。
        /// 例如：request_count（请求数）、duration_avg（平均耗时）、error_rate（错误率）。关于APM 支持的指标，请参考 [APM 指标协议标准](https://cloud.tencent.com/document/product/248/101681)，每种视图（ViewName）支持专属的指标集。
        /// 3. 过滤（Filters）
        /// 支持一个或多个键值对（Key-Value）形式的过滤条件。
        /// 例如：只查某个特定服务 service.name = "order-service"。通用维度和每种视图（ViewName）支持专属专属维度，可以用作过滤条件中的键（Key），更多详情请参考 [APM 指标协议标准](https://cloud.tencent.com/document/product/248/101681)。
        /// 
        /// 4. 聚合（GroupBy）
        /// 支持一个或多个聚合维度，相当于 SQL 的 GROUP BY。
        /// 例如：按接口名称 operation 分组，查看每个接口的性能。通用维度和每种视图（ViewName）支持专属专属维度，可以用作聚合维度，更多详情请参考 [APM 指标协议标准](https://cloud.tencent.com/document/product/248/101681)。
        /// 5. 粒度 (Period) 
        /// 该参数决定了是否需要以时间切片聚合。
        ///     - Period = 1：时间序列模式：返回结果中按时间切片聚合，时间序列（TimeSerial）和数据序列（DataSerial）中包含的多个值一一对应，分别代表特定时间切片上的聚合结果。时间序列模式主要用于展示时间趋势图。
        ///     - Period = 0：汇总统计模式：返回结果中，数据序列（DataSerial）中只包含唯一的值，代表整个时间区间内的汇总数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralMetricDataRequest"/></param>
        /// <returns><see cref="DescribeGeneralMetricDataResponse"/></returns>
        public Task<DescribeGeneralMetricDataResponse> DescribeGeneralMetricData(DescribeGeneralMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeGeneralMetricDataResponse>(req, "DescribeGeneralMetricData");
        }

        /// <summary>
        /// 获取指标数据通用接口。用户根据需要上送请求参数，返回对应的指标数据。
        /// 接口调用频率限制为：20次/秒，1200次/分钟。单请求的数据点数限制为1440个。
        /// 
        /// 获取指标数据通用接口用法：DescribeGeneralMetricData 是通用的指标数据查询接口，支持灵活的获取指标数据。该接口的查询方式类似于使用如下 SQL 语句：SELECT {Metrics} FROM {ViewName} WHERE {Filters} GROUP BY {GroupBy}。在发起请求前，请确定如下关键入参：
        /// 1. 视图（ViewName）
        /// 决定您要查询的数据领域。
        /// 例如：service_metric（服务监控视图）、db_metric（数据库视图）等。关于 APM 支持的视图，请参考 [指标视图](https://cloud.tencent.com/document/product/248/101681#069b06a9-2593-49db-b694-dea4200f3b19)。
        /// 
        /// 2. 指标（Metrics）
        /// 用于指定返回结果中包含的一个或多个指标项。
        /// 例如：request_count（请求数）、duration_avg（平均耗时）、error_rate（错误率）。关于APM 支持的指标，请参考 [APM 指标协议标准](https://cloud.tencent.com/document/product/248/101681)，每种视图（ViewName）支持专属的指标集。
        /// 3. 过滤（Filters）
        /// 支持一个或多个键值对（Key-Value）形式的过滤条件。
        /// 例如：只查某个特定服务 service.name = "order-service"。通用维度和每种视图（ViewName）支持专属专属维度，可以用作过滤条件中的键（Key），更多详情请参考 [APM 指标协议标准](https://cloud.tencent.com/document/product/248/101681)。
        /// 
        /// 4. 聚合（GroupBy）
        /// 支持一个或多个聚合维度，相当于 SQL 的 GROUP BY。
        /// 例如：按接口名称 operation 分组，查看每个接口的性能。通用维度和每种视图（ViewName）支持专属专属维度，可以用作聚合维度，更多详情请参考 [APM 指标协议标准](https://cloud.tencent.com/document/product/248/101681)。
        /// 5. 粒度 (Period) 
        /// 该参数决定了是否需要以时间切片聚合。
        ///     - Period = 1：时间序列模式：返回结果中按时间切片聚合，时间序列（TimeSerial）和数据序列（DataSerial）中包含的多个值一一对应，分别代表特定时间切片上的聚合结果。时间序列模式主要用于展示时间趋势图。
        ///     - Period = 0：汇总统计模式：返回结果中，数据序列（DataSerial）中只包含唯一的值，代表整个时间区间内的汇总数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralMetricDataRequest"/></param>
        /// <returns><see cref="DescribeGeneralMetricDataResponse"/></returns>
        public DescribeGeneralMetricDataResponse DescribeGeneralMetricDataSync(DescribeGeneralMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeGeneralMetricDataResponse>(req, "DescribeGeneralMetricData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通用查询 OpenTelemetry 调用链列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralOTSpanListRequest"/></param>
        /// <returns><see cref="DescribeGeneralOTSpanListResponse"/></returns>
        public Task<DescribeGeneralOTSpanListResponse> DescribeGeneralOTSpanList(DescribeGeneralOTSpanListRequest req)
        {
            return InternalRequestAsync<DescribeGeneralOTSpanListResponse>(req, "DescribeGeneralOTSpanList");
        }

        /// <summary>
        /// 通用查询 OpenTelemetry 调用链列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralOTSpanListRequest"/></param>
        /// <returns><see cref="DescribeGeneralOTSpanListResponse"/></returns>
        public DescribeGeneralOTSpanListResponse DescribeGeneralOTSpanListSync(DescribeGeneralOTSpanListRequest req)
        {
            return InternalRequestAsync<DescribeGeneralOTSpanListResponse>(req, "DescribeGeneralOTSpanList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通用查询调用链列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralSpanListRequest"/></param>
        /// <returns><see cref="DescribeGeneralSpanListResponse"/></returns>
        public Task<DescribeGeneralSpanListResponse> DescribeGeneralSpanList(DescribeGeneralSpanListRequest req)
        {
            return InternalRequestAsync<DescribeGeneralSpanListResponse>(req, "DescribeGeneralSpanList");
        }

        /// <summary>
        /// 通用查询调用链列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralSpanListRequest"/></param>
        /// <returns><see cref="DescribeGeneralSpanListResponse"/></returns>
        public DescribeGeneralSpanListResponse DescribeGeneralSpanListSync(DescribeGeneralSpanListRequest req)
        {
            return InternalRequestAsync<DescribeGeneralSpanListResponse>(req, "DescribeGeneralSpanList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指标列表接口，查询指标更推荐使用DescribeGeneralMetricData接口
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricRecordsRequest"/></param>
        /// <returns><see cref="DescribeMetricRecordsResponse"/></returns>
        public Task<DescribeMetricRecordsResponse> DescribeMetricRecords(DescribeMetricRecordsRequest req)
        {
            return InternalRequestAsync<DescribeMetricRecordsResponse>(req, "DescribeMetricRecords");
        }

        /// <summary>
        /// 查询指标列表接口，查询指标更推荐使用DescribeGeneralMetricData接口
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricRecordsRequest"/></param>
        /// <returns><see cref="DescribeMetricRecordsResponse"/></returns>
        public DescribeMetricRecordsResponse DescribeMetricRecordsSync(DescribeMetricRecordsRequest req)
        {
            return InternalRequestAsync<DescribeMetricRecordsResponse>(req, "DescribeMetricRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户所有漏洞信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOPRAllVulCountRequest"/></param>
        /// <returns><see cref="DescribeOPRAllVulCountResponse"/></returns>
        public Task<DescribeOPRAllVulCountResponse> DescribeOPRAllVulCount(DescribeOPRAllVulCountRequest req)
        {
            return InternalRequestAsync<DescribeOPRAllVulCountResponse>(req, "DescribeOPRAllVulCount");
        }

        /// <summary>
        /// 查询用户所有漏洞信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOPRAllVulCountRequest"/></param>
        /// <returns><see cref="DescribeOPRAllVulCountResponse"/></returns>
        public DescribeOPRAllVulCountResponse DescribeOPRAllVulCountSync(DescribeOPRAllVulCountRequest req)
        {
            return InternalRequestAsync<DescribeOPRAllVulCountResponse>(req, "DescribeOPRAllVulCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 应用概览数据拉取
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceOverviewRequest"/></param>
        /// <returns><see cref="DescribeServiceOverviewResponse"/></returns>
        public Task<DescribeServiceOverviewResponse> DescribeServiceOverview(DescribeServiceOverviewRequest req)
        {
            return InternalRequestAsync<DescribeServiceOverviewResponse>(req, "DescribeServiceOverview");
        }

        /// <summary>
        /// 应用概览数据拉取
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceOverviewRequest"/></param>
        /// <returns><see cref="DescribeServiceOverviewResponse"/></returns>
        public DescribeServiceOverviewResponse DescribeServiceOverviewSync(DescribeServiceOverviewRequest req)
        {
            return InternalRequestAsync<DescribeServiceOverviewResponse>(req, "DescribeServiceOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据维度名和过滤条件，查询维度数据.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public Task<DescribeTagValuesResponse> DescribeTagValues(DescribeTagValuesRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesResponse>(req, "DescribeTagValues");
        }

        /// <summary>
        /// 根据维度名和过滤条件，查询维度数据.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public DescribeTagValuesResponse DescribeTagValuesSync(DescribeTagValuesRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesResponse>(req, "DescribeTagValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据应用名查询服务拓扑图
        /// </summary>
        /// <param name="req"><see cref="DescribeTopologyNewRequest"/></param>
        /// <returns><see cref="DescribeTopologyNewResponse"/></returns>
        public Task<DescribeTopologyNewResponse> DescribeTopologyNew(DescribeTopologyNewRequest req)
        {
            return InternalRequestAsync<DescribeTopologyNewResponse>(req, "DescribeTopologyNew");
        }

        /// <summary>
        /// 根据应用名查询服务拓扑图
        /// </summary>
        /// <param name="req"><see cref="DescribeTopologyNewRequest"/></param>
        /// <returns><see cref="DescribeTopologyNewResponse"/></returns>
        public DescribeTopologyNewResponse DescribeTopologyNewSync(DescribeTopologyNewRequest req)
        {
            return InternalRequestAsync<DescribeTopologyNewResponse>(req, "DescribeTopologyNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改应用配置接口
        /// </summary>
        /// <param name="req"><see cref="ModifyApmApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyApmApplicationConfigResponse"/></returns>
        public Task<ModifyApmApplicationConfigResponse> ModifyApmApplicationConfig(ModifyApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<ModifyApmApplicationConfigResponse>(req, "ModifyApmApplicationConfig");
        }

        /// <summary>
        /// 修改应用配置接口
        /// </summary>
        /// <param name="req"><see cref="ModifyApmApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyApmApplicationConfigResponse"/></returns>
        public ModifyApmApplicationConfigResponse ModifyApmApplicationConfigSync(ModifyApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<ModifyApmApplicationConfigResponse>(req, "ModifyApmApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改apm业务系统与其他产品的关联关系（包括创建和删除）
        /// </summary>
        /// <param name="req"><see cref="ModifyApmAssociationRequest"/></param>
        /// <returns><see cref="ModifyApmAssociationResponse"/></returns>
        public Task<ModifyApmAssociationResponse> ModifyApmAssociation(ModifyApmAssociationRequest req)
        {
            return InternalRequestAsync<ModifyApmAssociationResponse>(req, "ModifyApmAssociation");
        }

        /// <summary>
        /// 用于修改apm业务系统与其他产品的关联关系（包括创建和删除）
        /// </summary>
        /// <param name="req"><see cref="ModifyApmAssociationRequest"/></param>
        /// <returns><see cref="ModifyApmAssociationResponse"/></returns>
        public ModifyApmAssociationResponse ModifyApmAssociationSync(ModifyApmAssociationRequest req)
        {
            return InternalRequestAsync<ModifyApmAssociationResponse>(req, "ModifyApmAssociation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改APM业务系统接口
        /// </summary>
        /// <param name="req"><see cref="ModifyApmInstanceRequest"/></param>
        /// <returns><see cref="ModifyApmInstanceResponse"/></returns>
        public Task<ModifyApmInstanceResponse> ModifyApmInstance(ModifyApmInstanceRequest req)
        {
            return InternalRequestAsync<ModifyApmInstanceResponse>(req, "ModifyApmInstance");
        }

        /// <summary>
        /// 修改APM业务系统接口
        /// </summary>
        /// <param name="req"><see cref="ModifyApmInstanceRequest"/></param>
        /// <returns><see cref="ModifyApmInstanceResponse"/></returns>
        public ModifyApmInstanceResponse ModifyApmInstanceSync(ModifyApmInstanceRequest req)
        {
            return InternalRequestAsync<ModifyApmInstanceResponse>(req, "ModifyApmInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改apm业务系统与Prometheus实例的指标匹配规则
        /// </summary>
        /// <param name="req"><see cref="ModifyApmPrometheusRuleRequest"/></param>
        /// <returns><see cref="ModifyApmPrometheusRuleResponse"/></returns>
        public Task<ModifyApmPrometheusRuleResponse> ModifyApmPrometheusRule(ModifyApmPrometheusRuleRequest req)
        {
            return InternalRequestAsync<ModifyApmPrometheusRuleResponse>(req, "ModifyApmPrometheusRule");
        }

        /// <summary>
        /// 用于修改apm业务系统与Prometheus实例的指标匹配规则
        /// </summary>
        /// <param name="req"><see cref="ModifyApmPrometheusRuleRequest"/></param>
        /// <returns><see cref="ModifyApmPrometheusRuleResponse"/></returns>
        public ModifyApmPrometheusRuleResponse ModifyApmPrometheusRuleSync(ModifyApmPrometheusRuleRequest req)
        {
            return InternalRequestAsync<ModifyApmPrometheusRuleResponse>(req, "ModifyApmPrometheusRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改采样配置接口
        /// </summary>
        /// <param name="req"><see cref="ModifyApmSampleConfigRequest"/></param>
        /// <returns><see cref="ModifyApmSampleConfigResponse"/></returns>
        public Task<ModifyApmSampleConfigResponse> ModifyApmSampleConfig(ModifyApmSampleConfigRequest req)
        {
            return InternalRequestAsync<ModifyApmSampleConfigResponse>(req, "ModifyApmSampleConfig");
        }

        /// <summary>
        /// 修改采样配置接口
        /// </summary>
        /// <param name="req"><see cref="ModifyApmSampleConfigRequest"/></param>
        /// <returns><see cref="ModifyApmSampleConfigResponse"/></returns>
        public ModifyApmSampleConfigResponse ModifyApmSampleConfigSync(ModifyApmSampleConfigRequest req)
        {
            return InternalRequestAsync<ModifyApmSampleConfigResponse>(req, "ModifyApmSampleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对外开放的openApi，客户可以灵活的指定需要修改的字段，再加入需要修改的服务列表.
        /// </summary>
        /// <param name="req"><see cref="ModifyGeneralApmApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyGeneralApmApplicationConfigResponse"/></returns>
        public Task<ModifyGeneralApmApplicationConfigResponse> ModifyGeneralApmApplicationConfig(ModifyGeneralApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<ModifyGeneralApmApplicationConfigResponse>(req, "ModifyGeneralApmApplicationConfig");
        }

        /// <summary>
        /// 对外开放的openApi，客户可以灵活的指定需要修改的字段，再加入需要修改的服务列表.
        /// </summary>
        /// <param name="req"><see cref="ModifyGeneralApmApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyGeneralApmApplicationConfigResponse"/></returns>
        public ModifyGeneralApmApplicationConfigResponse ModifyGeneralApmApplicationConfigSync(ModifyGeneralApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<ModifyGeneralApmApplicationConfigResponse>(req, "ModifyGeneralApmApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁 APM 业务系统
        /// </summary>
        /// <param name="req"><see cref="TerminateApmInstanceRequest"/></param>
        /// <returns><see cref="TerminateApmInstanceResponse"/></returns>
        public Task<TerminateApmInstanceResponse> TerminateApmInstance(TerminateApmInstanceRequest req)
        {
            return InternalRequestAsync<TerminateApmInstanceResponse>(req, "TerminateApmInstance");
        }

        /// <summary>
        /// 销毁 APM 业务系统
        /// </summary>
        /// <param name="req"><see cref="TerminateApmInstanceRequest"/></param>
        /// <returns><see cref="TerminateApmInstanceResponse"/></returns>
        public TerminateApmInstanceResponse TerminateApmInstanceSync(TerminateApmInstanceRequest req)
        {
            return InternalRequestAsync<TerminateApmInstanceResponse>(req, "TerminateApmInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
