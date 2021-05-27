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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateModuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名称，如视频直播模块。限制：模块名称不得以空格开头，长度不得超过60个字符。
        /// </summary>
        [JsonProperty("ModuleName")]
        public string ModuleName{ get; set; }

        /// <summary>
        /// 默认带宽，单位：M。范围不得超过带宽上下限，详看DescribeConfig。
        /// </summary>
        [JsonProperty("DefaultBandWidth")]
        public long? DefaultBandWidth{ get; set; }

        /// <summary>
        /// 默认镜像，如img-qsdf3ff2。
        /// </summary>
        [JsonProperty("DefaultImageId")]
        public string DefaultImageId{ get; set; }

        /// <summary>
        /// 机型ID。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 默认系统盘大小，单位：G，默认大小为50G。范围不得超过系统盘上下限制，详看DescribeConfig。
        /// </summary>
        [JsonProperty("DefaultSystemDiskSize")]
        public long? DefaultSystemDiskSize{ get; set; }

        /// <summary>
        /// 默认数据盘大小，单位：G。范围不得超过数据盘范围大小，详看DescribeConfig。
        /// </summary>
        [JsonProperty("DefaultDataDiskSize")]
        public long? DefaultDataDiskSize{ get; set; }

        /// <summary>
        /// 是否关闭IP直通。取值范围：
        /// true：表示关闭IP直通
        /// false：表示开通IP直通
        /// </summary>
        [JsonProperty("CloseIpDirect")]
        public bool? CloseIpDirect{ get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }

        /// <summary>
        /// 模块默认安全组列表
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public string[] SecurityGroups{ get; set; }

        /// <summary>
        /// 默认入带宽，单位：M。范围不得超过带宽上下限，详看DescribeConfig。
        /// </summary>
        [JsonProperty("DefaultBandWidthIn")]
        public long? DefaultBandWidthIn{ get; set; }

        /// <summary>
        /// 是否禁止分配外网IP
        /// </summary>
        [JsonProperty("DisableWanIp")]
        public bool? DisableWanIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModuleName", this.ModuleName);
            this.SetParamSimple(map, prefix + "DefaultBandWidth", this.DefaultBandWidth);
            this.SetParamSimple(map, prefix + "DefaultImageId", this.DefaultImageId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "DefaultSystemDiskSize", this.DefaultSystemDiskSize);
            this.SetParamSimple(map, prefix + "DefaultDataDiskSize", this.DefaultDataDiskSize);
            this.SetParamSimple(map, prefix + "CloseIpDirect", this.CloseIpDirect);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamArraySimple(map, prefix + "SecurityGroups.", this.SecurityGroups);
            this.SetParamSimple(map, prefix + "DefaultBandWidthIn", this.DefaultBandWidthIn);
            this.SetParamSimple(map, prefix + "DisableWanIp", this.DisableWanIp);
        }
    }
}

