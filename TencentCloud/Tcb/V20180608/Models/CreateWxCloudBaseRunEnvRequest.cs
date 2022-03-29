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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateWxCloudBaseRunEnvRequest : AbstractModel
    {
        
        /// <summary>
        /// wx应用Id
        /// </summary>
        [JsonProperty("WxAppId")]
        public string WxAppId{ get; set; }

        /// <summary>
        /// 环境别名，要以a-z开头，不能包含 a-z,0-9,- 以外的字符
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 用户享有的免费额度级别，目前只能为“basic”，不传该字段或该字段为空，标识不享受免费额度。
        /// </summary>
        [JsonProperty("FreeQuota")]
        public string FreeQuota{ get; set; }

        /// <summary>
        /// 订单标记。建议使用方统一转大小写之后再判断。
        /// QuickStart：快速启动来源
        /// Activity：活动来源
        /// </summary>
        [JsonProperty("Flag")]
        public string Flag{ get; set; }

        /// <summary>
        /// 私有网络Id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网列表
        /// </summary>
        [JsonProperty("SubNetIds")]
        public string[] SubNetIds{ get; set; }

        /// <summary>
        /// 是否打开云调用
        /// </summary>
        [JsonProperty("IsOpenCloudInvoke")]
        public bool? IsOpenCloudInvoke{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WxAppId", this.WxAppId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "FreeQuota", this.FreeQuota);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "SubNetIds.", this.SubNetIds);
            this.SetParamSimple(map, prefix + "IsOpenCloudInvoke", this.IsOpenCloudInvoke);
        }
    }
}

