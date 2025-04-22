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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePostCKafkaFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 投递的CKafka所在区域
        /// </summary>
        [JsonProperty("CKafkaRegion")]
        public string CKafkaRegion{ get; set; }

        /// <summary>
        /// 客户的CKafka 实例ID
        /// </summary>
        [JsonProperty("CKafkaID")]
        public string CKafkaID{ get; set; }

        /// <summary>
        /// 支撑环境是IP:PORT，外网环境是domain:PORT
        /// </summary>
        [JsonProperty("Brokers")]
        public string Brokers{ get; set; }

        /// <summary>
        /// 默认为none，支持snappy、gzip和lz4压缩，推荐snappy
        /// </summary>
        [JsonProperty("Compression")]
        public string Compression{ get; set; }

        /// <summary>
        /// 1-外网TGW，2-支撑环境，默认为支撑环境
        /// </summary>
        [JsonProperty("VipType")]
        public long? VipType{ get; set; }

        /// <summary>
        /// 1-访问日志，2-攻击日志，默认为访问日志
        /// </summary>
        [JsonProperty("LogType")]
        public long? LogType{ get; set; }

        /// <summary>
        /// 主题名称，默认不传或者传空字符串，默认值为waf_post_access_log
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// kafka集群的版本号
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// 是否开启SASL校验，默认不开启，0-关闭，1-开启
        /// </summary>
        [JsonProperty("SASLEnable")]
        public long? SASLEnable{ get; set; }

        /// <summary>
        /// SASL用户名
        /// </summary>
        [JsonProperty("SASLUser")]
        public string SASLUser{ get; set; }

        /// <summary>
        /// SASL密码
        /// </summary>
        [JsonProperty("SASLPassword")]
        public string SASLPassword{ get; set; }

        /// <summary>
        /// 开启访问日志某些字段是否投递
        /// </summary>
        [JsonProperty("WriteConfig")]
        public FieldWriteConfig WriteConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CKafkaRegion", this.CKafkaRegion);
            this.SetParamSimple(map, prefix + "CKafkaID", this.CKafkaID);
            this.SetParamSimple(map, prefix + "Brokers", this.Brokers);
            this.SetParamSimple(map, prefix + "Compression", this.Compression);
            this.SetParamSimple(map, prefix + "VipType", this.VipType);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
            this.SetParamSimple(map, prefix + "SASLEnable", this.SASLEnable);
            this.SetParamSimple(map, prefix + "SASLUser", this.SASLUser);
            this.SetParamSimple(map, prefix + "SASLPassword", this.SASLPassword);
            this.SetParamObj(map, prefix + "WriteConfig.", this.WriteConfig);
        }
    }
}

