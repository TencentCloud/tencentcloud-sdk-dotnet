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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmHistory : AbstractModel
    {
        
        /// <summary>
        /// 告警历史Id
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// 监控类型
        /// </summary>
        [JsonProperty("MonitorType")]
        public string MonitorType{ get; set; }

        /// <summary>
        /// 策略类型
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 告警对象
        /// </summary>
        [JsonProperty("AlarmObject")]
        public string AlarmObject{ get; set; }

        /// <summary>
        /// 告警内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 时间戳，首次出现时间
        /// </summary>
        [JsonProperty("FirstOccurTime")]
        public long? FirstOccurTime{ get; set; }

        /// <summary>
        /// 时间戳，最后出现时间
        /// </summary>
        [JsonProperty("LastOccurTime")]
        public long? LastOccurTime{ get; set; }

        /// <summary>
        /// 告警状态，ALARM=未恢复 OK=已恢复 NO_CONF=已失效 NO_DATA=数据不足
        /// </summary>
        [JsonProperty("AlarmStatus")]
        public string AlarmStatus{ get; set; }

        /// <summary>
        /// 告警策略 Id
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 基础产品告警的告警对象所属网络
        /// </summary>
        [JsonProperty("VPC")]
        public string VPC{ get; set; }

        /// <summary>
        /// 项目 Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 项目名字
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 告警对象所属实例组
        /// </summary>
        [JsonProperty("InstanceGroup")]
        public InstanceGroups[] InstanceGroup{ get; set; }

        /// <summary>
        /// 接收人列表
        /// </summary>
        [JsonProperty("ReceiverUids")]
        public long?[] ReceiverUids{ get; set; }

        /// <summary>
        /// 接收组列表
        /// </summary>
        [JsonProperty("ReceiverGroups")]
        public long?[] ReceiverGroups{ get; set; }

        /// <summary>
        /// 告警渠道列表 SMS=短信 EMAIL=邮件 CALL=电话 WECHAT=微信
        /// </summary>
        [JsonProperty("NoticeWays")]
        public string[] NoticeWays{ get; set; }

        /// <summary>
        /// 可用于实例、实例组的绑定和解绑接口（[BindingPolicyObject](https://cloud.tencent.com/document/product/248/40421)、[UnBindingAllPolicyObject](https://cloud.tencent.com/document/product/248/40568)、[UnBindingPolicyObject](https://cloud.tencent.com/document/product/248/40567)）的策略 ID
        /// </summary>
        [JsonProperty("OriginId")]
        public string OriginId{ get; set; }

        /// <summary>
        /// 告警类型
        /// </summary>
        [JsonProperty("AlarmType")]
        public string AlarmType{ get; set; }

        /// <summary>
        /// 事件Id
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 策略是否存在 0=不存在 1=存在
        /// </summary>
        [JsonProperty("PolicyExists")]
        public long? PolicyExists{ get; set; }

        /// <summary>
        /// 指标信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetricsInfo")]
        public AlarmHistoryMetric[] MetricsInfo{ get; set; }

        /// <summary>
        /// 告警实例的维度信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "AlarmObject", this.AlarmObject);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "FirstOccurTime", this.FirstOccurTime);
            this.SetParamSimple(map, prefix + "LastOccurTime", this.LastOccurTime);
            this.SetParamSimple(map, prefix + "AlarmStatus", this.AlarmStatus);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "VPC", this.VPC);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamArrayObj(map, prefix + "InstanceGroup.", this.InstanceGroup);
            this.SetParamArraySimple(map, prefix + "ReceiverUids.", this.ReceiverUids);
            this.SetParamArraySimple(map, prefix + "ReceiverGroups.", this.ReceiverGroups);
            this.SetParamArraySimple(map, prefix + "NoticeWays.", this.NoticeWays);
            this.SetParamSimple(map, prefix + "OriginId", this.OriginId);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "PolicyExists", this.PolicyExists);
            this.SetParamArrayObj(map, prefix + "MetricsInfo.", this.MetricsInfo);
            this.SetParamSimple(map, prefix + "Dimensions", this.Dimensions);
        }
    }
}

