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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTopicRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 只能包含字母、数字、下划线、“-”、“.”
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Partition个数，大于0
        /// </summary>
        [JsonProperty("PartitionNum")]
        public long? PartitionNum{ get; set; }

        /// <summary>
        /// 副本个数，不能多于 broker 数，最大为3
        /// </summary>
        [JsonProperty("ReplicaNum")]
        public long? ReplicaNum{ get; set; }

        /// <summary>
        /// ip白名单开关, 1:打开  0:关闭，默认不打开
        /// </summary>
        [JsonProperty("EnableWhiteList")]
        public long? EnableWhiteList{ get; set; }

        /// <summary>
        /// Ip白名单列表，配额限制，enableWhileList=1时必选
        /// </summary>
        [JsonProperty("IpWhiteList")]
        public string[] IpWhiteList{ get; set; }

        /// <summary>
        /// 清理日志策略，日志清理模式，默认为"delete"。"delete"：日志按保存时间删除，"compact"：日志按 key 压缩，"compact, delete"：日志按 key 压缩且会按保存时间删除。
        /// </summary>
        [JsonProperty("CleanUpPolicy")]
        public string CleanUpPolicy{ get; set; }

        /// <summary>
        /// 主题备注，是一个不超过 64 个字符的字符串，必须以字母为首字符，剩余部分可以包含字母、数字和横划线(-)
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 默认为1
        /// </summary>
        [JsonProperty("MinInsyncReplicas")]
        public long? MinInsyncReplicas{ get; set; }

        /// <summary>
        /// 是否允许未同步的副本选为leader，false:不允许，true:允许，默认不允许
        /// </summary>
        [JsonProperty("UncleanLeaderElectionEnable")]
        public long? UncleanLeaderElectionEnable{ get; set; }

        /// <summary>
        /// 可选参数。消息保留时间，单位ms，当前最小值为60000ms
        /// </summary>
        [JsonProperty("RetentionMs")]
        public long? RetentionMs{ get; set; }

        /// <summary>
        /// Segment分片滚动的时长，单位ms，当前最小为3600000ms
        /// </summary>
        [JsonProperty("SegmentMs")]
        public long? SegmentMs{ get; set; }

        /// <summary>
        /// 主题消息最大值，单位为 Byte，最小值1024Byte(即1KB)，最大值为12582912Byte（即12MB）
        /// </summary>
        [JsonProperty("MaxMessageBytes")]
        public long? MaxMessageBytes{ get; set; }

        /// <summary>
        /// 预设ACL规则, 1:打开  0:关闭，默认不打开
        /// </summary>
        [JsonProperty("EnableAclRule")]
        public long? EnableAclRule{ get; set; }

        /// <summary>
        /// 预设ACL规则的名称
        /// </summary>
        [JsonProperty("AclRuleName")]
        public string AclRuleName{ get; set; }

        /// <summary>
        /// 可选, 保留文件大小. 默认为-1,单位bytes, 当前最小值为1048576B
        /// </summary>
        [JsonProperty("RetentionBytes")]
        public long? RetentionBytes{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "PartitionNum", this.PartitionNum);
            this.SetParamSimple(map, prefix + "ReplicaNum", this.ReplicaNum);
            this.SetParamSimple(map, prefix + "EnableWhiteList", this.EnableWhiteList);
            this.SetParamArraySimple(map, prefix + "IpWhiteList.", this.IpWhiteList);
            this.SetParamSimple(map, prefix + "CleanUpPolicy", this.CleanUpPolicy);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "MinInsyncReplicas", this.MinInsyncReplicas);
            this.SetParamSimple(map, prefix + "UncleanLeaderElectionEnable", this.UncleanLeaderElectionEnable);
            this.SetParamSimple(map, prefix + "RetentionMs", this.RetentionMs);
            this.SetParamSimple(map, prefix + "SegmentMs", this.SegmentMs);
            this.SetParamSimple(map, prefix + "MaxMessageBytes", this.MaxMessageBytes);
            this.SetParamSimple(map, prefix + "EnableAclRule", this.EnableAclRule);
            this.SetParamSimple(map, prefix + "AclRuleName", this.AclRuleName);
            this.SetParamSimple(map, prefix + "RetentionBytes", this.RetentionBytes);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

