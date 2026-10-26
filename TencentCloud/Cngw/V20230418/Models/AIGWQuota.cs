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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWQuota : AbstractModel
    {
        
        /// <summary>
        /// <p>Id</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>资源类型</p><p>枚举值：</p><ul><li>Consumer： 消费者</li></ul>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>资源 id</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>资源名字</p><p>如消费者名字</p>
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// <p>配额类型</p><p>枚举值：</p><ul><li>RequestCount： 请求数</li><li>TotalToken： 总 token</li><li>Cost： 成本</li></ul>
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// <p>配额周期单位</p><p>枚举值：</p><ul><li>Day： 天</li><li>Week： 周</li><li>Month： 月</li></ul>
        /// </summary>
        [JsonProperty("PeriodUnit")]
        public string PeriodUnit{ get; set; }

        /// <summary>
        /// <p>配额</p>
        /// </summary>
        [JsonProperty("QuotaLimit")]
        public ulong? QuotaLimit{ get; set; }

        /// <summary>
        /// <p>启用</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>创建时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>配额类型，手动配额还是默认配额</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>配额超限行为</p><p>枚举值：</p><ul><li>Reject： 拒绝消费者请求</li><li>AllowOverage： 允许超限</li></ul>
        /// </summary>
        [JsonProperty("ExceedAction")]
        public string ExceedAction{ get; set; }

        /// <summary>
        /// <p>缓存是否计入限额</p><p>枚举值：</p><ul><li>Full： 全量计入</li><li>Exclude： 不计入网关缓存命中部分</li></ul>
        /// </summary>
        [JsonProperty("CacheHitStat")]
        public string CacheHitStat{ get; set; }

        /// <summary>
        /// <p>超限百分比</p><p>默认值：0</p><p>Consumer 的超量百分比，指定模型服务配额默认为 0；ConsumerGroup 固定为 0。</p><p>举例：20，超出设置额度的20%，可用额度为（1+20%）*QuotaLimit。当SetExceedPercentage=true时，条件必选。</p>
        /// </summary>
        [JsonProperty("ExceedPercentage")]
        public ulong? ExceedPercentage{ get; set; }

        /// <summary>
        /// <p>是否设置超限百分比</p><p>仅 Consumer 的 AllowOverage 场景可用，指定模型服务的配额必须为 false；ConsumerGroup 必须为 false。</p><p>枚举值：</p><ul><li>true： 设置超限百分比</li><li>false： 不设置超限百分比，即不设上限</li></ul><p>默认值：false</p><p>当ExceedAction=AllowOverage时，条件必选。</p>
        /// </summary>
        [JsonProperty("SetExceedPercentage")]
        public bool? SetExceedPercentage{ get; set; }

        /// <summary>
        /// <p>Consumer粒度某资源对象的配额范围，支持：全部模型服务（all）、指定模型服务（specified）</p><p>枚举值：</p><ul><li>All： 全部</li><li>Specified： 指定</li></ul><p>默认值：All</p>
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// <p>Consumer粒度配额的资源类型，如“模型服务”</p><p>枚举值：</p><ul><li>ModelService： 模型服务</li></ul><p>默认值：ModelService</p>
        /// </summary>
        [JsonProperty("SubResourceType")]
        public string SubResourceType{ get; set; }

        /// <summary>
        /// <p>Consumer粒度配额若支持指定子资源配额，则该项为子资源配额个数</p>
        /// </summary>
        [JsonProperty("SubResourceCount")]
        public long? SubResourceCount{ get; set; }

        /// <summary>
        /// <p>消费者组完整层级路径。仅 ResourceType=ConsumerGroup 返回，未知时为空字符串；Consumer 行省略。</p>
        /// </summary>
        [JsonProperty("ConsumerGroupPath")]
        public string ConsumerGroupPath{ get; set; }

        /// <summary>
        /// <p>消费者组是否有效。仅 ResourceType=ConsumerGroup 返回；组不存在或非 active 时为 false。与配额规则 Enabled 区分，字段省略与 false 含义不同。</p>
        /// </summary>
        [JsonProperty("ConsumerGroupActive")]
        public bool? ConsumerGroupActive{ get; set; }

        /// <summary>
        /// <p>兼容用量字段。Cost 为向下取整的整数元；TotalToken 单位为 token；RequestCount 单位为次。精确显示优先使用 UsedExact。</p> 仅支持用量查询的实际规则返回；旧 Consumer 网关和 DefaultPolicy 模板可省略。
        /// </summary>
        [JsonProperty("Used")]
        public long? Used{ get; set; }

        /// <summary>
        /// <p>精确使用量。Cost 单位为元，保留 1e-7 元精度；TotalToken 单位为 token；RequestCount 单位为次。旧版插件不提供精确值时省略，调用方可回退使用 Used；该值已换算为业务单位，不要再除以 ValueScale。</p> 仅支持用量查询的实际规则返回；旧 Consumer 网关和 DefaultPolicy 模板可省略。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedExact")]
        public float? UsedExact{ get; set; }

        /// <summary>
        /// <p>使用率</p> 仅支持用量查询的实际规则返回；旧 Consumer 网关和 DefaultPolicy 模板可省略。
        /// </summary>
        [JsonProperty("UsageRate")]
        public float? UsageRate{ get; set; }

        /// <summary>
        /// <p>预警级别</p><p>枚举值：</p><ul><li>Normal： 正常</li><li>Warning： 预警</li><li>NearLimit： 临近超限</li><li>Exceeded： 超限</li></ul> 仅支持用量查询的实际规则返回；旧 Consumer 网关和 DefaultPolicy 模板可省略。
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public string AlarmLevel{ get; set; }

        /// <summary>
        /// <p>关联消费者密钥数量。ConsumerGroup 规则固定为 0。</p>
        /// </summary>
        [JsonProperty("SecretKeyCount")]
        public long? SecretKeyCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamSimple(map, prefix + "PeriodUnit", this.PeriodUnit);
            this.SetParamSimple(map, prefix + "QuotaLimit", this.QuotaLimit);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "ExceedAction", this.ExceedAction);
            this.SetParamSimple(map, prefix + "CacheHitStat", this.CacheHitStat);
            this.SetParamSimple(map, prefix + "ExceedPercentage", this.ExceedPercentage);
            this.SetParamSimple(map, prefix + "SetExceedPercentage", this.SetExceedPercentage);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "SubResourceType", this.SubResourceType);
            this.SetParamSimple(map, prefix + "SubResourceCount", this.SubResourceCount);
            this.SetParamSimple(map, prefix + "ConsumerGroupPath", this.ConsumerGroupPath);
            this.SetParamSimple(map, prefix + "ConsumerGroupActive", this.ConsumerGroupActive);
            this.SetParamSimple(map, prefix + "Used", this.Used);
            this.SetParamSimple(map, prefix + "UsedExact", this.UsedExact);
            this.SetParamSimple(map, prefix + "UsageRate", this.UsageRate);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "SecretKeyCount", this.SecretKeyCount);
        }
    }
}

