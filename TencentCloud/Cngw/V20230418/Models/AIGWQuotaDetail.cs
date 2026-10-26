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

    public class AIGWQuotaDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>id</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>资源类型</p><p>枚举值：</p><ul><li>Consumer： 消费者</li></ul>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>资源id</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>资源名字</p>
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// <p>配额类型</p><p>枚举值：</p><ul><li>RequestCount： 请求数</li><li>TotalToken： token总数</li><li>Cost： 成本</li></ul>
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// <p>配额单位</p><p>枚举值：</p><ul><li>Day： 天</li><li>Week： 周</li><li>Month： 月</li></ul>
        /// </summary>
        [JsonProperty("PeriodUnit")]
        public string PeriodUnit{ get; set; }

        /// <summary>
        /// <p>配额</p><p>如果是成本则数值单位是分，如 1000 表示 10.00 元</p>
        /// </summary>
        [JsonProperty("QuotaLimit")]
        public long? QuotaLimit{ get; set; }

        /// <summary>
        /// <p>启用</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>用量</p>
        /// </summary>
        [JsonProperty("Used")]
        public long? Used{ get; set; }

        /// <summary>
        /// <p>使用率</p>
        /// </summary>
        [JsonProperty("UsageRate")]
        public float? UsageRate{ get; set; }

        /// <summary>
        /// <p>预警级别</p><p>枚举值：</p><ul><li>Normal： 正常</li><li>Warning： 预警</li><li>NearLimit： 临近超限</li><li>Exceeded： 超限</li></ul>
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public string AlarmLevel{ get; set; }

        /// <summary>
        /// <p>配额规则来源</p><p>枚举值：</p><ul><li>Manual： 手动配置</li><li>Default： 默认配额</li></ul>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>配额超限行为</p><p>枚举值：</p><ul><li>Reject： 拒绝消费者请求</li><li>AllowOverage： 允许超限</li></ul>
        /// </summary>
        [JsonProperty("ExceedAction")]
        public string ExceedAction{ get; set; }

        /// <summary>
        /// <p>创建时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>缓存是否计入限额</p><p>枚举值：</p><ul><li>Full： 全量计入</li><li>Exclude： 不计入网关缓存命中部分</li></ul>
        /// </summary>
        [JsonProperty("CacheHitStat")]
        public string CacheHitStat{ get; set; }

        /// <summary>
        /// <p>是否设置超限百分比</p><p>仅 Consumer 的 AllowOverage 场景可用，指定模型服务的配额必须为 false；ConsumerGroup 必须为 false。</p><p>枚举值：</p><ul><li>true： 设置超限百分比</li><li>false： 不设置超限百分比，即不设上限</li></ul><p>默认值：false</p><p>当ExceedAction=AllowOverage时，条件必选。</p>
        /// </summary>
        [JsonProperty("SetExceedPercentage")]
        public bool? SetExceedPercentage{ get; set; }

        /// <summary>
        /// <p>超限百分比</p><p>默认值：0</p><p>Consumer 的超量百分比，指定模型服务配额默认为 0；ConsumerGroup 固定为 0。</p><p>举例：20，超出设置额度的20%，可用额度为（1+20%）*QuotaLimit。当SetExceedPercentage=true时，条件必选。</p>
        /// </summary>
        [JsonProperty("ExceedPercentage")]
        public ulong? ExceedPercentage{ get; set; }

        /// <summary>
        /// <p>精确使用量。Cost 单位为元，保留 1e-7 元精度；TotalToken 单位为 token；RequestCount 单位为次。旧版插件不提供精确值时省略，调用方可回退使用 Used；该值已换算为业务单位，不要再除以 ValueScale。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedExact")]
        public float? UsedExact{ get; set; }

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
        /// <p>配额规则中，某资源对象的指定子资源配额信息。如资源对象“模型服务”的“指定模型服务”的配额信息。</p>
        /// </summary>
        [JsonProperty("SubResources")]
        public AIGWQuotaSubItem[] SubResources{ get; set; }


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
            this.SetParamSimple(map, prefix + "Used", this.Used);
            this.SetParamSimple(map, prefix + "UsageRate", this.UsageRate);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "ExceedAction", this.ExceedAction);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "CacheHitStat", this.CacheHitStat);
            this.SetParamSimple(map, prefix + "SetExceedPercentage", this.SetExceedPercentage);
            this.SetParamSimple(map, prefix + "ExceedPercentage", this.ExceedPercentage);
            this.SetParamSimple(map, prefix + "UsedExact", this.UsedExact);
            this.SetParamSimple(map, prefix + "ConsumerGroupPath", this.ConsumerGroupPath);
            this.SetParamSimple(map, prefix + "ConsumerGroupActive", this.ConsumerGroupActive);
            this.SetParamArrayObj(map, prefix + "SubResources.", this.SubResources);
        }
    }
}

