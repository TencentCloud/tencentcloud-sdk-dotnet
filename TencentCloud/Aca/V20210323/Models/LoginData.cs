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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoginData : AbstractModel
    {
        
        /// <summary>
        /// 医生ID
        /// </summary>
        [JsonProperty("DoctorId")]
        public string DoctorId{ get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [JsonProperty("DoctorName")]
        public string DoctorName{ get; set; }

        /// <summary>
        /// 医生职级 主治医师、副主任医师、主任医师
        /// </summary>
        [JsonProperty("DoctorLevel")]
        public string DoctorLevel{ get; set; }

        /// <summary>
        /// 医生科室 当前登录科室
        /// </summary>
        [JsonProperty("DoctorDepartment")]
        public string DoctorDepartment{ get; set; }

        /// <summary>
        /// 科室ID
        /// </summary>
        [JsonProperty("DepartmentId")]
        public string DepartmentId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DoctorId", this.DoctorId);
            this.SetParamSimple(map, prefix + "DoctorName", this.DoctorName);
            this.SetParamSimple(map, prefix + "DoctorLevel", this.DoctorLevel);
            this.SetParamSimple(map, prefix + "DoctorDepartment", this.DoctorDepartment);
            this.SetParamSimple(map, prefix + "DepartmentId", this.DepartmentId);
        }
    }
}

