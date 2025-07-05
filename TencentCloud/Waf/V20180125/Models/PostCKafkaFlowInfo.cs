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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PostCKafkaFlowInfo : AbstractModel
    {
        
        /// <summary>
        /// 投递流唯一ID
        /// </summary>
        [JsonProperty("FlowId")]
        public long? FlowId{ get; set; }

        /// <summary>
        /// 1-访问日志 2-攻击日志
        /// </summary>
        [JsonProperty("LogType")]
        public long? LogType{ get; set; }

        /// <summary>
        /// 状态 0-为关闭 1-为启用
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// CKafka所在区域
        /// </summary>
        [JsonProperty("CKafkaRegion")]
        public string CKafkaRegion{ get; set; }

        /// <summary>
        /// CKafka实例ID
        /// </summary>
        [JsonProperty("CKafkaID")]
        public string CKafkaID{ get; set; }

        /// <summary>
        /// ckafka地址信息
        /// </summary>
        [JsonProperty("Brokers")]
        public string Brokers{ get; set; }

        /// <summary>
        /// ckafka版本号
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 主题名称
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// 压缩算法，支持gzip 和 lz4
        /// </summary>
        [JsonProperty("Compression")]
        public string Compression{ get; set; }

        /// <summary>
        /// 是否支持SASL,0-关闭，1-开启
        /// </summary>
        [JsonProperty("SASLEnable")]
        public long? SASLEnable{ get; set; }

        /// <summary>
        /// SASL用户名
        /// </summary>
        [JsonProperty("SASLUser")]
        public string SASLUser{ get; set; }

        /// <summary>
        /// SALS密码
        /// </summary>
        [JsonProperty("SASLPassword")]
        public string SASLPassword{ get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 1-外网TGW，2-支撑环境，默认为支撑环境
        /// </summary>
        [JsonProperty("VipType")]
        public long? VipType{ get; set; }

        /// <summary>
        /// 配置状态
        /// </summary>
        [JsonProperty("WriteConfig")]
        public FieldWriteConfig WriteConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CKafkaRegion", this.CKafkaRegion);
            this.SetParamSimple(map, prefix + "CKafkaID", this.CKafkaID);
            this.SetParamSimple(map, prefix + "Brokers", this.Brokers);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Compression", this.Compression);
            this.SetParamSimple(map, prefix + "SASLEnable", this.SASLEnable);
            this.SetParamSimple(map, prefix + "SASLUser", this.SASLUser);
            this.SetParamSimple(map, prefix + "SASLPassword", this.SASLPassword);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "VipType", this.VipType);
            this.SetParamObj(map, prefix + "WriteConfig.", this.WriteConfig);
        }
    }
}

