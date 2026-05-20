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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTopicRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>主题ID- 通过<a href="https://cloud.tencent.com/document/product/614/56454">获取主题列表</a>获取主题Id。</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>主题名称<br>输入限制：</p><ul><li>不能为空字符串</li><li>不能包含字符&#39;|&#39;</li><li>不能使用以下名称[&quot;cls_service_log&quot;,&quot;loglistener_status&quot;,&quot;loglistener_alarm&quot;,&quot;loglistener_business&quot;,&quot;cls_service_metric&quot;]</li></ul>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>标签描述列表，通过指定该参数可以同时绑定标签到相应的主题。最大支持10个标签键值对，并且不能有重复的键值对。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>主题是否开启采集，true：开启采集；false：关闭采集。<br>控制台目前不支持修改此参数。</p>
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// <p>是否开启自动分裂</p>
        /// </summary>
        [JsonProperty("AutoSplit")]
        public bool? AutoSplit{ get; set; }

        /// <summary>
        /// <p>若开启最大分裂，该主题能够允许的最大分区数；<br>默认为50；必须为正数</p>
        /// </summary>
        [JsonProperty("MaxSplitPartitions")]
        public long? MaxSplitPartitions{ get; set; }

        /// <summary>
        /// <p>生命周期，单位天，标准存储取值范围1~3600，低频存储取值范围7~3600。取值为3640时代表永久保存</p>
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// <p>存储类型：cold 低频存储，hot 标准存储</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>主题描述</p>
        /// </summary>
        [JsonProperty("Describes")]
        public string Describes{ get; set; }

        /// <summary>
        /// <p>0：日志主题关闭日志沉降。<br>非0：日志主题开启日志沉降后标准存储的天数。HotPeriod需要大于等于7，且小于Period。<br>仅在StorageType为 hot 时生效，指标主题不支持该配置。</p>
        /// </summary>
        [JsonProperty("HotPeriod")]
        public ulong? HotPeriod{ get; set; }

        /// <summary>
        /// <p>免鉴权开关。 false：关闭； true：开启。<br>开启后将支持指定操作匿名访问该日志主题。详情请参见<a href="https://cloud.tencent.com/document/product/614/41035">日志主题</a>。</p>
        /// </summary>
        [JsonProperty("IsWebTracking")]
        public bool? IsWebTracking{ get; set; }

        /// <summary>
        /// <p>主题扩展信息</p>
        /// </summary>
        [JsonProperty("Extends")]
        public TopicExtendInfo Extends{ get; set; }

        /// <summary>
        /// <p>主题分区数量。<br>默认为1；<br>取值范围及约束：</p><ul><li>当输入值&lt;=0，系统自动调整为1。</li><li>如果未传MaxSplitPartitions，需要PartitionCount&lt;=50；</li><li>如果传递了MaxSplitPartitions，需要PartitionCount&lt;=MaxSplitPartitions；</li></ul>
        /// </summary>
        [JsonProperty("PartitionCount")]
        public ulong? PartitionCount{ get; set; }

        /// <summary>
        /// <p>取消切换存储任务的id</p><ul><li>通过<a href="https://cloud.tencent.com/document/product/614/56454">获取日志主题列表</a>获取取消切换存储任务的id【Topics中的TopicAsyncTaskID字段】。</li></ul>
        /// </summary>
        [JsonProperty("CancelTopicAsyncTaskID")]
        public string CancelTopicAsyncTaskID{ get; set; }

        /// <summary>
        /// <p>加密相关参数。 支持加密地域并且开白用户可以传此参数，其他场景不能传递该参数。<br>只支持传入1：kms-cls 云产品秘钥加密</p>
        /// </summary>
        [JsonProperty("Encryption")]
        public ulong? Encryption{ get; set; }

        /// <summary>
        /// <p>开启记录公网来源ip和服务端接收时间</p>
        /// </summary>
        [JsonProperty("IsSourceFrom")]
        public bool? IsSourceFrom{ get; set; }

        /// <summary>
        /// <p>计费模式</p><p>枚举值：</p><ul><li>0： 按使用功能计费</li><li>1： 按原始日志量计费（目前仅面向少部分客户支持）</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("BillingMode")]
        public ulong? BillingMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AutoSplit", this.AutoSplit);
            this.SetParamSimple(map, prefix + "MaxSplitPartitions", this.MaxSplitPartitions);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Describes", this.Describes);
            this.SetParamSimple(map, prefix + "HotPeriod", this.HotPeriod);
            this.SetParamSimple(map, prefix + "IsWebTracking", this.IsWebTracking);
            this.SetParamObj(map, prefix + "Extends.", this.Extends);
            this.SetParamSimple(map, prefix + "PartitionCount", this.PartitionCount);
            this.SetParamSimple(map, prefix + "CancelTopicAsyncTaskID", this.CancelTopicAsyncTaskID);
            this.SetParamSimple(map, prefix + "Encryption", this.Encryption);
            this.SetParamSimple(map, prefix + "IsSourceFrom", this.IsSourceFrom);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
        }
    }
}

