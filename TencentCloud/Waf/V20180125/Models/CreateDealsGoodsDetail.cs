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

    public class CreateDealsGoodsDetail : AbstractModel
    {
        
        /// <summary>
        /// 时间间隔
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 单位，支持购买d、m、y 即（日、月、年）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 子产品标签,。新购，续费必传，变配时放在oldConfig newConfig里面
        /// 
        /// Saas 高级版 ：sp_wsm_waf_premium
        /// Saas企业版 ：sp_wsm_waf_enterprise
        /// Saas旗舰版 ：sp_wsm_waf_ultimate
        /// Saas 业务扩展包：sp_wsm_waf_qpsep
        /// Saas 域名扩展包：sp_wsm_waf_domain
        /// 
        /// 高级版-CLB:sp_wsm_waf_premium_clb
        /// 企业版-CLB : sp_wsm_waf_enterprise_clb
        /// 旗舰版-CLB:sp_wsm_waf_ultimate_clb
        ///  业务扩展包-CLB：sp_wsm_waf_qpsep_clb
        /// 域名扩展包-CLB：sp_wsm_waf_domain_clb
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// 业务产品申请的pid（对应一个定价公式），通过pid计费查询到定价模型
        /// 高级版 ：1000827
        /// 企业版 ：1000830
        /// 旗舰版 ：1000832
        /// 域名包 : 1000834
        /// 业务扩展包 : 1000481
        /// 高级版-CLB:1001150
        /// 企业版-CLB : 1001152
        /// 旗舰版-CLB:1001154
        /// 域名包-CLB: 1001156
        /// 业务扩展包-CLB : 1001160
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// waf实例名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 1:自动续费，0:不自动续费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// waf购买的实际地域信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealRegion")]
        public long? RealRegion{ get; set; }

        /// <summary>
        /// 计费细项标签数组
        /// Saas 高级版  sv_wsm_waf_package_premium 
        /// Saas 企业版  sv_wsm_waf_package_enterprise
        /// Saas 旗舰版  sv_wsm_waf_package_ultimate 
        /// Saas 非中国大陆高级版  sv_wsm_waf_package_premium_intl
        /// Saas 非中国大陆企业版   sv_wsm_waf_package_enterprise_intl
        /// Saas 非中国大陆旗舰版  sv_wsm_waf_package_ultimate _intl
        /// Saas 业务扩展包  sv_wsm_waf_qps_ep
        /// Saas 域名扩展包  sv_wsm_waf_domain
        /// 
        /// 高级版CLB   sv_wsm_waf_package_premium_clb
        /// 企业版CLB  sv_wsm_waf_package_enterprise_clb
        /// 旗舰版CLB   sv_wsm_waf_package_ultimate_clb
        /// 非中国大陆高级版 CLB sv_wsm_waf_package_premium_clb_intl
        /// 非中国大陆企业版CLB   sv_wsm_waf_package_premium_clb_intl
        /// 非中国大陆旗舰版CLB  sv_wsm_waf_package_ultimate_clb _intl
        /// 业务扩展包CLB sv_wsm_waf_qps_ep_clb
        /// 域名扩展包CLB  sv_wsm_waf_domain_clb
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelTypes")]
        public string[] LabelTypes{ get; set; }

        /// <summary>
        /// 计费细项标签数量，一般和SvLabelType一一对应
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelCounts")]
        public long?[] LabelCounts{ get; set; }

        /// <summary>
        /// 变配使用，实例到期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurDeadline")]
        public string CurDeadline{ get; set; }

        /// <summary>
        /// 对存在的实例购买bot 或api 安全
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 资源id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "RealRegion", this.RealRegion);
            this.SetParamArraySimple(map, prefix + "LabelTypes.", this.LabelTypes);
            this.SetParamArraySimple(map, prefix + "LabelCounts.", this.LabelCounts);
            this.SetParamSimple(map, prefix + "CurDeadline", this.CurDeadline);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

