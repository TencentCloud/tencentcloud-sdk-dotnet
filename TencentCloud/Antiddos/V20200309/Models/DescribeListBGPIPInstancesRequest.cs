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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeListBGPIPInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 页起始偏移，取值为(页码-1)*一页条数
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 一页条数，当Limit=0时，默认一页条数为20;最大取值为100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// IP搜索
        /// </summary>
        [JsonProperty("FilterIp")]
        public string FilterIp{ get; set; }

        /// <summary>
        /// 资产实例ID搜索，例如，bgpip-00000001
        /// </summary>
        [JsonProperty("FilterInstanceId")]
        public string FilterInstanceId{ get; set; }

        /// <summary>
        /// 高防IP线路搜索，取值为[
        /// 1：BGP线路
        /// 2：电信
        /// 3：联通
        /// 4：移动
        /// 99：第三方合作线路
        /// ]
        /// </summary>
        [JsonProperty("FilterLine")]
        public ulong? FilterLine{ get; set; }

        /// <summary>
        /// 地域搜索，例如，ap-guangzhou
        /// </summary>
        [JsonProperty("FilterRegion")]
        public string FilterRegion{ get; set; }

        /// <summary>
        /// 名称搜索
        /// </summary>
        [JsonProperty("FilterName")]
        public string FilterName{ get; set; }

        /// <summary>
        /// 是否只获取高防弹性公网IP实例。填写时，只能填写1或者0。当填写1时，表示返回高防弹性公网IP实例。当填写0时，表示返回非高防弹性公网IP实例。
        /// </summary>
        [JsonProperty("FilterEipType")]
        public long? FilterEipType{ get; set; }

        /// <summary>
        /// 高防弹性公网IP实例的绑定状态搜索条件，取值范围 [BINDING、 BIND、UNBINDING、UNBIND]。该搜索条件只在FilterEipType=1时才有效。
        /// </summary>
        [JsonProperty("FilterEipEipAddressStatus")]
        public string[] FilterEipEipAddressStatus{ get; set; }

        /// <summary>
        /// 是否只获取安全加速实例。填写时，只能填写1或者0。当填写1时，表示返回安全加速实例。当填写0时，表示返回非安全加速实例。
        /// </summary>
        [JsonProperty("FilterDamDDoSStatus")]
        public long? FilterDamDDoSStatus{ get; set; }

        /// <summary>
        /// 获取特定状态的资源，运行中填idle，攻击中填attacking，封堵中填blocking，试用资源填trial
        /// </summary>
        [JsonProperty("FilterStatus")]
        public string FilterStatus{ get; set; }

        /// <summary>
        /// 获取特定的实例Cname
        /// </summary>
        [JsonProperty("FilterCname")]
        public string FilterCname{ get; set; }

        /// <summary>
        /// 批量查询实例ID对应的高防IP实例资源
        /// </summary>
        [JsonProperty("FilterInstanceIdList")]
        public string[] FilterInstanceIdList{ get; set; }

        /// <summary>
        /// 标签搜索
        /// </summary>
        [JsonProperty("FilterTag")]
        public TagFilter FilterTag{ get; set; }

        /// <summary>
        /// 按照套餐类型进行过滤
        /// </summary>
        [JsonProperty("FilterPackType")]
        public string[] FilterPackType{ get; set; }

        /// <summary>
        /// 重保护航搜索
        /// </summary>
        [JsonProperty("FilterConvoy")]
        public ulong? FilterConvoy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "FilterIp", this.FilterIp);
            this.SetParamSimple(map, prefix + "FilterInstanceId", this.FilterInstanceId);
            this.SetParamSimple(map, prefix + "FilterLine", this.FilterLine);
            this.SetParamSimple(map, prefix + "FilterRegion", this.FilterRegion);
            this.SetParamSimple(map, prefix + "FilterName", this.FilterName);
            this.SetParamSimple(map, prefix + "FilterEipType", this.FilterEipType);
            this.SetParamArraySimple(map, prefix + "FilterEipEipAddressStatus.", this.FilterEipEipAddressStatus);
            this.SetParamSimple(map, prefix + "FilterDamDDoSStatus", this.FilterDamDDoSStatus);
            this.SetParamSimple(map, prefix + "FilterStatus", this.FilterStatus);
            this.SetParamSimple(map, prefix + "FilterCname", this.FilterCname);
            this.SetParamArraySimple(map, prefix + "FilterInstanceIdList.", this.FilterInstanceIdList);
            this.SetParamObj(map, prefix + "FilterTag.", this.FilterTag);
            this.SetParamArraySimple(map, prefix + "FilterPackType.", this.FilterPackType);
            this.SetParamSimple(map, prefix + "FilterConvoy", this.FilterConvoy);
        }
    }
}

