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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeListBGPInstancesRequest : AbstractModel
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
        /// 资产实例ID搜索，例如，bgp-00000001
        /// </summary>
        [JsonProperty("FilterInstanceId")]
        public string FilterInstanceId{ get; set; }

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
        /// 按照线路搜索, 1: BGP; 2: 三网
        /// </summary>
        [JsonProperty("FilterLine")]
        public ulong? FilterLine{ get; set; }

        /// <summary>
        /// 状态搜索，idle：运行中；attacking：攻击中；blocking：封堵中
        /// </summary>
        [JsonProperty("FilterStatus")]
        public string FilterStatus{ get; set; }

        /// <summary>
        /// 高防包绑定状态搜索，bounding：绑定中； failed：绑定失败
        /// </summary>
        [JsonProperty("FilterBoundStatus")]
        public string FilterBoundStatus{ get; set; }

        /// <summary>
        /// 实例id数组
        /// </summary>
        [JsonProperty("FilterInstanceIdList")]
        public string[] FilterInstanceIdList{ get; set; }

        /// <summary>
        /// 企业版搜索,  1：包含重保护航套餐下的企业版列表, 2: 不包含重保护航套餐的企业版列表
        /// </summary>
        [JsonProperty("FilterEnterpriseFlag")]
        public ulong? FilterEnterpriseFlag{ get; set; }

        /// <summary>
        /// 轻量版搜索
        /// </summary>
        [JsonProperty("FilterLightFlag")]
        public ulong? FilterLightFlag{ get; set; }

        /// <summary>
        /// 定制版搜索
        /// </summary>
        [JsonProperty("FilterChannelFlag")]
        public ulong? FilterChannelFlag{ get; set; }

        /// <summary>
        /// 标签搜索
        /// </summary>
        [JsonProperty("FilterTag")]
        public TagFilter FilterTag{ get; set; }

        /// <summary>
        /// 试用资源搜索，1: 应急防护资源；2：PLG试用资源
        /// </summary>
        [JsonProperty("FilterTrialFlag")]
        public ulong? FilterTrialFlag{ get; set; }

        /// <summary>
        /// 重保护航搜索
        /// </summary>
        [JsonProperty("FilterConvoy")]
        public ulong? FilterConvoy{ get; set; }

        /// <summary>
        /// 默认false；接口传true，返回数据中不包含高级信息，高级信息包含：InstanceList[0].Usage。
        /// </summary>
        [JsonProperty("ExcludeAdvancedInfo")]
        public bool? ExcludeAdvancedInfo{ get; set; }

        /// <summary>
        /// 资产IP数组
        /// </summary>
        [JsonProperty("FilterAssetIpList")]
        public string[] FilterAssetIpList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "FilterIp", this.FilterIp);
            this.SetParamSimple(map, prefix + "FilterInstanceId", this.FilterInstanceId);
            this.SetParamSimple(map, prefix + "FilterRegion", this.FilterRegion);
            this.SetParamSimple(map, prefix + "FilterName", this.FilterName);
            this.SetParamSimple(map, prefix + "FilterLine", this.FilterLine);
            this.SetParamSimple(map, prefix + "FilterStatus", this.FilterStatus);
            this.SetParamSimple(map, prefix + "FilterBoundStatus", this.FilterBoundStatus);
            this.SetParamArraySimple(map, prefix + "FilterInstanceIdList.", this.FilterInstanceIdList);
            this.SetParamSimple(map, prefix + "FilterEnterpriseFlag", this.FilterEnterpriseFlag);
            this.SetParamSimple(map, prefix + "FilterLightFlag", this.FilterLightFlag);
            this.SetParamSimple(map, prefix + "FilterChannelFlag", this.FilterChannelFlag);
            this.SetParamObj(map, prefix + "FilterTag.", this.FilterTag);
            this.SetParamSimple(map, prefix + "FilterTrialFlag", this.FilterTrialFlag);
            this.SetParamSimple(map, prefix + "FilterConvoy", this.FilterConvoy);
            this.SetParamSimple(map, prefix + "ExcludeAdvancedInfo", this.ExcludeAdvancedInfo);
            this.SetParamArraySimple(map, prefix + "FilterAssetIpList.", this.FilterAssetIpList);
        }
    }
}

