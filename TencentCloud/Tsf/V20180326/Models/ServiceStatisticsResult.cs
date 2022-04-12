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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceStatisticsResult : AbstractModel
    {
        
        /// <summary>
        /// 请求模版路径:type为接口时返回，服务时不返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 请求方法:type为接口时返回，服务时不返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 微服务Id
        /// </summary>
        [JsonProperty("MicroserviceId")]
        public string MicroserviceId{ get; set; }

        /// <summary>
        /// 微服务名称
        /// </summary>
        [JsonProperty("MicroserviceName")]
        public string MicroserviceName{ get; set; }

        /// <summary>
        /// 请求数
        /// </summary>
        [JsonProperty("RequestCount")]
        public ulong? RequestCount{ get; set; }

        /// <summary>
        /// 请求错误率，不带百分号
        /// </summary>
        [JsonProperty("ErrorRate")]
        public float? ErrorRate{ get; set; }

        /// <summary>
        /// 平均响应耗时ms
        /// </summary>
        [JsonProperty("AvgTimeConsuming")]
        public float? AvgTimeConsuming{ get; set; }

        /// <summary>
        /// 响应耗时曲线
        /// </summary>
        [JsonProperty("MetricDataCurves")]
        public MetricDataCurve[] MetricDataCurves{ get; set; }

        /// <summary>
        /// 实例id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例name
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 部署组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 部署组name
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 部署组类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 部署组是否存在
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupExist")]
        public long? GroupExist{ get; set; }

        /// <summary>
        /// 实例是否存在，仅限cvm
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceExist")]
        public long? InstanceExist{ get; set; }

        /// <summary>
        /// 应用id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 微服务类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MicroserviceType")]
        public string MicroserviceType{ get; set; }

        /// <summary>
        /// cpu使用率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuPercent")]
        public long? CpuPercent{ get; set; }

        /// <summary>
        /// 已用堆大小,单位KB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeapUsed")]
        public long? HeapUsed{ get; set; }

        /// <summary>
        /// 数据库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// Script值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Script")]
        public string Script{ get; set; }

        /// <summary>
        /// 数据库类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// Apdex值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Apdex")]
        public float? Apdex{ get; set; }

        /// <summary>
        /// Qps值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Qps")]
        public float? Qps{ get; set; }

        /// <summary>
        /// 实例在线数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceOnlineCount")]
        public long? InstanceOnlineCount{ get; set; }

        /// <summary>
        /// 实例总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceTotalCount")]
        public long? InstanceTotalCount{ get; set; }

        /// <summary>
        /// normal/error
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// normal/warn/error
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorRateLevel")]
        public string ErrorRateLevel{ get; set; }

        /// <summary>
        /// normal/warn/error
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvgTimeConsumingLevel")]
        public string AvgTimeConsumingLevel{ get; set; }

        /// <summary>
        /// normal/warn/error
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApdexLevel")]
        public string ApdexLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "MicroserviceId", this.MicroserviceId);
            this.SetParamSimple(map, prefix + "MicroserviceName", this.MicroserviceName);
            this.SetParamSimple(map, prefix + "RequestCount", this.RequestCount);
            this.SetParamSimple(map, prefix + "ErrorRate", this.ErrorRate);
            this.SetParamSimple(map, prefix + "AvgTimeConsuming", this.AvgTimeConsuming);
            this.SetParamArrayObj(map, prefix + "MetricDataCurves.", this.MetricDataCurves);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "GroupExist", this.GroupExist);
            this.SetParamSimple(map, prefix + "InstanceExist", this.InstanceExist);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "MicroserviceType", this.MicroserviceType);
            this.SetParamSimple(map, prefix + "CpuPercent", this.CpuPercent);
            this.SetParamSimple(map, prefix + "HeapUsed", this.HeapUsed);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "Script", this.Script);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "Apdex", this.Apdex);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "InstanceOnlineCount", this.InstanceOnlineCount);
            this.SetParamSimple(map, prefix + "InstanceTotalCount", this.InstanceTotalCount);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorRateLevel", this.ErrorRateLevel);
            this.SetParamSimple(map, prefix + "AvgTimeConsumingLevel", this.AvgTimeConsumingLevel);
            this.SetParamSimple(map, prefix + "ApdexLevel", this.ApdexLevel);
        }
    }
}

