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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EcgDescription : AbstractModel
    {
        
        /// <summary>
        /// 心率
        /// </summary>
        [JsonProperty("HeartRate")]
        public EcgItem HeartRate{ get; set; }

        /// <summary>
        /// 心房率
        /// </summary>
        [JsonProperty("AuricularRate")]
        public EcgItem AuricularRate{ get; set; }

        /// <summary>
        /// 心室率
        /// </summary>
        [JsonProperty("VentricularRate")]
        public EcgItem VentricularRate{ get; set; }

        /// <summary>
        /// 节律
        /// </summary>
        [JsonProperty("Rhythm")]
        public EcgItem Rhythm{ get; set; }

        /// <summary>
        /// P波时间
        /// </summary>
        [JsonProperty("PDuration")]
        public EcgItem PDuration{ get; set; }

        /// <summary>
        /// QRS时间
        /// </summary>
        [JsonProperty("QrsDuration")]
        public EcgItem QrsDuration{ get; set; }

        /// <summary>
        /// QRS电轴
        /// </summary>
        [JsonProperty("QrsAxis")]
        public EcgItem QrsAxis{ get; set; }

        /// <summary>
        /// P-R间期
        /// </summary>
        [JsonProperty("PRInterval")]
        public EcgItem PRInterval{ get; set; }

        /// <summary>
        /// P-P间期
        /// </summary>
        [JsonProperty("PPInterval")]
        public EcgItem PPInterval{ get; set; }

        /// <summary>
        /// R-R间期
        /// </summary>
        [JsonProperty("RRInterval")]
        public EcgItem RRInterval{ get; set; }

        /// <summary>
        /// P-J间期
        /// </summary>
        [JsonProperty("PJInterval")]
        public EcgItem PJInterval{ get; set; }

        /// <summary>
        /// Q-T间期
        /// </summary>
        [JsonProperty("QTInterval")]
        public EcgItem QTInterval{ get; set; }

        /// <summary>
        /// qt/qtc间期
        /// </summary>
        [JsonProperty("QTCInterval")]
        public EcgItem QTCInterval{ get; set; }

        /// <summary>
        /// RV5/SV1振幅
        /// </summary>
        [JsonProperty("Rv5SV1Amplitude")]
        public EcgItem Rv5SV1Amplitude{ get; set; }

        /// <summary>
        /// RV5+SV1振幅
        /// </summary>
        [JsonProperty("Rv5AddSV1Amplitude")]
        public EcgItem Rv5AddSV1Amplitude{ get; set; }

        /// <summary>
        /// PRT电轴
        /// </summary>
        [JsonProperty("PRTAxis")]
        public EcgItem PRTAxis{ get; set; }

        /// <summary>
        /// RV5振幅
        /// </summary>
        [JsonProperty("Rv5Amplitude")]
        public EcgItem Rv5Amplitude{ get; set; }

        /// <summary>
        /// SV1振幅
        /// </summary>
        [JsonProperty("SV1Amplitude")]
        public EcgItem SV1Amplitude{ get; set; }

        /// <summary>
        /// RV6/SV2
        /// </summary>
        [JsonProperty("RV6SV2")]
        public EcgItem RV6SV2{ get; set; }

        /// <summary>
        /// P/QRS/T电轴
        /// </summary>
        [JsonProperty("PQRSTAxis")]
        public EcgItem PQRSTAxis{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HeartRate.", this.HeartRate);
            this.SetParamObj(map, prefix + "AuricularRate.", this.AuricularRate);
            this.SetParamObj(map, prefix + "VentricularRate.", this.VentricularRate);
            this.SetParamObj(map, prefix + "Rhythm.", this.Rhythm);
            this.SetParamObj(map, prefix + "PDuration.", this.PDuration);
            this.SetParamObj(map, prefix + "QrsDuration.", this.QrsDuration);
            this.SetParamObj(map, prefix + "QrsAxis.", this.QrsAxis);
            this.SetParamObj(map, prefix + "PRInterval.", this.PRInterval);
            this.SetParamObj(map, prefix + "PPInterval.", this.PPInterval);
            this.SetParamObj(map, prefix + "RRInterval.", this.RRInterval);
            this.SetParamObj(map, prefix + "PJInterval.", this.PJInterval);
            this.SetParamObj(map, prefix + "QTInterval.", this.QTInterval);
            this.SetParamObj(map, prefix + "QTCInterval.", this.QTCInterval);
            this.SetParamObj(map, prefix + "Rv5SV1Amplitude.", this.Rv5SV1Amplitude);
            this.SetParamObj(map, prefix + "Rv5AddSV1Amplitude.", this.Rv5AddSV1Amplitude);
            this.SetParamObj(map, prefix + "PRTAxis.", this.PRTAxis);
            this.SetParamObj(map, prefix + "Rv5Amplitude.", this.Rv5Amplitude);
            this.SetParamObj(map, prefix + "SV1Amplitude.", this.SV1Amplitude);
            this.SetParamObj(map, prefix + "RV6SV2.", this.RV6SV2);
            this.SetParamObj(map, prefix + "PQRSTAxis.", this.PQRSTAxis);
        }
    }
}

