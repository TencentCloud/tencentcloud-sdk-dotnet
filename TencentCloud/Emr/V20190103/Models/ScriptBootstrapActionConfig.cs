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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScriptBootstrapActionConfig : AbstractModel
    {
        
        /// <summary>
        /// 脚本的cos地址，参照格式：https://beijing-111111.cos.ap-beijing.myqcloud.com/data/test.sh查询cos存储桶列表：[存储桶列表](https://console.cloud.tencent.com/cos/bucket)
        /// </summary>
        [JsonProperty("CosFileURI")]
        public string CosFileURI{ get; set; }

        /// <summary>
        /// 引导脚步执行时机范围
        /// <li>resourceAfter：节点初始化后</li>
        /// <li>clusterAfter：集群启动后</li>
        /// <li>clusterBefore：集群启动前</li>
        /// </summary>
        [JsonProperty("ExecutionMoment")]
        public string ExecutionMoment{ get; set; }

        /// <summary>
        /// 执行脚本参数，参数格式请遵循标准Shell规范
        /// </summary>
        [JsonProperty("Args")]
        public string[] Args{ get; set; }

        /// <summary>
        /// 脚本文件名
        /// </summary>
        [JsonProperty("CosFileName")]
        public string CosFileName{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosFileURI", this.CosFileURI);
            this.SetParamSimple(map, prefix + "ExecutionMoment", this.ExecutionMoment);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
            this.SetParamSimple(map, prefix + "CosFileName", this.CosFileName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

