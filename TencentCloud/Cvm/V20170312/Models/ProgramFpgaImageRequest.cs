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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProgramFpgaImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例的ID信息。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// FPGA镜像文件的COS URL地址。
        /// </summary>
        [JsonProperty("FPGAUrl")]
        public string FPGAUrl{ get; set; }

        /// <summary>
        /// 实例上FPGA卡的DBDF号，不填默认烧录FPGA镜像到实例所拥有的所有FPGA卡。
        /// </summary>
        [JsonProperty("DBDFs")]
        public string[] DBDFs{ get; set; }

        /// <summary>
        /// 试运行，不会执行实际的烧录动作，默认为False。
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "FPGAUrl", this.FPGAUrl);
            this.SetParamArraySimple(map, prefix + "DBDFs.", this.DBDFs);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

