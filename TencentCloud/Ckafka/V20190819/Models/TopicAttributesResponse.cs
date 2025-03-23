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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopicAttributesResponse : AbstractModel
    {
        
        /// <summary>
        /// 主题 ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 主题备注
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 分区个数
        /// </summary>
        [JsonProperty("PartitionNum")]
        public long? PartitionNum{ get; set; }

        /// <summary>
        /// IP 白名单开关，1：打开； 0：关闭
        /// </summary>
        [JsonProperty("EnableWhiteList")]
        public long? EnableWhiteList{ get; set; }

        /// <summary>
        /// IP 白名单列表
        /// </summary>
        [JsonProperty("IpWhiteList")]
        public string[] IpWhiteList{ get; set; }

        /// <summary>
        /// topic 配置数组
        /// </summary>
        [JsonProperty("Config")]
        public Config Config{ get; set; }

        /// <summary>
        /// 分区详情
        /// </summary>
        [JsonProperty("Partitions")]
        public TopicPartitionDO[] Partitions{ get; set; }

        /// <summary>
        /// ACL预设策略开关，1：打开； 0：关闭
        /// </summary>
        [JsonProperty("EnableAclRule")]
        public long? EnableAclRule{ get; set; }

        /// <summary>
        /// 预设策略列表
        /// </summary>
        [JsonProperty("AclRuleList")]
        public AclRule[] AclRuleList{ get; set; }

        /// <summary>
        /// topic 限流策略
        /// </summary>
        [JsonProperty("QuotaConfig")]
        public InstanceQuotaConfigResp QuotaConfig{ get; set; }

        /// <summary>
        /// 副本数
        /// </summary>
        [JsonProperty("ReplicaNum")]
        public long? ReplicaNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "PartitionNum", this.PartitionNum);
            this.SetParamSimple(map, prefix + "EnableWhiteList", this.EnableWhiteList);
            this.SetParamArraySimple(map, prefix + "IpWhiteList.", this.IpWhiteList);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamArrayObj(map, prefix + "Partitions.", this.Partitions);
            this.SetParamSimple(map, prefix + "EnableAclRule", this.EnableAclRule);
            this.SetParamArrayObj(map, prefix + "AclRuleList.", this.AclRuleList);
            this.SetParamObj(map, prefix + "QuotaConfig.", this.QuotaConfig);
            this.SetParamSimple(map, prefix + "ReplicaNum", this.ReplicaNum);
        }
    }
}

