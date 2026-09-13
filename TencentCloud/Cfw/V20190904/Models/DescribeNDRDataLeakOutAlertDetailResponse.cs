/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNDRDataLeakOutAlertDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 风险事件ID
        /// </summary>
        [JsonProperty("RiskID")]
        public string RiskID{ get; set; }

        /// <summary>
        /// 资产实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 资产实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 资产实例类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 资产所在地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 源IP
        /// </summary>
        [JsonProperty("SrcIP")]
        public string SrcIP{ get; set; }

        /// <summary>
        /// 目的IP端口
        /// </summary>
        [JsonProperty("DstIPPort")]
        public string DstIPPort{ get; set; }

        /// <summary>
        /// 目的Host
        /// </summary>
        [JsonProperty("Hostname")]
        public string Hostname{ get; set; }

        /// <summary>
        /// 目的服务类型
        /// </summary>
        [JsonProperty("DstServiceType")]
        public string DstServiceType{ get; set; }

        /// <summary>
        /// 目的服务名称
        /// </summary>
        [JsonProperty("DstServiceName")]
        public string DstServiceName{ get; set; }

        /// <summary>
        /// 访问API
        /// </summary>
        [JsonProperty("ApiPattern")]
        public string ApiPattern{ get; set; }

        /// <summary>
        /// 目的IP地理信息
        /// </summary>
        [JsonProperty("DstGeoLocation")]
        public string DstGeoLocation{ get; set; }

        /// <summary>
        /// 应用层协议
        /// </summary>
        [JsonProperty("AppProto")]
        public string AppProto{ get; set; }

        /// <summary>
        /// 敏感类型集合
        /// </summary>
        [JsonProperty("LeakTypeSet")]
        public string LeakTypeSet{ get; set; }

        /// <summary>
        /// 事件数量
        /// </summary>
        [JsonProperty("EventCount")]
        public ulong? EventCount{ get; set; }

        /// <summary>
        /// 敏感数据数量
        /// </summary>
        [JsonProperty("LeakDataCount")]
        public ulong? LeakDataCount{ get; set; }

        /// <summary>
        /// 原始风险等级
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 处置状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 处置备注
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 首次识别时间
        /// </summary>
        [JsonProperty("FirstIdentificationTime")]
        public string FirstIdentificationTime{ get; set; }

        /// <summary>
        /// 最近识别时间
        /// </summary>
        [JsonProperty("LatestIdentificationTime")]
        public string LatestIdentificationTime{ get; set; }

        /// <summary>
        /// AI任务分析状态
        /// </summary>
        [JsonProperty("AnalysisStatus")]
        public long? AnalysisStatus{ get; set; }

        /// <summary>
        /// AI任务失败原因
        /// </summary>
        [JsonProperty("AnalysisFailReason")]
        public string AnalysisFailReason{ get; set; }

        /// <summary>
        /// 最近一次AI分析时间
        /// </summary>
        [JsonProperty("LastAnalysisTime")]
        public string LastAnalysisTime{ get; set; }

        /// <summary>
        /// API业务类型
        /// </summary>
        [JsonProperty("ApiBizType")]
        public string ApiBizType{ get; set; }

        /// <summary>
        /// API业务描述
        /// </summary>
        [JsonProperty("ApiBizDescription")]
        public string ApiBizDescription{ get; set; }

        /// <summary>
        /// 风险场景（类型）
        /// </summary>
        [JsonProperty("RiskScenario")]
        public string RiskScenario{ get; set; }

        /// <summary>
        /// 风险场景（类型）描述
        /// </summary>
        [JsonProperty("RiskScenarioDetail")]
        public string RiskScenarioDetail{ get; set; }

        /// <summary>
        /// 风险总结（概览）
        /// </summary>
        [JsonProperty("RiskSummary")]
        public string RiskSummary{ get; set; }

        /// <summary>
        /// 推断依据
        /// </summary>
        [JsonProperty("RiskBasis")]
        public string RiskBasis{ get; set; }

        /// <summary>
        /// 风险影响范围
        /// </summary>
        [JsonProperty("ImpactScope")]
        public string ImpactScope{ get; set; }

        /// <summary>
        /// AI建议风险等级
        /// </summary>
        [JsonProperty("AiSuggestedLevel")]
        public long? AiSuggestedLevel{ get; set; }

        /// <summary>
        /// 处置建议
        /// </summary>
        [JsonProperty("DisposalSuggestions")]
        public DisposalSuggestionItem[] DisposalSuggestions{ get; set; }

        /// <summary>
        /// http请求头
        /// </summary>
        [JsonProperty("HttpRequestHeader")]
        public string HttpRequestHeader{ get; set; }

        /// <summary>
        /// http请求体
        /// </summary>
        [JsonProperty("HttpRequestBody")]
        public string HttpRequestBody{ get; set; }

        /// <summary>
        /// http响应头
        /// </summary>
        [JsonProperty("HttpResponseHeader")]
        public string HttpResponseHeader{ get; set; }

        /// <summary>
        /// http响应体
        /// </summary>
        [JsonProperty("HttpResponseBody")]
        public string HttpResponseBody{ get; set; }

        /// <summary>
        /// 敏感数据条目
        /// </summary>
        [JsonProperty("LeakDataEntries")]
        public string LeakDataEntries{ get; set; }

        /// <summary>
        /// 脱敏状态
        /// </summary>
        [JsonProperty("MaskStatus")]
        public string MaskStatus{ get; set; }

        /// <summary>
        /// 最高敏感等级
        /// </summary>
        [JsonProperty("HighestLevel")]
        public string HighestLevel{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskID", this.RiskID);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SrcIP", this.SrcIP);
            this.SetParamSimple(map, prefix + "DstIPPort", this.DstIPPort);
            this.SetParamSimple(map, prefix + "Hostname", this.Hostname);
            this.SetParamSimple(map, prefix + "DstServiceType", this.DstServiceType);
            this.SetParamSimple(map, prefix + "DstServiceName", this.DstServiceName);
            this.SetParamSimple(map, prefix + "ApiPattern", this.ApiPattern);
            this.SetParamSimple(map, prefix + "DstGeoLocation", this.DstGeoLocation);
            this.SetParamSimple(map, prefix + "AppProto", this.AppProto);
            this.SetParamSimple(map, prefix + "LeakTypeSet", this.LeakTypeSet);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "LeakDataCount", this.LeakDataCount);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "FirstIdentificationTime", this.FirstIdentificationTime);
            this.SetParamSimple(map, prefix + "LatestIdentificationTime", this.LatestIdentificationTime);
            this.SetParamSimple(map, prefix + "AnalysisStatus", this.AnalysisStatus);
            this.SetParamSimple(map, prefix + "AnalysisFailReason", this.AnalysisFailReason);
            this.SetParamSimple(map, prefix + "LastAnalysisTime", this.LastAnalysisTime);
            this.SetParamSimple(map, prefix + "ApiBizType", this.ApiBizType);
            this.SetParamSimple(map, prefix + "ApiBizDescription", this.ApiBizDescription);
            this.SetParamSimple(map, prefix + "RiskScenario", this.RiskScenario);
            this.SetParamSimple(map, prefix + "RiskScenarioDetail", this.RiskScenarioDetail);
            this.SetParamSimple(map, prefix + "RiskSummary", this.RiskSummary);
            this.SetParamSimple(map, prefix + "RiskBasis", this.RiskBasis);
            this.SetParamSimple(map, prefix + "ImpactScope", this.ImpactScope);
            this.SetParamSimple(map, prefix + "AiSuggestedLevel", this.AiSuggestedLevel);
            this.SetParamArrayObj(map, prefix + "DisposalSuggestions.", this.DisposalSuggestions);
            this.SetParamSimple(map, prefix + "HttpRequestHeader", this.HttpRequestHeader);
            this.SetParamSimple(map, prefix + "HttpRequestBody", this.HttpRequestBody);
            this.SetParamSimple(map, prefix + "HttpResponseHeader", this.HttpResponseHeader);
            this.SetParamSimple(map, prefix + "HttpResponseBody", this.HttpResponseBody);
            this.SetParamSimple(map, prefix + "LeakDataEntries", this.LeakDataEntries);
            this.SetParamSimple(map, prefix + "MaskStatus", this.MaskStatus);
            this.SetParamSimple(map, prefix + "HighestLevel", this.HighestLevel);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

